using Message_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageService
{
    public class Router : IRouter
    {
        private List<string> addresses;

        public Router()
        {
            addresses = new List<string>(); 
        }
        

   
        public IEnvelope Recieve()
        {
            throw new NotImplementedException();
        }

        public void Route(IEnvelope e)
        {
            if (!addresses.Contains(e.GetFromAddress()))
            {
                addresses.Add(e.GetFromAddress());
            }
            
        }

        public void Send(IEnvelope e)
        {
            throw new NotImplementedException();
        }
    }
}
