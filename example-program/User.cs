namespace ObserverPattern
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
        void Subscribe(ISubject subject);
        void Unsubscribe(ISubject subject);
    }
    class User : IObserver
    {
        public string Name;
        public string Notification = "belum ada notification";
        public User(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject)
        {
            Youtube channel = (Youtube)subject;
            if (channel.GetType() == typeof(Youtube))
            {
                this.Notification = $"{channel.Name} baru saja mengupload video baru";
            }
        }

        public void Subscribe(ISubject subject)
        {
            subject.Attach(this);
        }

        public void Unsubscribe(ISubject subject)
        {
            subject.Detach(this);
        }

        public string GetNotification()
        {
            return Notification;
        }

    }
}
