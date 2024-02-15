// track


namespace ConsoleApp25
{
    public class Group
    {
        public string Code { get; set; }
        public string Curator { get; set; }

    }

    public class Student
    {
        public string Name { get; set; }
        public int  Age { get; set; }

        public Group _Group { get; set; }

    }
}
