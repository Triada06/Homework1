using Homework;


User user = new User();

Console.WriteLine("Enter username: ");
user.UserName = Console.ReadLine();

Console.WriteLine("Enter password: ");
user.Password = Console.ReadLine();

Console.WriteLine(user.UserName + user.Password);


Console.WriteLine(user.HasUpper("Salam"));
