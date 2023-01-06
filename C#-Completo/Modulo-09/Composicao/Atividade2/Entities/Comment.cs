using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2.Entities
{
    public class Comment
    {
        public string text { set; get; }

        public Comment(string Text)
        {
            text = Text;
        }
    }
}