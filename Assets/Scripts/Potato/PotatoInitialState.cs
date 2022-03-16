using UnityEngine;

namespace Potato
{
    public class PotatoInitialState : PotatoBaseState
    {
        private float changeStateCountdown = 3.0f;

        public override void EnterState(PotatoStateManager carrot)
        {
            Animator animator = carrot.GetComponent<Animator>();
            animator.Play("Initial");
        }

        public override void UpdateState(PotatoStateManager carrot)
        {
            if (changeStateCountdown >= 0)
            {
                changeStateCountdown -= Time.deltaTime;
            }
            else
            {
                carrot.SwitchState(carrot.GrowthOneState);
                changeStateCountdown = 3.0f;
            }
        }
    }
}