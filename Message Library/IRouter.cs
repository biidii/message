using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Library
{
    public interface IRouter
    {
        void Route(IEnvelope e);
        void Send(IEnvelope e);
        IEnvelope Recieve();

    }
}
