using System.Windows.Markup;

namespace Tree_Tasks
{
    public class PeopleTree
    {
        private PersonNode parentNode;
        public PersonNode RootNode { get; set; }

        public void AddNode(PersonNode node)
        {
            if (RootNode == null)
            {
                RootNode = node;
                return; 
            }
            RootNode.InsertNode(node);
        }

        public PersonNode GetNode(int value)
        {
           return this.RootNode.FindNode(value);
        }

        public void RemoveNode (int value)
        { 
              PersonNode node = this.GetNode(value);
              PersonNode parent = node.parentNode;
        }
    }
}
