using Alb.Entities.Gato;
using Newtonsoft.Json;

namespace Alb.ConsoleApp.Microservice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            var response = ReceivedMessage();

            /* enviar mensaje de regreso */
        }


        private static string ReceivedMessage()
        {
            string message = "";

            var request = JsonConvert.DeserializeObject<Gato>(message);
            
            /* { interacción con BD }*/

            var response = JsonConvert.SerializeObject(request);

            return response;
        }


    }
}
