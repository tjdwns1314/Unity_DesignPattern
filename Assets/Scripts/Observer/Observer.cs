using UnityEngine;

namespace Chapter.Observers
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void Notify(Subject subject);
    }
}
