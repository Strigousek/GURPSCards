using System;
using System.Collections.Generic;
using System.Text;

namespace GurpsCard.Models
{
    public abstract class Card
    {       
        public string Name { get; set; }
        public string Description { get; set; }
        public string ActiveDefense { get; set; }
        public string Movement { get; set; }
        public string Page { get; set; }
    }
}
