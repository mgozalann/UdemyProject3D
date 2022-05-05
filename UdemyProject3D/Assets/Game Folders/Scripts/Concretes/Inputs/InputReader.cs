using UnityEngine.InputSystem;
using UdemyProject3D.Abstracts.Inputs;

namespace UdemyProject3D.Inputs
{
    public class InputReader : IInputReader
    {
        PlayerInput _playerInput;

        public float Horizontal { get; private set; }
        public bool IsJump { get; private set; }
        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;

            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
            _playerInput.currentActionMap.actions[1].started += OnRigidbodyJump;
            _playerInput.currentActionMap.actions[1].canceled += OnRigidbodyJump;

        }

        private void OnRigidbodyJump(InputAction.CallbackContext context)
        {
            IsJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }


    }
}
