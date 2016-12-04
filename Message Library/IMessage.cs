using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Library
{
    public interface IMessage
    {
        string GetContent();
        void SetContent(string c);
    }
}
