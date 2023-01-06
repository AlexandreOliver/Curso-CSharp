using Atividade2.Entities;


DateTime data = DateTime.Parse("21/06/2018 13:05:44");
Comment comentario1 = new Comment("Have a nice trip");
Comment comentario2 = new Comment("How that's awesome!");

DateTime data2 = DateTime.Parse("28/07/2018 23:14:19");
Comment comentario3 = new Comment("Good night");
Comment comentario4 = new Comment("May the Force be with you");


Post pub = new Post(
    data, 
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12
);
pub.addCommet(comentario1);
pub.addCommet(comentario2);

Post pub2 = new Post(
    data2,
    "Good night guys",
    "See you tomorrow",
    5
);
pub2.addCommet(comentario3);
pub2.addCommet(comentario4);


Console.WriteLine(pub.ToString());
Console.WriteLine("Coments:");

List<Comment> comentarios = pub.showComment();
for (int i = 0; i < comentarios.Count; i++)
{
    Console.WriteLine(comentarios[i].text);
}

Console.WriteLine("\n");

Console.WriteLine(pub2.ToString());
Console.WriteLine("Coments:");

comentarios = pub2.showComment();
for (int i = 0; i < comentarios.Count; i++)
{
    Console.WriteLine(comentarios[i].text);
}

