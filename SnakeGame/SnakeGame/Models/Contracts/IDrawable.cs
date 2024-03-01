namespace SnakeGame.Models.Contracts
{
    public interface IDrawable
    {
        char BuildingSymbol { get; }
        void Draw();
    }
}
