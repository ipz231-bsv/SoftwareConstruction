public class EnemyBuilder : IEnemyBuilder
{
    private Character _character;

    public EnemyBuilder()
    {
        _character = new Character("Enemy");
    }

    public ICharacterBuilder SetHeight(string height)
    {
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        _character.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        _character.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
        _character.EyeColor = eyeColor;
        return this;
    }

    public ICharacterBuilder SetClothes(string clothes)
    {
        _character.Clothes = clothes;
        return this;
    }

    public ICharacterBuilder SetInventory(List<string> inventory)
    {
        _character.Inventory = inventory;
        return this;
    }

    public ICharacterBuilder SetEvilActions(List<string> evilActions)
    {
        _character.Actions = evilActions;
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}
