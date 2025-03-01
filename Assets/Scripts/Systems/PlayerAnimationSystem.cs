/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationSystem : IEcsRunSystem
{
    public void Run()
    {
        foreach (var i in filter)
        {
            ref var player = ref filter.Get1(i);
            ref var input = ref filter.Get2(i);
            
            float vertical = Vector3.Dot(input.moveInput.normalized, player.playerTransform.forward);
            float horizontal = Vector3.Dot(input.moveInput.normalized, player.playerTransform.right);
            player.playerAnimator.SetFloat("Horizontal", horizontal, 0.1f, Time.deltaTime);
            player.playerAnimator.SetFloat("Vertical", vertical, 0.1f, Time.deltaTime);
        }
    }
}
*/