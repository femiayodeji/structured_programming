namespace Adaptor.Models
{
    public class BirdAdapter : IToyDuck
    {
        private IBird _bird;
        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }
        public void Squeak()
        {
            _bird.MakeSound();
        }
    }
}