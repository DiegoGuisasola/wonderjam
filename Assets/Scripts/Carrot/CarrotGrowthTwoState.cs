using UnityEngine;

namespace Carrot
{
    public class CarrotGrowthTwoState : CarrotBaseState
    {
        private float changeStateCountdown = 1.0f;

        public override void EnterState(CarrotStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("CarrotGrowthTwo");
        }

        public override void UpdateState(CarrotStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.CompleteState);
                changeStateCountdown = 1.0f;
            }
        }
    }
}