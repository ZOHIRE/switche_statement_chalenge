using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switche_statement_chalenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string mysmartphon = "samsung";

            switch (mysmartphon)
            {
                case "nokia":
                    Console.WriteLine("\n\n\n\n\t mysmart phone is nokia");
                    break;
                case "motorola":
                    Console.WriteLine("\n\n\n\n\t mysmart phone is motorola");
                    break;
                case "semense":
                    Console.WriteLine("\n\n\n\n\t mysmart phone is semense");
                    break;
                case "samsung":
                    Console.WriteLine("\n\n\n\n\t mysmart phone is samsung");
                    break;
                default:
                    Console.WriteLine("\n\n\n\n\t no one");
                    break;
            }


            //exercice:ااا He say helloنلاحظ انه في هدا التمرين لم يقم الكمبيوتر بطباعة الجملة      
            //وهذا بسبب ان الحرف الاول صغيير من كلمة hello
            //علي عكسنت تعريف المتغير فانه حرف كبيرHello


            string whatHesay = "Heloo";

            switch (whatHesay)
            {
                case "heloo":
                    Console.WriteLine("\n\n\n\n\t He say hello");
                    break;
                case "bey":
                    Console.WriteLine("\n\n\n\n\t He say bey");
                    break;
                case "wilcom":
                    Console.WriteLine("\n\n\n\n\t He say wilcom");
                    break;
                default:
                    Console.WriteLine("\n\n\n\n\t no one");
                    break;

            }

            /*  Ternary Condition الشرط الثلاثي في لغة السي شارب */

            string myName = "Isslam", myResult1;
            myResult1 = myName.Equals ("Isslam")? "\n\n\n\t yes is my name" : "no is not my name";
            Console.WriteLine(" {0}",myResult1);

            int myVar = 7;
           string myResult2 = (myVar < 9) ? "\n\n\n\t yes my var lesse 9" : "yes my var biger";
            Console.WriteLine(" {0}",myResult2);





    















                    Console.ReadKey();

                    

            }
    }
}


