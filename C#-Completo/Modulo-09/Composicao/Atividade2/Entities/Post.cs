using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2.Entities
{
    public class Post
    {
        public DateTime moment { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int likes { get; set; }
        public List<Comment> comentarios { set; get; } = new List<Comment> ();

        public Post(DateTime Moment, string Title, string Content, int Likes)
        {
            moment = Moment;
            title = Title;
            content = Content;
            likes = Likes;
        }

        public void addCommet(Comment Text)
        {
            comentarios.Add(Text);
        }

        public List<Comment> showComment()
        {
            return comentarios;
        }

        public override string ToString()
        {
            return $"{title}\n{likes} - {moment}\n{content}";
        }

    }
}