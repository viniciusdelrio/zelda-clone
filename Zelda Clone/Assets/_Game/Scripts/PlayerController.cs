using UnityEngine;
using UnityEngine.InputSystem;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float speed = 10;

        private Rigidbody2D rb;
        private PlayerInputActions inputActions;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();

            inputActions = new PlayerInputActions();
            inputActions.PlayerControls.Enable();

            inputActions.PlayerControls.Attack.performed += OnAttackInput;
        }

        private void OnAttackInput(InputAction.CallbackContext obj) => 
            Debug.Log("Attack pressed!");

        void Update()
        {
            var moveInput = inputActions.PlayerControls.Movement.ReadValue<Vector2>();
            rb.velocity = moveInput * speed * Time.deltaTime;
        }
    }
}