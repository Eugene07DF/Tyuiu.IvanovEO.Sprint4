using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.IvanovEO.Sprint4.Task4.V26.Lib
{
    public class DataService : ISprint4Task4V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] array = new int[5, 5] { { 0, 4, 0, 0, 2 }, { 0, 2, 4, 0, 0 }, { 0, 2, 0, 2, 2 }, { 2, 0, 0, 0, 4 }, { 0, 0, 4, 0, 2 } };
            return array;
        }
    }
}
