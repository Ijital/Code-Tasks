using System;

namespace Tree_Tasks
{
    public class PersonNode
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public PersonNode RightNode { get; set; }

        public PersonNode LeftNode { get; set; }

        public  PersonNode parentNode { get; set; }

        public PersonNode(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void InsertNode(PersonNode node)
        {
            if (node == null) { return; }

            if (node.Age > this.Age)
            {
                if (this.RightNode == null)
                {
                    this.RightNode = node;
                    this.RightNode.parentNode = this;
                }
                else
                {
                    this.RightNode.InsertNode(node);
                }

            }
            else if (node.Age < this.Age)
            {
                if (this.LeftNode == null)
                {
                    this.LeftNode = node;
                    this.LeftNode.parentNode = this;
                }
                else
                {
                    this.LeftNode.InsertNode(node);
                }

            }
        }

        // Binary Search 
        public PersonNode FindNode(int value)
        {
            PersonNode theNode = null;

            if (value == this.Age)
            {
                theNode = this;
            }

            else if(value > this.Age)
            {
                theNode = this.RightNode.FindNode(value);
            }

           
            else if(value < this.Age)
            {
                theNode = this.LeftNode.FindNode(value);
            }

            return theNode;
        }

    }
}
