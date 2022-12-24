using System;

namespace ObserverDesignPattern.StructuralCode
{
	public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;

            Console.WriteLine("Observer {0}'s is new state {1}", _name, _observerState);
        }

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }

        }
    }
}