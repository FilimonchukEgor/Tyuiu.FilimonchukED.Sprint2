using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilimonchukED.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            
            int dayIndex = (k - 1) % 7;

            
            switch (dayIndex)
            {
                case 0:
                    return "Понедельник";
                case 1:
                    return "Вторник";
                case 2:
                    return "Среда";
                case 3:
                    return "Четверг";
                case 4:
                    return "Пятница";
                case 5:
                    return "Суббота";
                case 6:
                    return "Воскресенье";
                default:
                    
                    return "Неверный день";
            }
        }

    }
}
