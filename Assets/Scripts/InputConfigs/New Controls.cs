// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputConfigs
{
    public class @UserInputControl : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @UserInputControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5cd42c25-c2ff-46ef-85f5-26b887025eff"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""6deb9944-f7ba-4af2-a499-4f7d05ddfd7a"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d18f515a-51c4-4dbf-9039-1dc9eae2e40c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rush"",
                    ""type"": ""Button"",
                    ""id"": ""beca509c-d4eb-4241-ae3f-ee44efb9cc40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0384447-e88f-47e1-95c6-efcedae80d5a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""068b2089-3f78-4dfc-8f41-ee6549b50d62"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2f5bab0b-2188-4d47-99f5-062c139b7f1b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7d3a84d3-097f-49d4-924e-b89168a8cda6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87ce4e4a-e2a2-4bc4-a111-68273db8bdf4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8929b036-1569-4bd9-a243-efaa4f060936"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""74da77b5-4fe1-4bd1-a92b-3df139766510"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0eb19ef7-a746-4ea3-ae52-223f63e14220"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rush"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_move = m_Player.FindAction("move", throwIfNotFound: true);
            m_Player_shoot = m_Player.FindAction("shoot", throwIfNotFound: true);
            m_Player_rush = m_Player.FindAction("rush", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_move;
        private readonly InputAction m_Player_shoot;
        private readonly InputAction m_Player_rush;
        public struct PlayerActions
        {
            private @UserInputControl m_Wrapper;
            public PlayerActions(@UserInputControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @move => m_Wrapper.m_Player_move;
            public InputAction @shoot => m_Wrapper.m_Player_shoot;
            public InputAction @rush => m_Wrapper.m_Player_rush;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @rush.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRush;
                    @rush.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRush;
                    @rush.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRush;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @move.started += instance.OnMove;
                    @move.performed += instance.OnMove;
                    @move.canceled += instance.OnMove;
                    @shoot.started += instance.OnShoot;
                    @shoot.performed += instance.OnShoot;
                    @shoot.canceled += instance.OnShoot;
                    @rush.started += instance.OnRush;
                    @rush.performed += instance.OnRush;
                    @rush.canceled += instance.OnRush;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnRush(InputAction.CallbackContext context);
        }
    }
}
