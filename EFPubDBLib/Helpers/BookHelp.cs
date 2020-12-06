using EFPubDBLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPubDBLib.Helpers
{
    public class BookHelp
    {
        public Titles Model { get; set; }
        public List<Publishers> Pubs { get; set; }
        public IEnumerable<string> Types { get; set; }
    }
}
