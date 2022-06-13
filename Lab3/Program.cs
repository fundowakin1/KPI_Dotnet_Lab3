using Lab3.Entities;
using Lab3.MenuDisplay;

try
{
    var menu = new Menu();
    Console.Write("Enter username: ");
    var username = Console.ReadLine();
    if (string.IsNullOrEmpty(username))
        throw new NullReferenceException("The username is null or empty");

    var cypher = menu.GetCypher();
    var user = new User(cypher) { Username = username };

    Console.Write("\nEnter the password: ");
    var password = Console.ReadLine();

    if (string.IsNullOrEmpty(password))
        throw new NullReferenceException("The password is null or empty");
    if (password.ToCharArray().Any(x => !char.IsLetter(x)))
        throw new InvalidDataException("The password must consist only of letters");

    user.SetPassword(password);
    Console.WriteLine("\nThe password was successfully set");

    Console.WriteLine(user);

    Console.WriteLine("\n\nPress any key to get decrypted password:");
    Console.ReadKey();

    var decrypted = user.GetPassword();

    Console.WriteLine($"Decrypted password: {decrypted}");
}
catch (Exception ex)
{
    if(ex is NullReferenceException or InvalidDataException)
        Console.WriteLine(ex.Message);
}
Console.ReadKey();