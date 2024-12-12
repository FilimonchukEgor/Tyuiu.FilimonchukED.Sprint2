using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilimonchukED.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            
            int dayIndex = (d - 1 + (k - 1)) % 7;

            
            return dayIndex switch
            {
                0 => "Понедельник",
                1 => "Вторник",
                2 => "Среда",
                3 => "Четверг",
                4 => "Пятница",
                5 => "Суббота",
                6 => "Воскресенье",
                _ => "Неверный день"
            };
        }

    }
}
