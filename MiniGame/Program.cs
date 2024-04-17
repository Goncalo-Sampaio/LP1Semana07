namespace MiniGame
{
    public class Program
    {
        private static void Main()
        {
            Character[] characters = new Character[2];
            characters[0] = new Player("John Snow");
            characters[1] = new Enemy("Gregor Clegan");

            foreach(Character c in characters)
            {
                c.Fight();
            }
        }
    }
}
