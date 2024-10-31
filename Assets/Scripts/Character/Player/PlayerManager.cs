using Dz;
using UnityEngine;

namespace Dz.Player
{
    public class PlayerManager : CharacterManager
    {

        PlayerLocomotionManager playerLocomotionManager;

        protected override void Awake()
        {
            base.Awake();

            playerLocomotionManager = GetComponent<PlayerLocomotionManager>();
        }

        protected override void Update()
        {
            base.Update();

            playerLocomotionManager.HandleAllMovement();
        }

    }
}