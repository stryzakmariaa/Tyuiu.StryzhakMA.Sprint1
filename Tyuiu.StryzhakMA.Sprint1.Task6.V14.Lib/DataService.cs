using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StryzhakMA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            foreach (char c in value)
            {
                
                if (!(char.IsLower(c) && ((c >= 'а' && c <= 'я') || c == 'ё')))
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
