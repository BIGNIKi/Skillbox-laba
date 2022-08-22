// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputConfigs {
	public class @InputMaster : IInputActionCollection, IDisposable {
		public InputActionAsset asset { get; }

		public @InputMaster() {
			asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""db4ea07b-cc64-4006-8be0-e12ff3e52d8a"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""b2fa23df-24e7-4783-9e88-a0a552b63b6f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8cd02ee2-2347-4bba-806e-21d106656204"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rush"",
                    ""type"": ""Button"",
                    ""id"": ""26e99333-d4ff-475b-a90a-9f9c81a31d2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eabcd0ef-2c3f-4853-9344-eb2cdcf03726"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControlScheme"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""acfe78ed-e207-4a8a-80ce-de93c39d9a4c"",
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
                    ""id"": ""0282e1ea-c6e3-43b2-aa5d-55367613165c"",
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
                    ""id"": ""ab9e382a-f7d0-4ed8-a58a-099daa4c5784"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d9a59e55-3c83-4ce8-802b-049dd7d0b640"",
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
                    ""id"": ""bcfc5909-0747-4962-bd82-9b42713680bb"",
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
                    ""id"": ""cb5a3e53-ce9b-4fd6-9e1d-ced6bf22c9e4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControlScheme"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bb93b10-a4f2-49e7-acf2-51b44627cc08"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ControlScheme"",
                    ""action"": ""rush"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""ControlScheme"",
            ""bindingGroup"": ""ControlScheme"",
            ""devices"": []
        }
    ]
}");
			// Player
			m_Player       = asset.FindActionMap("Player", throwIfNotFound: true);
			m_Player_move  = m_Player.FindAction("move", throwIfNotFound: true);
			m_Player_shoot = m_Player.FindAction("shoot", throwIfNotFound: true);
			m_Player_rush  = m_Player.FindAction("rush", throwIfNotFound: true);
		}

		public void Dispose() {
			UnityEngine.Object.Destroy(asset);
		}

		public InputBinding? bindingMask {
			get => asset.bindingMask;
			set => asset.bindingMask = value;
		}

		public ReadOnlyArray<InputDevice>? devices {
			get => asset.devices;
			set => asset.devices = value;
		}

		public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

		public bool Contains(InputAction action) {
			return asset.Contains(action);
		}

		public IEnumerator<InputAction> GetEnumerator() {
			return asset.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}

		public void Enable() {
			asset.Enable();
		}

		public void Disable() {
			asset.Disable();
		}

		// Player
		private readonly InputActionMap m_Player;
		private          IPlayerActions m_PlayerActionsCallbackInterface;
		private readonly InputAction    m_Player_move;
		private readonly InputAction    m_Player_shoot;
		private readonly InputAction    m_Player_rush;

		public struct PlayerActions {
			private @InputMaster m_Wrapper;

			public PlayerActions(@InputMaster wrapper) {
				m_Wrapper = wrapper;
			}

			public InputAction @move  => m_Wrapper.m_Player_move;
			public InputAction @shoot => m_Wrapper.m_Player_shoot;
			public InputAction @rush  => m_Wrapper.m_Player_rush;

			public InputActionMap Get() {
				return m_Wrapper.m_Player;
			}

			public void Enable() {
				Get().Enable();
			}

			public void Disable() {
				Get().Disable();
			}

			public bool enabled => Get().enabled;

			public static implicit operator InputActionMap(PlayerActions set) {
				return set.Get();
			}

			public void SetCallbacks(IPlayerActions instance) {
				if ( m_Wrapper.m_PlayerActionsCallbackInterface != null ) {
					@move.started    -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
					@move.performed  -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
					@move.canceled   -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
					@shoot.started   -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
					@shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
					@shoot.canceled  -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
					@rush.started    -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRush;
					@rush.performed  -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRush;
					@rush.canceled   -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRush;
				}
				m_Wrapper.m_PlayerActionsCallbackInterface = instance;
				if ( instance != null ) {
					@move.started    += instance.OnMove;
					@move.performed  += instance.OnMove;
					@move.canceled   += instance.OnMove;
					@shoot.started   += instance.OnShoot;
					@shoot.performed += instance.OnShoot;
					@shoot.canceled  += instance.OnShoot;
					@rush.started    += instance.OnRush;
					@rush.performed  += instance.OnRush;
					@rush.canceled   += instance.OnRush;
				}
			}
		}

		public  PlayerActions @Player => new PlayerActions(this);
		private int           m_ControlSchemeSchemeIndex = -1;

		public InputControlScheme ControlSchemeScheme {
			get {
				if ( m_ControlSchemeSchemeIndex == -1 ) m_ControlSchemeSchemeIndex = asset.FindControlSchemeIndex("ControlScheme");
				return asset.controlSchemes[m_ControlSchemeSchemeIndex];
			}
		}

		public interface IPlayerActions {
			void OnMove(InputAction.CallbackContext context);
			void OnShoot(InputAction.CallbackContext context);
			void OnRush(InputAction.CallbackContext context);
		}
	}
}