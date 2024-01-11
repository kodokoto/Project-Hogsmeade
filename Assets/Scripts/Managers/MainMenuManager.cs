using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [Header("Managers")]
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private SaveManager _saveManager;

    [Header("Data")]
    [SerializeField] private SceneSO _startingScene;

    [Header("UI")]
    [SerializeField] private TMP_InputField _saveNameInputField;
    [SerializeField] private GameObject _savedGamesPanel;

    [Header("Broadcasts")]
    [SerializeField] private LoadSceneSignalSO _loadSceneSignal;


    public void OnEnable()
    {
        _inputManager.EnablePauseMenuInput();
    }

    public void StartNewGame()
    {
        Debug.Log("Start new game: " + _saveNameInputField.text);
        if (_saveNameInputField.text == "")
        {
            Debug.LogError("Save name is empty");
            return;
        }
        _saveManager.CreateNewSave(_saveNameInputField.text);
        Debug.Log("Broadcasting load scene event from main menu");
        _loadSceneSignal.Trigger(_startingScene);
    }

    public void ShowLoadGameScreen()
    {
        Debug.Log("Load game");
        _savedGamesPanel.SetActive(true);
        List<string> saves = FileManager.GetAllSaveFiles();
        Debug.Log("Found " + saves.Count + " saves");

        // create buttons for each save
        for (int i = 0; i < saves.Count; i++)
        {
            Debug.Log("Creating button for save " + saves[i]);
            GameObject button = new GameObject();
            button.transform.SetParent(_savedGamesPanel.transform);
            button.AddComponent<Button>();
            button.GetComponent<Button>().onClick.AddListener(() => StartCoroutine(LoadGame(button.GetComponent<TextMeshProUGUI>().text)));
            button.AddComponent<TextMeshProUGUI>();
            button.GetComponent<TextMeshProUGUI>().text = saves[i];
            // position button
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -i * 50);
        }
    }
    private IEnumerator LoadGame(string saveName)
	{
        _saveManager.saveFilename = saveName + ".json";

        if (_saveManager.LoadSaveDataFromDisk())
        {
            Debug.Log("Loaded save data from disk");
        }
        else
        {
            Debug.Log("Failed to load save data from disk");
        }

		yield return StartCoroutine(_saveManager.LoadInventory());

        yield return StartCoroutine(_saveManager.LoadPlayerData());

        yield return StartCoroutine(_saveManager.LoadPlayerSpawnPoint());

		var locationGuid = _saveManager._gameSave._scene_guid;
		var asyncOperationHandle = Addressables.LoadAssetAsync<SceneSO>(locationGuid);

		yield return asyncOperationHandle;

        Debug.Log("Loaded scene " + asyncOperationHandle.Result.name);
		if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
		{
			SceneSO locationSO = asyncOperationHandle.Result;
			_loadSceneSignal.Trigger(locationSO);
		}

	}

    public void QuitGame()
    {
        Application.Quit();
    }
}