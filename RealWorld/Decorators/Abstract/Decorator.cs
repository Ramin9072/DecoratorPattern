using RealWorld.Components.Abstraction;

namespace RealWorld.Decorators.Abstract
{
    internal class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
