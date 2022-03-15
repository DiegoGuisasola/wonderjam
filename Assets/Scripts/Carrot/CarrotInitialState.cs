using UnityEngine;

namespace Carrot
{
    public class CarrotInitialState : CarrotBaseState
    {
        private float changeStateCountdown = 2.0f;
        
        
        public override void EnterState(CarrotStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("CarrotBase");
        }

        public override void UpdateState(CarrotStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.RottenState);
                changeStateCountdown = 2.0f;
            }
        }
    }
}