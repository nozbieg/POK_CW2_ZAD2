using System;
using System.Collections.Generic;

namespace POK_CW2_ZAD2
{
    public class FunctionCheccker
    {
        private const int cst = 2;
        public FunctionCheccker(Function f1)
        {

            F1 = f1;
            Fconst = new Function(F1.paramA, F1.paramB, cst);
        }

        public Function F1 { get; set; }
        public Function Fconst { get; set; }

        public bool CheckCorrect()
        {

            var randomTab = new List<int>();
            randomTab = FillTable(10);
            bool result = false;
            foreach (var i in randomTab)
            {
                result = CheckRequairments(i);
                if (result == false)
                {
                    return false;
                }
            }
            return result;
        }

        private bool CheckRequairments(int i)
        {
            F1.paramX = i;
            var test = (F1.paramY - Fconst.paramY) / (i - Fconst.paramX);
            if (test == F1.paramA)
            {
                return true;
            }
            else return false;
        }
        private List<int> FillTable(int v)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(r.Next(v));
            }
            return list;
        }

    }
}
