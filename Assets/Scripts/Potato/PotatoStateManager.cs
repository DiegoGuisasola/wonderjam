using UnityEngine;

namespace Potato
{
    public class PotatoStateManager : MonoBehaviour
    {
        PotatoBaseState _currentState;
        public PotatoInitialState InitialState = new PotatoInitialState();
        public PotatoRottenState RottenState = new PotatoRottenState();
        public PotatoGrowthOneState GrowthOneState = new PotatoGrowthOneState();
        public PotatoGrowthTwoState GrowthTwoState = new PotatoGrowthTwoState();
        public PotatoCompleteState CompleteState = new PotatoCompleteState();

        // Start is called before the first frame update
        void Start()
        {
            _currentState = InitialState;
            _currentState.EnterState(this);
        }

        // Update is called once per frame
        void Update()
        {
            _currentState.UpdateState(this);
        }

        public void SwitchState(PotatoBaseState newState)
        {
            _currentState = newState;
            newState.EnterState(this); // can it be _currentState.EnterState(this); ??
        }
    }
}
