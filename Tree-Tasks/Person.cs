using System.Runtime.Remoting.Messaging;

namespace Tree_Tasks
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
