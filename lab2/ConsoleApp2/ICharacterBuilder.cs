public interface ICharacterBuilder
{
    ICharacterBuilder SetHeight(string height);
    ICharacterBuilder SetBuild(string build);
    ICharacterBuilder SetHairColor(string hairColor);
    ICharacterBuilder SetEyeColor(string eyeColor);
    ICharacterBuilder SetClothes(string clothes);
    ICharacterBuilder SetInventory(List<string> inventory);
    Character Build();
}
