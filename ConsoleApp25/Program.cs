// track

using ConsoleApp25;

User us = new User();
User us1 = new User("Vasy");
User us2 = new User("Kosttya" , 18);


us2.NextAge(5);
us1.NextAge();




Console.WriteLine(us.Name + " " + us.Age);
Console.WriteLine(us1.Name + " " + us1.Age);
Console.WriteLine(us2.Name + " " + us2.Age);



Console.WriteLine();