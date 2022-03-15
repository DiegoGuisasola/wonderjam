using UnityEngine;

namespace Potato
{
    public class CarrotGrowthOneState : CarrotBaseState
    {
        private float changeStateCountdown = 1.0f;

        public override void EnterState(CarrotStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("GrowthOne");
        }

        public override void UpdateState(CarrotStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.GrowthTwoState);
                changeStateCountdown = 1.0f;
            }
        }
    }
}