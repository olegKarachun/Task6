using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task6.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteId { get; set; }
        public string PosX { get; set; }
        public string PosY { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Content { get; set; }
        public string Color { get; set; }
    }
}
