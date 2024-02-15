// track



namespace ConsoleApp25
{
    internal class User
    {
        // свойства  
        public string Name {  get; private set;  }

        public int Age { get; private set; } = 0;

        // конструтры  
        public User()
        {
            Name = "NoName";
            Age = 0;
        }
        public User ( string name )
        {
            Name = name;
            Age = 0;
        }
        public User(string name , int age)
        {
            Name = name;
            Age = age;
        }

        public void NextAge ()
        {
         
            Age++;
        }


        /// <summary>
        /// Увеличивает возраст на степ 
        /// </summary>
        /// <param name="step"></param>
        public void NextAge (int step)
        {
            Age += step;
        }

        public string Info()
        {
          
            return $"Имя:{Name}, возраст:{Age}";
        }
    }
}
