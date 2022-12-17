namespace ASP.NET_MVC_Core_Lesson_2
{
    internal class Program
    {
        private static char[,] field;


        static void Main(string[] args)
        {
            Console.Write("Укажите размер поля по оси X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите размер поля по оси Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            field = new char[y, x];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 'X';
                }
            }

            for (int i = field.GetLength(1)-1; i >= 0; i--)
            {
                for (int j = field.GetLength(0)-1; j >= 0; j--)
                {
                    field[i, j] = 'О';
                }
            }
        }
    }
}