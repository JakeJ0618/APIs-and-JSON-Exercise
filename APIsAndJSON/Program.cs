using Newtonsoft.Json.Linq;
using APIsAndJSON;
namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            do
            {
                Quotes.KanyeQuote();
                Quotes.RonQuote();

                Console.WriteLine("Continue? Y or N?");
                var response = Console.ReadLine().ToLower();

                cont = (response == "n") ? false : true;
            }while (cont);


            
        }
    } 
}
