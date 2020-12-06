using System;
using System.Collections.Generic;
using System.Text;

namespace PubsLib.Models
{
    public class AddLibroModel
    {
        public LibroModel DataModel { get; set; }
        public List<string> Types { get; set; }
        public List<EditorModel> Editors { get; set; }
    }
}