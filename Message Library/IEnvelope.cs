using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Library
{
    public interface IEnvelope
    {
        void SetToAddress(string a);
        string GetToAddress();
        void SetFromAddress(string a);
        string GetFromAddress();
        void SetMessage(IMessage message);
        IMessage GetMessage();
    }
}
