using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.Calc
{
    public class Calc
    {
        private List<string> listHistory;
        private string date;
        private void NewMethod(int result, string? date = null)
        {
            listHistory.Add($"Resultado: {result} Data: {date}");
        }
        public Calc(string date)
        {
            listHistory = new List<string>();
            this.date = date;
        }
        public int Sum(int val1, int val2)
        {
            int result = val1 + val2;
            NewMethod(result);
            return result;
        }

        public int Sub(int val1, int val2)
        {
            int result = val1 - val2;
            NewMethod(result);
            return result;
        }
        public int Mult(int val1, int val2)
        {
            int result = val1 * val2;
            NewMethod(result);
            return result;
        }
        public int Div(int val1, int val2)
        {
            int result = val1 / val2;
            NewMethod(result);
            return result;
        }
        public List<string> History()
        {
            listHistory.RemoveRange(3, listHistory.Count - 3);
            return listHistory;
        }

    }
}