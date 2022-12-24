using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.StructuralCode
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }

    }

    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState
        {
            get => subjectState;
            // TODO: Check something 
            set => subjectState = value;
        }
    }
}
