using Leopotam.EcsLite;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer
{
    public class PlayerMoveSystem : IEcsRunSystem
    {
        
        public void Run(EcsSystems ecsSystems)
        {
            var filter = ecsSystems.GetWorld().Filter<PlayerComponent>().Inc<PlayerInputComponent>().End();
            var playerPool = ecsSystems.GetWorld().GetPool<PlayerComponent>();
            var playerInputPool = ecsSystems.GetWorld().GetPool<PlayerInputComponent>();
            

            foreach (var entity in filter)
            {
                ref var playerComponent = ref playerPool.Get(entity);
                ref var playerInputComponent = ref playerInputPool.Get(entity);

                float h = Input.GetAxis("Horizontal");
                playerComponent.playerAnimator.SetFloat("speed", h);
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    Debug.Log("Ok");
                    Quaternion target = Quaternion.Euler (0, 8, 0);
                    playerComponent.playerTransform.localRotation = Quaternion.Slerp (playerComponent.playerTransform.localRotation, target, Time.deltaTime * playerComponent.playerSpeed);
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    Debug.Log("Ok");
                   Quaternion target = Quaternion.Euler (0, 188, 0);
                    playerComponent.playerTransform.localRotation = Quaternion.Slerp (playerComponent.playerTransform.localRotation, target, Time.deltaTime * playerComponent.playerSpeed);
                }
                playerComponent.playerRB.AddForce(playerInputComponent.moveInput * playerComponent.playerSpeed, ForceMode.Acceleration);
            } 
        }

    }
}