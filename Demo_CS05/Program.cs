using Common;
using System.Security.AccessControl;



namespace Demo_CS05
{
    public class Program
    {
        /*static void DoSomeCode()
        {
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            z = x / y;

            int[] Arr = { 1, 2, 3 };

            Arr[99] = 10;
        }*/

        /* static void DoSomeCode()
         {
             try
             {
                 int x, y, z;

                 x = int.Parse(Console.ReadLine());
                 y = int.Parse(Console.ReadLine());

                 z = x / y;

                 int[] Arr = { 1, 2, 3 };

                 Arr[99] = 10;
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 Console.WriteLine("Finally");
                 // Release
                 // Deallocate
                 // Disconnect
                 // Dispose UnManged Resource.
             }
         }*/

        /* static void DoSomeProtectiveCode()
         {
             try
             {
                 int x, y, z;

                 bool flag;
                 do
                 {
                     Console.Write("Enter 1st Number: ");
                     flag = int.TryParse(Console.ReadLine(), out x);
                 } while (flag == false);

                 do
                 {
                     Console.Write("Enter 2nd Number: ");
                     flag = int.TryParse(Console.ReadLine(), out y);
                 } while (flag == false || y == 0);

                 z = x / y;

                 int[] Arr = { 1, 2, 3 };

                 if (99 < Arr?.Length)
                 {
                     Arr[99] = 10;
                 }
                 Console.WriteLine(Arr[99]);
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }

         }*/

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


            //int? Y = /*(int)*/

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

            //int[] Arr = default; //null

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

            //int len = Arr?.Length ?? -1;


            //Console.WriteLine(len);

            #endregion

            #region 05. Exception Handling And Protective Code

            //DoSomeCode();



            //ApplicationException;
            // Exception
            // 1. SystemException
            //   1.1 FormatException
            //   1.2 IndexOfException
            //   1.3 NullReferenceException
            //   1.4 ArithemticException
            //      1.4.1 OverFlowException
            //      1.4.1 DevideException
            // 2. ApplicationException

            //DoSomeProtectiveCode();



            Console.WriteLine("Hello After Exception");

            #endregion

            #region 06 Access Modifiers

            // Class Library

            //Common.TypeA typeA = new TypeA();//Invalid -> typeA is Internal

            Common.TypeB typeB = new TypeB();//valid -> typeA is public


            //typeB.X = 12;//Invalid -> Private
            //typeB.Y = 13;////Invalid -> Internal
            typeB.Z = 14;//valid -> Public


            #endregion


        }
    }
}
