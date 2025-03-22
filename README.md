# Принципи програмування в коді

У цьому файлі описано, як мій код дотримується основних принципів програмування.

## 1. DRY (Don't Repeat Yourself)

Принцип **DRY** означає, що в коді не повинно бути дублювання логіки. У моєму коді принцип DRY дотриманий, оскільки я створив окремі класи для обробки бізнес-логіки (Money, Product, Warehouse, Reporting), що дозволяє уникнути дублювання коду.

### Приклад:

- **Файл**: `Money.cs`
- **Рядок коду**: 
  ```csharp
  public void DisplayAmount()
  {
      Console.WriteLine($"Сума: {Whole} гривень, {Cents} копійок");
  }
2. KISS (Keep It Simple, Stupid)
Принцип KISS вимагає, щоб код був якомога простішим та зрозумілішим. У моєму коді я намагався дотримуватись цього принципу, зберігаючи класи простими та надаючи їм лише одну відповідальність.

Приклад:
Файл: Product.cs

Рядок коду:

csharp
Копіювати
Редагувати
public void DisplayProduct()
{
    Console.WriteLine($"Продукт: {Name}, Ціна: {Price.Whole} грн {Price.Cents} коп.");
}
3. SOLID
a) Single Responsibility Principle (SRP)
Кожен клас має лише одну відповідальність.

b) Open/Closed Principle (OCP)
Мій код закритий для модифікацій і відкритий для розширень.

c) Liskov Substitution Principle (LSP)
Класи можуть бути розширені за допомогою наслідування без порушення основної логіки.

d) Interface Segregation Principle (ISP)
Ми не використовуємо великі інтерфейси, а лише інтерфейси, що відповідають за окремі функції.

e) Dependency Inversion Principle (DIP)
Класи не залежатимуть від конкретних реалізацій.

4. YAGNI (You Aren't Gonna Need It)
Принцип YAGNI заохочує не додавати функціональність, яка не потрібна на даний момент.

5. Composition Over Inheritance
Принцип Composition Over Inheritance рекомендує використовувати композицію замість наслідування. У моєму коді я надаю перевагу складанню об'єктів.

Приклад:
Файл: Product.cs

Рядок коду:

csharp
Копіювати
Редагувати
public Money Price { get; set; }
6. Program to Interfaces not Implementations
Принцип Program to Interfaces not Implementations рекомендує програмувати до інтерфейсов, а не до конкретних реалізацій.

7. Fail Fast
Принцип Fail Fast полягає в тому, щоб програма швидко повідомляла про помилки, якщо вони виникають.

Приклад:
Файл: Product.cs

Рядок коду:

csharp
Копіювати
Редагувати
if (discountCents < 0)
{
    throw new ArgumentException("Знижка не може бути від'ємною");
}
markdown
Копіювати
Редагувати

### Додаткові кроки:

1. **Збережіть файл** після того, як вставите вміст.
2. **Закомітьте файл** в Git, щоб він потрапив в репозиторій:
   - Відкрийте **Git Bash** або командний рядок.
   - Виконайте команду:
     ```bash
     git add README.md
     git commit -m "Added README.md with principles explanation"
     git push
     ```

Цей файл містить опис, як ваш код дотримується принципів програмування, таких як **DRY**, **KISS**, **SOLID**, **YAGN
