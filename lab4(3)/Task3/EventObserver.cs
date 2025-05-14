public class EventObserver
{
    private Dictionary<string, List<Action>> _eventListeners;

    public EventObserver()
    {
        _eventListeners = new Dictionary<string, List<Action>>();
    }

    public void AddEventListener(string eventType, Action listener)
    {
        if (!_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType] = new List<Action>();
        }
        _eventListeners[eventType].Add(listener);
    }

    public void TriggerEvent(string eventType)
    {
        if (_eventListeners.ContainsKey(eventType))
        {
            foreach (var listener in _eventListeners[eventType])
            {
                listener();
            }
        }
    }
}
