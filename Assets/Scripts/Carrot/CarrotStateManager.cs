using UnityEngine;

namespace Carrot
{
    public class CarrotStateManager : MonoBehaviour
    {
        CarrotBaseState _currentState;
        public CarrotInitialState InitialState = new CarrotInitialState();
        public CarrotRottenState RottenState = new CarrotRottenState();
        public CarrotGrowthOneState GrowthOneState = new CarrotGrowthOneState();
        public CarrotGrowthTwoState GrowthTwoState = new CarrotGrowthTwoState();
        public CarrotCompleteState CompleteState = new CarrotCompleteState();

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

        public void SwitchState(CarrotBaseState newState)
        {
            _currentState = newState;
            newState.EnterState(this); // can it be _currentState.EnterState(this); ??
        }
    }
}
