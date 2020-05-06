using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioBibliotekaProject.Entieti
{
    public class Inbox
    {
        public List<Message> Recived { get; set; }
        public List<Message> Sent { get; set; }

        public Inbox()
        {
            Recived = new List<Message>();
            Sent = new List<Message>();
        }
    }
}
