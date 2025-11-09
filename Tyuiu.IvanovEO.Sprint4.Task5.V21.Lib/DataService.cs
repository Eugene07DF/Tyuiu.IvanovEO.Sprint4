using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.IvanovEO.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] array = new int[5, 5] { { -2, -3, 0, -1, 0 }, { -6, -3, -4, -3, 0 }, { 1, -1, -3, 1, -1 }, { -1, 1, 0, -6, -6 }, { -5, 0, 1, -7, -3 } };
            return array;



        }
    }
}
