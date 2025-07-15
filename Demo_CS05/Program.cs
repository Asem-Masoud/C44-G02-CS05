namespace Demo_CS05
{
    public class Program
    {
        static void Main()
        {

            // Nullable Types
            //Value Type
            //Reference Type

            #region 02 Nullable ValueTypes

            //int X = 6;

            //Nullable Value Type : Value Type Allow Null as Valid value

            //X = null; //Invalid
            // Nullable<int> : Allow Int Value or null as valid value
            //int? Age = 20;

            //Age = null;

            // Nullable<double> : Allow double Value or null as valid value
            //double? Salary = 4000.5;

            //Salary = null;


            //int X = 5;

            //// Y : Nullable<int>
            //// Y : Allow int or null


            //int? Y = /*(int)*/ X;

            //// Implicit Casting
            //// Safe Casting

            //Console.WriteLine(Y);

            //int? X = 5;

            //X = null;
            // Y : int
            // Y : Allow int only

            //int Y;
            // Explicit Casting           
            // May Throw Exception


            //Defensive Code
            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //Console.WriteLine(Y);

            //================================

            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //Console.WriteLine(Y);

            //================================
            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;
            //Console.WriteLine(Y);
            //================================

            //Y = X.HasValue ? X.Value : 0;

            //================================
            //Y = X is not null ? X.Value : 0;
            //================================

            //Null Coalescing Operator ??

            //Y = X ?? 0;  // Syntax Sugar : X is not null? X.Value : 0



            //Console.WriteLine(Y);






            #endregion

            #region 03 Nullable ReferenceTypes
            //string message = "jkgjg";


            //string message02 = null;// required


            //string? message03 = null;// nullable

            //Console.WriteLine(message);
            //Console.WriteLine(message02.Length);//System.NullReferenceException
            //Console.WriteLine(message03);


            #endregion

            #region 04 Null-Propagation Operator

            //double X = default; //0
            //char c = default;

            //Console.WriteLine(X);
            //Console.WriteLine(c);

            int[] Arr = default; //null

            //int[] Arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; (Arr is not null && i < Arr.Length); i++)
            //    Console.WriteLine(Arr[i]);// System.NullReferenceException //because arr == null

            //best practice
            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //        Console.WriteLine(Arr[i]);

            //}

            //Null-Propagation Operator -> Arr?
            //for (int i = 0; i < Arr?.Length; i++)
            //    Console.WriteLine(Arr[i]);


            // E?.Departement.DeptName

            //int len = Arr is not null ? Arr.Length : 0;

            //int? len = Arr?.Length;

            int len = Arr?.Length ?? -1;


            Console.WriteLine(len);







            #endregion

            #region 05. Exception Handling And Protective Code



            #endregion

        }
    }
}
