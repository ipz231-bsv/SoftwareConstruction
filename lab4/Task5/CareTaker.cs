public class CareTaker
{
    private Stack<Memento> _mementoHistory = new Stack<Memento>();

    public void Save(Memento memento)
    {
        _mementoHistory.Push(memento);
    }

    public Memento Undo()
    {
        if (_mementoHistory.Count > 0)
        {
            return _mementoHistory.Pop();
        }
        else
        {
            Console.WriteLine("No history to undo.");
            return null;
        }
    }

    public int HistoryCount()
    {
        return _mementoHistory.Count;
    }
}
