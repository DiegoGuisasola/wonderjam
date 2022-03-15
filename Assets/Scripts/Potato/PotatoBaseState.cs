namespace Potato
{
    public abstract class PotatoBaseState
    {
        public abstract void EnterState(PotatoStateManager carrot);
        public abstract void UpdateState(PotatoStateManager carrot);
    
    }
}