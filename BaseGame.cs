namespace Slutprojekt
{
    public abstract class BaseGame
    {
        protected string _name;

        public string Name
        {
            get => _name;
        }

        public abstract void Play();

        public abstract void Stop();
    }
}