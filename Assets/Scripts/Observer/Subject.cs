using UnityEngine;
using System.Collections;
using System;

namespace Chapter.Observers
{
    public abstract class Subject : MonoBehaviour
    {
        private readonly ArrayList _observers = new ArrayList();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Debug.Log("1");
            foreach (Observer observer in _observers)
            {
                observer.Notify(this);
            }
        }
    }
}
