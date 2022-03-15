namespace Carrot
{
    public abstract class CarrotBaseState
    {
        public abstract void EnterState(CarrotStateManager carrot);
        public abstract void UpdateState(CarrotStateManager carrot);
    
    }
}