// GENERATED AUTOMATICALLY FROM 'Assets/Data/GameControls.inputactions'

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
            ""name"": ""PlayerControls"",
            ""id"": ""71ff8d6a-8c33-4693-9008-243f6de2dd91"",
            ""actions"": [
                {
                    ""name"": ""MoveCursor"",
                    ""type"": ""Value"",
                    ""id"": ""1f307f4d-d07b-4543-807e-1a1b5531212b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Choose"",
                    ""type"": ""Button"",
                    ""id"": ""517cfcf6-ed8d-4186-8f48-a295caac1984"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EndTurn"",
                    ""type"": ""Button"",
                    ""id"": ""3b977788-809c-41cd-b53d-9ea5f9b824d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8888a584-5c19-4a8f-a3d1-f088ea0ae96f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KeyboardVector2D"",
                    ""id"": ""726038ba-e105-472c-88fa-30acf9f8a6cb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6ac5edee-ac52-441a-b006-2c48d3101fa0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c67b217c-2c84-4531-932d-c85c2a0a00d6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1ad9fcad-bf96-433a-aeb1-8105b2ba42d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fa61860e-a5b4-4663-9085-93daf76ba7b8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ControllerVector2D"",
                    ""id"": ""4a2fe241-b5ff-4aa1-a4fb-4c880ac1d90f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9e827bf8-6822-4abb-81c7-c09907333c15"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1fb0e6bb-4c84-4243-bce7-145a8bb3c816"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""96486af1-b351-4f06-b905-95ca664c01d4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b301411c-ca90-41e2-b7d4-07ed27f894f0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b3c02dfc-eec2-4de3-a18b-cbf139644035"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c50570a-7768-48b1-a3cb-e2318646de51"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afd1c77e-5a6f-4856-9c1e-578c186eaf82"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Choose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c88e3c8-fe93-4cf9-85a5-207ccae90859"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EndTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d4b962b-8721-4e5e-891c-b0809a3f6e2a"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EndTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8309b75c-f868-44df-9135-cf494351865e"",
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
                    ""id"": ""d173da4f-5b01-4cff-9a6d-dd6e09a11a70"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8dc050c2-7fb5-4db9-8f13-a3d0582e75da"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_MoveCursor = m_PlayerControls.FindAction("MoveCursor", throwIfNotFound: true);
        m_PlayerControls_Choose = m_PlayerControls.FindAction("Choose", throwIfNotFound: true);
        m_PlayerControls_EndTurn = m_PlayerControls.FindAction("EndTurn", throwIfNotFound: true);
        m_PlayerControls_Pause = m_PlayerControls.FindAction("Pause", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_MoveCursor;
    private readonly InputAction m_PlayerControls_Choose;
    private readonly InputAction m_PlayerControls_EndTurn;
    private readonly InputAction m_PlayerControls_Pause;
    public struct PlayerControlsActions
    {
        private @GameControls m_Wrapper;
        public PlayerControlsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCursor => m_Wrapper.m_PlayerControls_MoveCursor;
        public InputAction @Choose => m_Wrapper.m_PlayerControls_Choose;
        public InputAction @EndTurn => m_Wrapper.m_PlayerControls_EndTurn;
        public InputAction @Pause => m_Wrapper.m_PlayerControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @MoveCursor.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMoveCursor;
                @Choose.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnChoose;
                @Choose.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnChoose;
                @Choose.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnChoose;
                @EndTurn.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEndTurn;
                @EndTurn.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEndTurn;
                @EndTurn.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEndTurn;
                @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCursor.started += instance.OnMoveCursor;
                @MoveCursor.performed += instance.OnMoveCursor;
                @MoveCursor.canceled += instance.OnMoveCursor;
                @Choose.started += instance.OnChoose;
                @Choose.performed += instance.OnChoose;
                @Choose.canceled += instance.OnChoose;
                @EndTurn.started += instance.OnEndTurn;
                @EndTurn.performed += instance.OnEndTurn;
                @EndTurn.canceled += instance.OnEndTurn;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMoveCursor(InputAction.CallbackContext context);
        void OnChoose(InputAction.CallbackContext context);
        void OnEndTurn(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
