using System.Collections;

using TelegramApp.Models;

namespace TelegramApp.Repository;
public class PostsRepository:IEnumerable
{
    private List<Post> Posts { get; set; }
    public PostsRepository()
    {
        Posts = new List<Post>();
    }
    public List<Post>? GetAllPosts(){
        return Posts;
    }

    public PostsRepository(List<Post> posts):this()
    {
        foreach (var item in posts)
        {
            AddOnePost(item);
        }
    }
    public void AddOnePost(Post post){
        Posts.Add(post);
    }
    public List<Post> SortBySize(){
        Display();
        System.Console.WriteLine(new String('=',50));
        Posts.Sort();
        System.Console.WriteLine(new String('=',50));
        Display();
        return Posts;
    }
    /* public Post GetOnePost(int id){
       try
       {
       var post =  Posts.SingleOrDefault(pos=>pos.Id.Equals(id));
        if (post == null){
            throw new PostNotFoundException(id);
        }
        else
        {
            return post;
        }
        
       }
       catch (System.Exception ex)
       {
        
        throw new Exception(ex.Message);
       }
    } */
    public Post GetOnePost(int id){
        return Posts.Single(pos=>pos.Id.Equals(id));
    }
    public void Display(){
        foreach (var item in Posts)
        {
            System.Console.WriteLine(item.ToString());
        }
    }

    public IEnumerator GetEnumerator()
    {
        return Posts.GetEnumerator();
    }

}