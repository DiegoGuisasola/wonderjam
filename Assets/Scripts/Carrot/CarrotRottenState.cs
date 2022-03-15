using UnityEngine;

namespace Carrot
{
    public class CarrotRottenState : CarrotBaseState
    {
        private float changeStateCountdown = 2.0f;
        
        public override void EnterState(CarrotStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("CarrotRotten");
        }

        public override void UpdateState(CarrotStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.InitialState);
                changeStateCountdown = 2.0f;
            }
        }
    }
}