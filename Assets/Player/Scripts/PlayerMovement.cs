using UnityEngine;
using Dz;

namespace Dz.Player
{
    public class PlayerMovement : MonoBehaviour
    {

        public static PlayerMovement instance;

        PlayerInputs playerInputs;

        Vector2 movementInput;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);
        }

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            instance.enabled = false;
        }


        private void OnEnable()
        {
            if (playerInputs == null)
            {
                playerInputs = new PlayerInputs();
                playerInputs.PlayerMoviment.Move.performed += i => movementInput = i.ReadValue<Vector2>();
            }
            playerInputs.Enable();
        }


    }
}