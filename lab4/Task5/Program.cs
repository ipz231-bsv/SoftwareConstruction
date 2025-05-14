class Program
{
    static void Main(string[] args)
    {
        // Створюємо текстовий документ
        TextDocument document = new TextDocument("Hello");

        // Створюємо текстовий редактор
        TextEditor editor = new TextEditor(document);

        // Пишемо в документ
        editor.Write(" world!");
        editor.ShowDocument(); // Виведе: Hello world!

        // Скасовуємо зміни
        editor.Undo();
        editor.ShowDocument(); // Виведе: Hello

        // Пишемо ще
        editor.Write(" again.");
        editor.ShowDocument(); // Виведе: Hello again.

        // Скасовуємо останні зміни
        editor.Undo();
        editor.ShowDocument(); // Виведе: Hello
    }
}
