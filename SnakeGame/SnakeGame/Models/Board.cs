namespace SnakeGame.Models
{
    public class Board : GameObject
    {
        private const char BuildingCharBoard = '\u2588';
        private const int width = 20;
        private const int height = 20;

        public Board()
            : base(BuildingCharBoard, width, new Point(0, 0))
        {
        }
        public override void Draw()
        {
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(StartingPoint.X, StartingPoint.Y);
                Console.Write(BuildingCharBoard);
                StartingPoint.Y++;
            }
        }


    }
}
