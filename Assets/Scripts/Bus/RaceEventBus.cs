using UnityEngine.Events;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;

namespace Chapter.EventBus
{
    public enum RaceEventType
    {
        COUNTDOWN, START, RESTART, PAUSE, STOP, FINISH, QUIT
    }
}

namespace Chapter.EventBus
{
    public class RaceEventBus
    {
        private static readonly IDictionary<RaceEventType, UnityEvent>
            Events = new Dictionary<RaceEventType, UnityEvent>();

        public static void Subscribe(RaceEventType eventType, UnityAction listener)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(eventType, out thisEvent))
            {
                thisEvent.AddListener(listener);
            }
            else
            {
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
            }
        }
        public static void Unsubscribe(RaceEventType type, UnityAction listener)
        {
            UnityEvent thisEvent;

            if (Events.TryGetValue(type, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }

        public static void Publish(RaceEventType type)
        {
            UnityEvent thisEvent;
            if (Events.TryGetValue(type, out thisEvent))
            {
                thisEvent.Invoke();
            }
        }
    }
}