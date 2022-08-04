using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IteratorToIterate
{
    public class Simpleiteration
    {
        public static void Main(String[] args)
        {

            foreach (object number in SomeNames())
            {
                Console.Write(number.ToString() + " ");

            }

            Console.ReadKey();
        }

        public static System.Collections.IEnumerable SomeNames()
        {
            Console.WriteLine("Player Details:");
            yield return "Rasna\n";
            yield return "Chitti\n";
            yield return "Moni\n";


        }
    }
}