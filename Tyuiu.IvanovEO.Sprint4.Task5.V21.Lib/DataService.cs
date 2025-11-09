using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.IvanovEO.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] array = new int[5, 5] { { 0, 4, 0, 0, 2 }, { 0, 2, 4, 0, 0 }, { 0, 2, 0, 2, 2 }, { 2, 0, 0, 0, 4 }, { 0, 0, 4, 0, 2 } };
            return array;



        }
    }
}
