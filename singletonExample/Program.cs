using System;
#nullable disable
namespace SingletonExample
{
  
  public sealed class User
  {
    private static int counter =0;
    private static User user=null;
    public static User getinstance
    {
      get
      {
        if(user==null)
           user=new User();
        return user;
      }
        
      }
    public void print(string message)
    {
       Console.WriteLine(message);
    }
    private User()
    {
      counter++;
      Console.WriteLine("the counter is : {0}",counter);
    }
   /* public class Mainprogram:User
    {

    }*/
  }
  public class Program
  {
    static void Main()
    {
    User user=User.getinstance;
    user.print("first message");
    User user1=User.getinstance;
    user1.print("second message");
   /* User.Mainprogram  usermain=new User.Mainprogram ();
    usermain.print("derived class");*/
    }
  }
}