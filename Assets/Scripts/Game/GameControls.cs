// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Game/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""f77889c0-1450-479c-9434-41c3d8d0a470"",
            ""actions"": [
                {
                    ""name"": ""BT1"",
                    ""type"": ""Button"",
                    ""id"": ""75107f7c-5c72-40ed-a513-415ebf8e7a3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BT2"",
                    ""type"": ""Button"",
                    ""id"": ""8c09530b-5a4a-43b0-a8b7-8992eef1772a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BT3"",
                    ""type"": ""Button"",
                    ""id"": ""23cb61c3-3a06-4040-ba7f-462603ffb934"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BT4"",
                    ""type"": ""Button"",
                    ""id"": ""5fcf68cc-fdaf-454d-ad20-9171a1db4bdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FX1"",
                    ""type"": ""Button"",
                    ""id"": ""3c95b920-488c-440a-9866-97542177ef9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FX2"",
                    ""type"": ""Button"",
                    ""id"": ""5b5ca040-11bd-417f-9762-a046c3d08c39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""979c0023-3dcc-413c-a294-4bc68bda5473"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BT1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2a208be-921d-4bd7-ad67-6d968f82f58a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BT1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2f5486d-2c5e-404d-b999-22d92e7af645"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BT2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa1ce1a9-af22-4bf2-b3c6-fefd17335930"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BT2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cde30889-618f-43c9-b4ef-adf82cb9eb9b"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BT3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf9a2224-ae68-427a-8e7d-99ae9f17366c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BT3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""204edcb7-25c4-4003-9ee6-2c93460494f1"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""BT4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65375110-865a-4270-b949-49e4461cbb36"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BT4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6fe45f6-0a6b-42e4-95f3-fd08ce838a08"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""FX1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b7475f3-2a1d-4597-bd20-e99cf0085973"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FX1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96e7343e-01d9-4f1a-bc29-e9f513a4d8da"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""FX2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39b5fa4b-0c3d-4d38-aa54-81125834c4e8"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FX2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_BT1 = m_Gameplay.FindAction("BT1", throwIfNotFound: true);
        m_Gameplay_BT2 = m_Gameplay.FindAction("BT2", throwIfNotFound: true);
        m_Gameplay_BT3 = m_Gameplay.FindAction("BT3", throwIfNotFound: true);
        m_Gameplay_BT4 = m_Gameplay.FindAction("BT4", throwIfNotFound: true);
        m_Gameplay_FX1 = m_Gameplay.FindAction("FX1", throwIfNotFound: true);
        m_Gameplay_FX2 = m_Gameplay.FindAction("FX2", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_BT1;
    private readonly InputAction m_Gameplay_BT2;
    private readonly InputAction m_Gameplay_BT3;
    private readonly InputAction m_Gameplay_BT4;
    private readonly InputAction m_Gameplay_FX1;
    private readonly InputAction m_Gameplay_FX2;
    public struct GameplayActions
    {
        private @GameControls m_Wrapper;
        public GameplayActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @BT1 => m_Wrapper.m_Gameplay_BT1;
        public InputAction @BT2 => m_Wrapper.m_Gameplay_BT2;
        public InputAction @BT3 => m_Wrapper.m_Gameplay_BT3;
        public InputAction @BT4 => m_Wrapper.m_Gameplay_BT4;
        public InputAction @FX1 => m_Wrapper.m_Gameplay_FX1;
        public InputAction @FX2 => m_Wrapper.m_Gameplay_FX2;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @BT1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT1;
                @BT1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT1;
                @BT1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT1;
                @BT2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT2;
                @BT2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT2;
                @BT2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT2;
                @BT3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT3;
                @BT3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT3;
                @BT3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT3;
                @BT4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT4;
                @BT4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT4;
                @BT4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBT4;
                @FX1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFX1;
                @FX1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFX1;
                @FX1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFX1;
                @FX2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFX2;
                @FX2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFX2;
                @FX2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFX2;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BT1.started += instance.OnBT1;
                @BT1.performed += instance.OnBT1;
                @BT1.canceled += instance.OnBT1;
                @BT2.started += instance.OnBT2;
                @BT2.performed += instance.OnBT2;
                @BT2.canceled += instance.OnBT2;
                @BT3.started += instance.OnBT3;
                @BT3.performed += instance.OnBT3;
                @BT3.canceled += instance.OnBT3;
                @BT4.started += instance.OnBT4;
                @BT4.performed += instance.OnBT4;
                @BT4.canceled += instance.OnBT4;
                @FX1.started += instance.OnFX1;
                @FX1.performed += instance.OnFX1;
                @FX1.canceled += instance.OnFX1;
                @FX2.started += instance.OnFX2;
                @FX2.performed += instance.OnFX2;
                @FX2.canceled += instance.OnFX2;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnBT1(InputAction.CallbackContext context);
        void OnBT2(InputAction.CallbackContext context);
        void OnBT3(InputAction.CallbackContext context);
        void OnBT4(InputAction.CallbackContext context);
        void OnFX1(InputAction.CallbackContext context);
        void OnFX2(InputAction.CallbackContext context);
    }
}
