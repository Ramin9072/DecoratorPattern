using LibraryDecorator.Components.Abstracts;

namespace LibraryDecorator.Decorators
{
    public abstract class Decorator : Component
    {
        protected Component _component;
        public void SetComponent(Component component)
        {
            _component = component;
        }
        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }

    }
}
