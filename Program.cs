using TelegramApp.Models;
using TelegramApp.Repository;

var list1 = new List<Post>(){new ImportantPost(1,"Calisma",6,10),
            new ImportantPost(2,"Calisma",7,11),
            new ImportantPost(3,"Calisma",8,12),
            new ImportantPost(4,"Calisma",9,13),
            new ImportantPost(5,"HighTher",5,2)};
PostsRepository posts = new PostsRepository(list1);
posts.AddOnePost(new ImportantPost(7,"FAkir",3,4));
posts.SortBySize();

/* foreach (var item in posts)
{
    System.Console.WriteLine(item.ToString());
} */
// posts.Display();