using Message_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IBus bus = null;
            var recievemessage = bus.Recieve();
            IRouter router = new Router();
            router.Route(recievemessage);

            


        }
    }
}
