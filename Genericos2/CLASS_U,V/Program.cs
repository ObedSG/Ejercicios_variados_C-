public class BaseContainer<T, U>
{
    public T Data { get; set; }
    public U Score { get; set; }

    public BaseContainer(T data, U score)
    {
        this.Data = data;
        this.Score = score;
    }
}

public class UserScoreContainer<T> : BaseContainer<T, int>
{
    public UserScoreContainer(T data, int score) : base(data, score)
    {

    }

    public void showDetails()
    {
        Console.WriteLine("DATA: {0}, SCORE: {1}", Data, Score);
    }

}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"Nombre: {Name}, Edad: {Age} ";
}

public class Program
{
    public static void Main()
    {
        User user = new("Obed", 21);
        UserScoreContainer<string> UserContainer = new("HOLA", 300);

        UserContainer.showDetails();
    }
}