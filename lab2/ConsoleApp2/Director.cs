public class Director
{
    private ICharacterBuilder _builder;

    public Director(ICharacterBuilder builder)
    {
        _builder = builder;
    }

    public Character ConstructHero()
    {
        return _builder.SetHeight("180 cm")
                       .SetBuild("Athletic")
                       .SetHairColor("Black")
                       .SetEyeColor("Brown")
                       .SetClothes("Armor")
                       .SetInventory(new List<string> { "Sword", "Shield", "Health Potion" })
                       .Build();
    }

    public Character ConstructEnemy()
    {
        if (_builder is IEnemyBuilder enemyBuilder)
        {
            return enemyBuilder.SetHeight("200 cm")
                       .SetBuild("Muscular")
                       .SetHairColor("Red")
                       .SetEyeColor("Yellow")
                       .SetClothes("Dark Robes")
                       .SetInventory(new List<string> { "Dark Magic", "Poison" })
                       .Build();
        }

        return null;
    }
}
