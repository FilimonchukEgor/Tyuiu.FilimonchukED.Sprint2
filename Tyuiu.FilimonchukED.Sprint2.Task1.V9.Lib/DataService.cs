using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilimonchukED.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | (b == c);
            res[1] = (a == c) & (b == d);
            res[2] = (a < d) || (a == d);
            res[3] = (b > d) && (a == c);
            res[4] = !res[0];
            res[5] = (a < c) ^ (b != d);
            return res;
        }
    }
}
