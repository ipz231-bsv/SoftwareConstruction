class Program
{
    static void Main(string[] args)
    {
        // Тестування для Завдання 2
        Console.WriteLine("Task 2: Abstract Factory");

        DeviceFactory iproneFactory = new IProneFactory();
        DeviceFactory kiaomiFactory = new KiaomiFactory();
        DeviceFactory balaxyFactory = new BalaxyFactory();

        var iproneLaptop = iproneFactory.CreateLaptop();
        var kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
        var balaxyEbook = balaxyFactory.CreateEBook();

        iproneLaptop.DisplayInfo();
        kiaomiSmartphone.DisplayInfo();
        balaxyEbook.DisplayInfo();

        var iproneNetbook = iproneFactory.CreateNetbook();
        var kiaomiEbook = kiaomiFactory.CreateEBook();
        var balaxyLaptop = balaxyFactory.CreateLaptop();

        iproneNetbook.DisplayInfo();
        kiaomiEbook.DisplayInfo();
        balaxyLaptop.DisplayInfo();

        // Тестування для Завдання 3
        Console.WriteLine("\nTask 3: Singleton");
         
        Authenticator auth1 = Authenticator.Instance;
        auth1.Authenticate("user1", "password123");

        Authenticator auth2 = Authenticator.Instance;
        auth2.Authenticate("user2", "password456");

        Console.WriteLine(Object.ReferenceEquals(auth1, auth2) ? "Both are the same instance" : "Different instances");

        // Тестування для 4 Завдання
        Console.WriteLine("\nTask 4: Virus"); 
        Virus parentVirus = new Virus("ParentVirus", "VirusTypeA", 15.5, 5);

        Virus child1 = new Virus("Child1", "VirusTypeA", 8.2, 2);
        Virus child2 = new Virus("Child2", "VirusTypeA", 7.1, 1);

        parentVirus.AddChild(child1);
        parentVirus.AddChild(child2);

        Console.WriteLine("Original Virus:");
        parentVirus.DisplayInfo();

        Virus clonedVirus = (Virus)parentVirus.Clone();

        Console.WriteLine("\nCloned Virus:");
        clonedVirus.DisplayInfo();

        Console.WriteLine("\nChecking if both viruses are the same instance: ");
        Console.WriteLine(ReferenceEquals(parentVirus, clonedVirus) ? "Same instance" : "Different instances");

        // Тестування для 5 Завдання
        Console.WriteLine("\nTask 5: Builder");

        ICharacterBuilder heroBuilder = new HeroBuilder();
        Director heroDirector = new Director(heroBuilder);
        Character hero = heroDirector.ConstructHero();

        ICharacterBuilder enemyBuilder = new EnemyBuilder();
        Director enemyDirector = new Director(enemyBuilder);
        Character enemy = enemyDirector.ConstructEnemy(); 

        hero.DisplayInfo();
        enemy.DisplayInfo();

        Console.ReadKey();
    }
}
