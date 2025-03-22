public interface IEnemyBuilder : ICharacterBuilder
{
    ICharacterBuilder SetEvilActions(List<string> evilActions);
}
