using System;

namespace CSharpMainMethod
{
    class Program
    {
        /* Main Method Called IntroMethod(), so It is
         * Executed */
        static void IntroMethod ( )
        {
            Console . WriteLine ( "This is IntroMethod!" );
        }

        /* Main Method did not Call HiddenMethod(), so It
         * is Not Executed*/
        static void HiddenMethod ( string [ ] args )
        {
            Console . WriteLine ( "This is HiddenMethod!" );
        }

        /* Program Execution Starts from and Ends in Main Method
         * If Other Methods are Not Called from the Main Method, 
         * those will not be Executed */
        static void Main ( )
        {
            Console . WriteLine ( "This is Main Method!" );
            IntroMethod ( );
        }
    }
}
