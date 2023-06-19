namespace ObserverPattern
{
    public interface ISubject
    {
        // Attach an observer to the subject.
        void Attach(IObserver observer);

        // Detach an observer from the subject.
        void Detach(IObserver observer);

        // Notify all observers about an event.
        void Notify();
    }
    class Youtube : ISubject
    {
        public string Name;
        public List<string> videos = new List<string>() { "video1" };
        private List<IObserver> _subscribers = new List<IObserver>();

        public Youtube(string name)
        {
            Name = name;
        }
        public void Attach(IObserver observer)
        {
            bool isExist = _subscribers.Contains(observer);
            if (isExist)
            {
                Console.WriteLine($"subcriber telah terdaftar");
            }
            else
            {
                _subscribers.Add(observer);
            }

        }

        public void Detach(IObserver observer)
        {
            bool isExist = _subscribers.Contains(observer);

            if (isExist)
            {
                _subscribers.Remove(observer);
            }
            else
            {
                Console.WriteLine($"subcriber {((User)observer).Name} belum terdaftar");
            }
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update((Youtube)this);
            }
        }

        public void AddNewVideo(string title)
        {
            videos.Add(title);
            Notify();
        }
    }
}
