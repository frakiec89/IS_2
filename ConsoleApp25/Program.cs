// track

using ConsoleApp25;
// ..Юзеры 
User us = new User();
User us1 = new User("Vasy");
User us2 = new User("Kosttya", 18);
us2.NextAge(5);
us1.NextAge();
Console.WriteLine(us.Name + " " + us.Age);
Console.WriteLine(us1.Name + " " + us1.Age);
Console.WriteLine(us2.Name + " " + us2.Age);
Console.WriteLine();

// ..группа 
Group group = new Group();
group.Curator = "Noname";
group.Code = "Is";

// студенты
Student student = new Student();
student.Name = "ivan"; 
student.Age = 18; ;
student._Group = group;


Student student1 = new Student();
student1.Name = "lena";
student1.Age = 19; ;
student1._Group = group;



Console.WriteLine(student.Name + " " + student.Age + " " + student._Group.Code + " " + student._Group.Curator);
Console.WriteLine(student1.Name + " " + student1.Age + " " + student1._Group.Code + " " + student1._Group.Curator);