// track


// test 

string fileName = "pass.txt";

string password;

if (File.Exists(fileName))
{
    password = File.ReadAllText(fileName);
}
else
{
    File.Create(fileName).Close();
    password = Registration();
}

Console.WriteLine("Введите пароль");

if(Console.ReadLine () == password)
{
    Console.WriteLine("Доступ  разрешен");
}
else
{
    Console.WriteLine("Доступ не разрешен");
}


string Registration()
{
    Console.WriteLine("регистрация в  системе");
    Console.WriteLine("введите пароль");
    string pas = Console.ReadLine();
    File.WriteAllText(fileName, pas);
    return pas;
}