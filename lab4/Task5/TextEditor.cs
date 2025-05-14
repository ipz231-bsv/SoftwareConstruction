public class TextEditor
{
    private TextDocument _document;
    private CareTaker _careTaker;

    public TextEditor(TextDocument document)
    {
        _document = document;
        _careTaker = new CareTaker();
    }

    public void Write(string text)
    {
        _careTaker.Save(new Memento(_document.Text)); // Зберігаємо поточний стан
        _document.Text += text; // Оновлюємо текст
    }

    public void Undo()
    {
        Memento lastState = _careTaker.Undo(); // Відновлюємо попередній стан
        if (lastState != null)
        {
            _document.Text = lastState.State;
            Console.WriteLine("Changes undone!");
        }
    }

    public void ShowDocument()
    {
        _document.ShowText();
    }
}
