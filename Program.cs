using System;

namespace POK_CW2_ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var function = new Function(4, 1);
            var fcheck = new FunctionCheccker(function);

            var result =  fcheck.CheckCorrect();
            if(result == true)
            {
                Console.WriteLine(function.ToString() + " Jest poprawna");
            }
            else
            {
                Console.WriteLine(function.ToString() + " Jest niepoprawna");
            }
            


        }
    }
    public class Function
    {
        public Function()
        {

        }

        public Function(float paramA, float paramB)
        {
            this.paramA = paramA;
            this.paramB = paramB;
        }

        public Function(float paramA, float paramB, float paramX)
        {
            this.paramA = paramA;
            this.paramB = paramB;
            this.paramX = paramX;
        }

        public float paramA { get; set; }

        public float paramB { get; set; }

        public float? paramX { get; set; }

        public float? paramY { get =>paramX != null? paramA * paramX + paramB : null; }



       

       
        public override string ToString()
        {
            var str = "";
            if (paramB > 0)
            {
                str = $"f(x) = {paramA}x + {paramB}";
            }
            else if (paramB == 0)
            {
                str = $"f(x) = {paramA}x";
            } else
            {
                str = $"f(x) = {paramA}x - {paramB}";
            }

            return str;

        }


    }
}
