//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""60ddfc95-9ecd-49db-9c85-aeadb7fd1e76"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""7171be4c-ac6c-4f6c-aa02-78e692223ba6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""936e59b2-fa47-4cd3-91ee-b0268edd737d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""035b9430-9aa7-40a5-addd-c9b8d439080a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ComboLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6d9e07d3-f19e-4f6d-b289-ae14d7114cb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ComboRight"",
                    ""type"": ""Button"",
                    ""id"": ""d0b53563-278b-40c0-9e42-cdc06ff8800f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ComboUp"",
                    ""type"": ""Button"",
                    ""id"": ""b3e16b56-1393-4fe9-99a5-4cea52bd7985"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ComboDown"",
                    ""type"": ""Button"",
                    ""id"": ""318d09ee-c522-4ffd-a039-2e99d1b24ae7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ComboAttack"",
                    ""type"": ""Button"",
                    ""id"": ""87240da7-ed8d-4968-9827-090ab5bf1f95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ComboDefend"",
                    ""type"": ""Button"",
                    ""id"": ""0a20fdd8-a4fe-4de3-b92c-6ea4dda7a91f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""796c8707-6cc4-429e-9870-0e3fdd8f97fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OpenSpellBook"",
                    ""type"": ""Button"",
                    ""id"": ""f5764d05-d8b4-4b7e-875f-4dda866d5dba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""aba52fc5-8b92-4a55-9ebe-82c061b54456"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ac30b064-ee0d-4311-9be7-45ad15c0037f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""30c3d768-3372-4a37-8e4b-7239d6e21322"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e51482b1-42b6-4a2a-92d1-3dce1c18fa88"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3d0de254-e342-417b-95cb-e0d0df8a2422"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f2e91ea1-acdc-4f50-beb4-5b9b5333932a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""719f6ffa-5916-4a1e-8abd-a3b0961f6155"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""354976f8-a169-4c1a-95d0-b6c4208b9fcc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComboLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89acb3d0-d352-42e2-abc8-d3b72037772b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComboRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90ca4c43-4e46-43a9-a99e-b20b63dd6630"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComboDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f430276d-e3df-40de-b1bd-8de046b9d60d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComboUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45d29adc-9302-4b4a-93ec-967965b8bb2d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComboAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""967cdb94-e686-4dfc-9994-3b5d143e5185"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComboDefend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4500502c-c706-4204-91d1-c79bd089d500"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0edaec2a-89dc-48f1-a98c-7d9899a03efb"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenSpellBook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""d783f666-70ba-4065-b3a7-a62b604823f2"",
            ""actions"": [
                {
                    ""name"": ""Advance"",
                    ""type"": ""Button"",
                    ""id"": ""3757ac56-8db2-4a25-9daa-f5bf05d9a530"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05bc021f-e05b-4adb-811b-a648a80421c5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Advance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""873bd721-140d-43c0-b414-4173ccc94fa0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Advance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99cb511a-46da-4ae4-9052-3cc5e840fb79"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Advance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""00658d4b-38ee-4115-886d-51f30fb8f232"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""ca8521dc-6efc-409d-8cad-7e11dbd1e9a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseExit"",
                    ""type"": ""Button"",
                    ""id"": ""a848c041-ccf1-4d70-8cce-d9aa9a3419fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f594705f-e97a-4d03-8575-626fdd23c8be"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab6e06a7-b861-48f7-aa52-d23111bf1cd2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseExit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_ComboLeft = m_Gameplay.FindAction("ComboLeft", throwIfNotFound: true);
        m_Gameplay_ComboRight = m_Gameplay.FindAction("ComboRight", throwIfNotFound: true);
        m_Gameplay_ComboUp = m_Gameplay.FindAction("ComboUp", throwIfNotFound: true);
        m_Gameplay_ComboDown = m_Gameplay.FindAction("ComboDown", throwIfNotFound: true);
        m_Gameplay_ComboAttack = m_Gameplay.FindAction("ComboAttack", throwIfNotFound: true);
        m_Gameplay_ComboDefend = m_Gameplay.FindAction("ComboDefend", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_OpenSpellBook = m_Gameplay.FindAction("OpenSpellBook", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Advance = m_Dialogue.FindAction("Advance", throwIfNotFound: true);
        // PauseMenu
        m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
        m_PauseMenu_Select = m_PauseMenu.FindAction("Select", throwIfNotFound: true);
        m_PauseMenu_PauseExit = m_PauseMenu.FindAction("PauseExit", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_ComboLeft;
    private readonly InputAction m_Gameplay_ComboRight;
    private readonly InputAction m_Gameplay_ComboUp;
    private readonly InputAction m_Gameplay_ComboDown;
    private readonly InputAction m_Gameplay_ComboAttack;
    private readonly InputAction m_Gameplay_ComboDefend;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_OpenSpellBook;
    public struct GameplayActions
    {
        private @PlayerInput m_Wrapper;
        public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @ComboLeft => m_Wrapper.m_Gameplay_ComboLeft;
        public InputAction @ComboRight => m_Wrapper.m_Gameplay_ComboRight;
        public InputAction @ComboUp => m_Wrapper.m_Gameplay_ComboUp;
        public InputAction @ComboDown => m_Wrapper.m_Gameplay_ComboDown;
        public InputAction @ComboAttack => m_Wrapper.m_Gameplay_ComboAttack;
        public InputAction @ComboDefend => m_Wrapper.m_Gameplay_ComboDefend;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @OpenSpellBook => m_Wrapper.m_Gameplay_OpenSpellBook;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @ComboLeft.started += instance.OnComboLeft;
            @ComboLeft.performed += instance.OnComboLeft;
            @ComboLeft.canceled += instance.OnComboLeft;
            @ComboRight.started += instance.OnComboRight;
            @ComboRight.performed += instance.OnComboRight;
            @ComboRight.canceled += instance.OnComboRight;
            @ComboUp.started += instance.OnComboUp;
            @ComboUp.performed += instance.OnComboUp;
            @ComboUp.canceled += instance.OnComboUp;
            @ComboDown.started += instance.OnComboDown;
            @ComboDown.performed += instance.OnComboDown;
            @ComboDown.canceled += instance.OnComboDown;
            @ComboAttack.started += instance.OnComboAttack;
            @ComboAttack.performed += instance.OnComboAttack;
            @ComboAttack.canceled += instance.OnComboAttack;
            @ComboDefend.started += instance.OnComboDefend;
            @ComboDefend.performed += instance.OnComboDefend;
            @ComboDefend.canceled += instance.OnComboDefend;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @OpenSpellBook.started += instance.OnOpenSpellBook;
            @OpenSpellBook.performed += instance.OnOpenSpellBook;
            @OpenSpellBook.canceled += instance.OnOpenSpellBook;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @ComboLeft.started -= instance.OnComboLeft;
            @ComboLeft.performed -= instance.OnComboLeft;
            @ComboLeft.canceled -= instance.OnComboLeft;
            @ComboRight.started -= instance.OnComboRight;
            @ComboRight.performed -= instance.OnComboRight;
            @ComboRight.canceled -= instance.OnComboRight;
            @ComboUp.started -= instance.OnComboUp;
            @ComboUp.performed -= instance.OnComboUp;
            @ComboUp.canceled -= instance.OnComboUp;
            @ComboDown.started -= instance.OnComboDown;
            @ComboDown.performed -= instance.OnComboDown;
            @ComboDown.canceled -= instance.OnComboDown;
            @ComboAttack.started -= instance.OnComboAttack;
            @ComboAttack.performed -= instance.OnComboAttack;
            @ComboAttack.canceled -= instance.OnComboAttack;
            @ComboDefend.started -= instance.OnComboDefend;
            @ComboDefend.performed -= instance.OnComboDefend;
            @ComboDefend.canceled -= instance.OnComboDefend;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @OpenSpellBook.started -= instance.OnOpenSpellBook;
            @OpenSpellBook.performed -= instance.OnOpenSpellBook;
            @OpenSpellBook.canceled -= instance.OnOpenSpellBook;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private List<IDialogueActions> m_DialogueActionsCallbackInterfaces = new List<IDialogueActions>();
    private readonly InputAction m_Dialogue_Advance;
    public struct DialogueActions
    {
        private @PlayerInput m_Wrapper;
        public DialogueActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Advance => m_Wrapper.m_Dialogue_Advance;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void AddCallbacks(IDialogueActions instance)
        {
            if (instance == null || m_Wrapper.m_DialogueActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DialogueActionsCallbackInterfaces.Add(instance);
            @Advance.started += instance.OnAdvance;
            @Advance.performed += instance.OnAdvance;
            @Advance.canceled += instance.OnAdvance;
        }

        private void UnregisterCallbacks(IDialogueActions instance)
        {
            @Advance.started -= instance.OnAdvance;
            @Advance.performed -= instance.OnAdvance;
            @Advance.canceled -= instance.OnAdvance;
        }

        public void RemoveCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDialogueActions instance)
        {
            foreach (var item in m_Wrapper.m_DialogueActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DialogueActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);

    // PauseMenu
    private readonly InputActionMap m_PauseMenu;
    private List<IPauseMenuActions> m_PauseMenuActionsCallbackInterfaces = new List<IPauseMenuActions>();
    private readonly InputAction m_PauseMenu_Select;
    private readonly InputAction m_PauseMenu_PauseExit;
    public struct PauseMenuActions
    {
        private @PlayerInput m_Wrapper;
        public PauseMenuActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_PauseMenu_Select;
        public InputAction @PauseExit => m_Wrapper.m_PauseMenu_PauseExit;
        public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
        public void AddCallbacks(IPauseMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Add(instance);
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @PauseExit.started += instance.OnPauseExit;
            @PauseExit.performed += instance.OnPauseExit;
            @PauseExit.canceled += instance.OnPauseExit;
        }

        private void UnregisterCallbacks(IPauseMenuActions instance)
        {
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @PauseExit.started -= instance.OnPauseExit;
            @PauseExit.performed -= instance.OnPauseExit;
            @PauseExit.canceled -= instance.OnPauseExit;
        }

        public void RemoveCallbacks(IPauseMenuActions instance)
        {
            if (m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPauseMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_PauseMenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnComboLeft(InputAction.CallbackContext context);
        void OnComboRight(InputAction.CallbackContext context);
        void OnComboUp(InputAction.CallbackContext context);
        void OnComboDown(InputAction.CallbackContext context);
        void OnComboAttack(InputAction.CallbackContext context);
        void OnComboDefend(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnOpenSpellBook(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnAdvance(InputAction.CallbackContext context);
    }
    public interface IPauseMenuActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnPauseExit(InputAction.CallbackContext context);
    }
}