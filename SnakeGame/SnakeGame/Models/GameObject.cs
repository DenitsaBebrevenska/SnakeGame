namespace SnakeGame.Models
{
    public abstract class GameObject
    {
        private readonly char BuildingChar;
        public int Length { get; private set; }

        public Point StartingPoint { get; protected set; }
        protected GameObject(char buildingChar, int length, Point startingPoint)
        {
            BuildingChar = buildingChar;
            Length = length;
            StartingPoint = startingPoint;
        }
    }
}
