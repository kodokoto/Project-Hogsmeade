using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public enum GameState {
    Playing,
    Won,
    Lost
}

// Everything that needs to be saved should be in this class
public class GameManager : MonoBehaviour
{
    private GameState gameState;

    [Header("Data")]
    [SerializeField] private PlayerSpawnPoint currentSpawnPoint;
    [SerializeField] private PlayerData playerData;

    [Header("Listeners")]
    [SerializeField] private SimpleEventChannelSO _onRetry;

    [Header("Channels")]
    [SerializeField] private SpawnPointEventChannel spawnPointChannel;

    private void Awake()
    {

    }

    private void OnEnable()
    {
        spawnPointChannel.OnSpawnPointChanged += SetSpawnPoint;
        _onRetry.OnTrigger += RestartGame;
    }

    private void RestartGame()
    {
        playerData.SoftReset();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void SaveAndQuit()
    {
        // SaveSystem.SavePlayerData(playerData);
        Application.Quit();
    }

    private void OnSave()
    {
        // SaveSystem.SavePlayerData(playerData);
    }

    private void OnDisable()
    {
        spawnPointChannel.OnSpawnPointChanged -= SetSpawnPoint;
    }



    public void SetSpawnPoint(Vector3 spawnPoint)
    {
        currentSpawnPoint.SetSpawnPoint(spawnPoint);
    }
}
// public class GameManager : MonoBehaviour
// {
//     public static GameManager instance;
//     public GameState gameState;
//     private void Awake()
//     {
//         if (instance == null) {
//             instance = this;
//         } else {
//             Destroy(gameObject);
//         }
//     }

//     private void Start()
//     {
//         gameState = GameState.Playing;
//     }

//     public void SetGameState(GameState state)
//     {
//         switch (state)
//         {
//             case GameState.Playing:
//                 HandleGamePlaying();
//                 break;
//             case GameState.Won:
//                 HandleGameWon();
//                 break;
//             case GameState.Lost:
//                 HandleGameLost();
//                 break;
//         }
//     }

//     public void Retry()
//     {
//         SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
//     }

//     public void RestartGame()
//     {
//         Destroy(gameObject);
//         instance = null;
//         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//     }

//     public void MainMenu()
//     {
//         // reset spawn point
//         PlayerSpawnPoint.instance.SetSpawnPoint(Vector3.zero);
//         SceneManager.LoadSceneAsync("MainMenu");
//     }

//     public GameState GetGameState()
//     {
//         return gameState;
//     }

//     // handlers

//     private void HandleGameLost()
//     {
//         // Debug.Log("Game lost");
//         // if (gameState == GameState.Playing)
//         // {
//         //     Debug.Log("Game lost for real");
//         //     gameState = GameState.Lost;
//         //     UIManager.instance.ShowGameOverScreen();
//         // }
//         // else
//         // {
//         //     Debug.LogWarning("Tried to set game state to lost when it is not playing");
//         // }
//     }

//     private void HandleGameWon()
//     {
//         // if (gameState == GameState.Playing)
//         // {
//         //     gameState = GameState.Won;
//         //     UIManager.instance.ShowWinScreen();
//         // }
//         // else
//         // {
//         //     Debug.LogWarning("Tried to set game state to won when it is not playing");
//         // }
//     }

//     private void HandleGamePlaying()
//     {
//         // if (gameState == GameState.Won)
//         // {
//         //     gameState = GameState.Playing;
//         //     UIManager.instance.HideWinScreen();
//         // }
//         // else if (gameState == GameState.Lost)
//         // {
//         //     gameState = GameState.Playing;
//         //     UIManager.instance.HideGameOverScreen();
//         // }
//         // else
//         // {
//         //     Debug.LogWarning("Tried to set game state to playing when it is already playing");
//         // }
//     }

// }
