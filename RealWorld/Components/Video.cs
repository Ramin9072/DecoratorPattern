using RealWorld.Components.Abstraction;

namespace RealWorld.Components
{
    public class Video : LibraryItem
    {
        private string _movieDirector; 
        private string _movieName;

        public Video(string movieDirector, string movieName , int numCopies)
        {
            _movieDirector = movieDirector;
            _movieName = movieName;
            NumCopies= numCopies;
        }

        
        public override void Display()
        {
            Console.WriteLine(" ====== Video ====== ");
            Console.WriteLine(" Director: {0}", _movieDirector);
            Console.WriteLine(" Title: {0}", _movieName);
            Console.WriteLine(" Number of copies: {0}", NumCopies);
        }
    }
}
