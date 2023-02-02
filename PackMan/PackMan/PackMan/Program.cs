namespace PackMan
{
    public class PackMan
    {
        public int x;
        public int y;

        public PackMan()
        {
            this.x = 0;
            this.y = 0;
        }

        public void GoUp()
        {
            if (this.y > 0)
            {
                this.y -= 1;
            }
        }

        public void GoDown()
        {
            if (this.y < 9)
            {
                this.y += 1;
            }
        }

        public void GoLeft()
        {
            if (this.x > 0)
            {
                this.x -= 1;
            }
        }

        public void GoRight()
        {
            if (this.x < 9)
            {
                this.x += 1;
            }
        }
    }
    public class Program
    {      
        public static void Main(string[] args)
        {
            PackMan packMan = new PackMan();
            string[,] board = new string[10, 10];

            static void Bootstrap(string[,] board)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        board[i, j] = "_";
                    }
                }
            }

            static void DisplayBoard(string[,] board)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write($"{board[i, j]} ");
                    }
                    Console.WriteLine("");
                }
            }

            string key;

            do
            {
                Bootstrap(board);
                board[packMan.y, packMan.x] = "C";
                Console.Clear();
                DisplayBoard(board);
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                key = keyInfo.Key.ToString();

                switch (key)
                {
                    case "DownArrow":
                        packMan.GoDown();
                        break;
                    case "UpArrow":
                        packMan.GoUp();
                        break;
                    case "LeftArrow":
                        packMan.GoLeft();
                        break;
                    case "RightArrow":
                        packMan.GoRight();
                        break;
                }

            } while(key != "Escape");
        }
    }
}