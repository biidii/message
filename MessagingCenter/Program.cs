using Message_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageContent = "Hello";
            IMessage message = null;
            message.SetContent(messageContent);
            IEnvelope envelope = null;
            envelope.SetMessage(message);
            envelope.SetToAddress("center2");
            envelope.SetFromAddress("center1");
            IBus bus = null;
            bus.Send(envelope);
        }
    }
}
