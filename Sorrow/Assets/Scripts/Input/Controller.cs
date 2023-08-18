//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Input/Controller.inputactions
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

public partial class @Controller: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""dce871d9-5e8a-4688-a139-21fed9ad48c6"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""61801c95-b4c1-4b8e-a15c-8fe6baed0642"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": ""ScaleVector2(x=4,y=4)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""00792115-a95e-4bbf-9332-3ffd7ddf035a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""306986a6-cd23-4216-8b36-b827b37dfc8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""9be0e587-89a0-492d-962f-6dda592070d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""9f84b0dd-2281-4b64-ad2d-c3e9bb37302a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1277dd3c-69ce-406e-b4ab-59de86d9b4c8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1dcf4bb7-edf1-442f-a98c-e571a0d4be12"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e7e0176-e191-4be4-97d4-dcdee6851b20"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9cd4a8a5-d9b1-4709-aecc-a72c7a1707e0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""78ecbd08-0482-498d-aea9-c213c075cc01"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1fbc541d-4d49-46a6-a2eb-57843c350715"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2c96249-6984-4495-8176-0ea1a3fab220"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""317a2d28-a53b-4374-a026-808f651fcb3e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""798ee452-7c3e-4879-9940-2610eff65403"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5710d2d-170a-4df4-b028-92ab61c4ea86"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57a96abd-67ad-4d69-8a77-99741ad31f4e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7f5e8a1-15c1-4519-9e1a-3218cc98f5c2"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f95e3de5-cd7e-4c62-b881-5af81c9bb76c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d6f736c-40ec-4cde-b4ad-701990e08f05"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialog"",
            ""id"": ""b0d2f008-6e12-45fe-8c30-de1daa5adcec"",
            ""actions"": [
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""cc2931f3-5826-458b-91f8-0655392e8a19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""eb75302b-d0f8-40a9-af32-6c5475697fda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Auto"",
                    ""type"": ""Button"",
                    ""id"": ""164119d4-f61e-420b-aff2-cb78c6ec7a2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShowTranscript"",
                    ""type"": ""Button"",
                    ""id"": ""e9b5ba23-7c04-451b-9c50-102010308301"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3bd42fad-3c72-4247-8727-51c33838b400"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33a43fbe-b41a-4363-be00-dcfd614f5843"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71c8bdf7-7236-4381-bf24-d249c65daee1"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f875695a-a80f-4043-837e-9aec9b6a37c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Auto"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75f72d90-08ce-48fd-acd1-1ded1ad56c45"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ShowTranscript"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerRun"",
            ""id"": ""10c1943c-ee05-4f5d-a2e3-7633c58a9873"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d19f3d02-9972-4a39-940a-a0d7add37d40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eda5d89d-d905-4b34-b132-3b34f323734e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1127a7b-1d57-48b6-9e9c-822eba8881a9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_UseItem = m_Player.FindAction("UseItem", throwIfNotFound: true);
        m_Player_Camera = m_Player.FindAction("Camera", throwIfNotFound: true);
        m_Player_Drop = m_Player.FindAction("Drop", throwIfNotFound: true);
        // Dialog
        m_Dialog = asset.FindActionMap("Dialog", throwIfNotFound: true);
        m_Dialog_Continue = m_Dialog.FindAction("Continue", throwIfNotFound: true);
        m_Dialog_Skip = m_Dialog.FindAction("Skip", throwIfNotFound: true);
        m_Dialog_Auto = m_Dialog.FindAction("Auto", throwIfNotFound: true);
        m_Dialog_ShowTranscript = m_Dialog.FindAction("ShowTranscript", throwIfNotFound: true);
        // PlayerRun
        m_PlayerRun = asset.FindActionMap("PlayerRun", throwIfNotFound: true);
        m_PlayerRun_Jump = m_PlayerRun.FindAction("Jump", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_UseItem;
    private readonly InputAction m_Player_Camera;
    private readonly InputAction m_Player_Drop;
    public struct PlayerActions
    {
        private @Controller m_Wrapper;
        public PlayerActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @UseItem => m_Wrapper.m_Player_UseItem;
        public InputAction @Camera => m_Wrapper.m_Player_Camera;
        public InputAction @Drop => m_Wrapper.m_Player_Drop;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @UseItem.started += instance.OnUseItem;
            @UseItem.performed += instance.OnUseItem;
            @UseItem.canceled += instance.OnUseItem;
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Drop.started += instance.OnDrop;
            @Drop.performed += instance.OnDrop;
            @Drop.canceled += instance.OnDrop;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @UseItem.started -= instance.OnUseItem;
            @UseItem.performed -= instance.OnUseItem;
            @UseItem.canceled -= instance.OnUseItem;
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Drop.started -= instance.OnDrop;
            @Drop.performed -= instance.OnDrop;
            @Drop.canceled -= instance.OnDrop;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Dialog
    private readonly InputActionMap m_Dialog;
    private List<IDialogActions> m_DialogActionsCallbackInterfaces = new List<IDialogActions>();
    private readonly InputAction m_Dialog_Continue;
    private readonly InputAction m_Dialog_Skip;
    private readonly InputAction m_Dialog_Auto;
    private readonly InputAction m_Dialog_ShowTranscript;
    public struct DialogActions
    {
        private @Controller m_Wrapper;
        public DialogActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Continue => m_Wrapper.m_Dialog_Continue;
        public InputAction @Skip => m_Wrapper.m_Dialog_Skip;
        public InputAction @Auto => m_Wrapper.m_Dialog_Auto;
        public InputAction @ShowTranscript => m_Wrapper.m_Dialog_ShowTranscript;
        public InputActionMap Get() { return m_Wrapper.m_Dialog; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogActions set) { return set.Get(); }
        public void AddCallbacks(IDialogActions instance)
        {
            if (instance == null || m_Wrapper.m_DialogActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DialogActionsCallbackInterfaces.Add(instance);
            @Continue.started += instance.OnContinue;
            @Continue.performed += instance.OnContinue;
            @Continue.canceled += instance.OnContinue;
            @Skip.started += instance.OnSkip;
            @Skip.performed += instance.OnSkip;
            @Skip.canceled += instance.OnSkip;
            @Auto.started += instance.OnAuto;
            @Auto.performed += instance.OnAuto;
            @Auto.canceled += instance.OnAuto;
            @ShowTranscript.started += instance.OnShowTranscript;
            @ShowTranscript.performed += instance.OnShowTranscript;
            @ShowTranscript.canceled += instance.OnShowTranscript;
        }

        private void UnregisterCallbacks(IDialogActions instance)
        {
            @Continue.started -= instance.OnContinue;
            @Continue.performed -= instance.OnContinue;
            @Continue.canceled -= instance.OnContinue;
            @Skip.started -= instance.OnSkip;
            @Skip.performed -= instance.OnSkip;
            @Skip.canceled -= instance.OnSkip;
            @Auto.started -= instance.OnAuto;
            @Auto.performed -= instance.OnAuto;
            @Auto.canceled -= instance.OnAuto;
            @ShowTranscript.started -= instance.OnShowTranscript;
            @ShowTranscript.performed -= instance.OnShowTranscript;
            @ShowTranscript.canceled -= instance.OnShowTranscript;
        }

        public void RemoveCallbacks(IDialogActions instance)
        {
            if (m_Wrapper.m_DialogActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDialogActions instance)
        {
            foreach (var item in m_Wrapper.m_DialogActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DialogActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DialogActions @Dialog => new DialogActions(this);

    // PlayerRun
    private readonly InputActionMap m_PlayerRun;
    private List<IPlayerRunActions> m_PlayerRunActionsCallbackInterfaces = new List<IPlayerRunActions>();
    private readonly InputAction m_PlayerRun_Jump;
    public struct PlayerRunActions
    {
        private @Controller m_Wrapper;
        public PlayerRunActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerRun_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerRun; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerRunActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerRunActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerRunActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerRunActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayerRunActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayerRunActions instance)
        {
            if (m_Wrapper.m_PlayerRunActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerRunActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerRunActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerRunActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerRunActions @PlayerRun => new PlayerRunActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
    }
    public interface IDialogActions
    {
        void OnContinue(InputAction.CallbackContext context);
        void OnSkip(InputAction.CallbackContext context);
        void OnAuto(InputAction.CallbackContext context);
        void OnShowTranscript(InputAction.CallbackContext context);
    }
    public interface IPlayerRunActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}