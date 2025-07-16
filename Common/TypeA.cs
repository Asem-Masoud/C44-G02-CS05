using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    //Access Modifiers: C# Keywords Indicate Accessibility Scope
    // 1. Private --
    // 2. Private Protected
    // 3. Protected
    // 4. Internal --
    // 5. Internal Protected
    // 6. Public --



    //what can write inside namespace
    /*
     *  1. Class
     *  2. Struct
     *  3. Interface
     *  4. Enum
     */

    // Access Modifiers Inside The NameSpace:
    /*
     *  1. Internal : Inside The Same Project
     *  2. Public : Every Where
     */


    // Default Access Modifiers Inside The NameSpace -> Internal


    //what can write inside Class or Struct
    /*
     *  1. Attributes [Filed- Member Variable]
     *  2. Properties [Full Property - Automatic Property - Special Property]
     *  3. Methods - Funcs
     *  4. Event
     */


    // Access Modifiers Inside The Class:
    // 1. Private --
    // 2. Private Protected
    // 3. Protected
    // 4. Internal --
    // 5. Internal Protected
    // 6. Public --

    // Access Modifiers Inside The struct:
    /*
     *  1. Private : Inside The Same Class
     *  2. Internal : Inside The Same Project
     *  3. Public : Every Where
     */


    // Default Access Modifiers Inside The class or struct -> private


    // What can write inside Interface
    /*
     *  1. Signature of Methods [Return Type - Name - Parameter]
     *  2. Signature of Methods 
     *  3. Default Implemented Methods [C# 8.0 .NET Core 3.1]
     */

    // Access Modifiers Inside The Interface:
    // All Access Modifiers Except "Private" 

    // Default Access Modifiers Inside The class or struct -> public




    internal class TypeA
    {
        void Fun01()
        {
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB();

            //typeB.X = 12; // Invalid
            typeB.Y = 12;//valid
            typeB.Z = 13;//valid

        }
    }
}
