using UnityEngine;

namespace Potato
{
    public class PotatoRottenState : PotatoBaseState
    {
        private float changeStateCountdown = 4.0f;
        
        public override void EnterState(PotatoStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("Rotten");
        }

        public override void UpdateState(PotatoStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.InitialState);
                changeStateCountdown = 4.0f;
            }
        }
    }
}