using System.Web.Script.Serialization;

namespace Tree_Tasks
{
    //Example of C# Implementation of Binary Search Tree
    public class Program
    {
        static void Main(string[] args)
        {

            PeopleTree tree = new PeopleTree();
            tree.AddNode(new PersonNode(1, "Esther"));
            tree.AddNode(new PersonNode(5, "Jonah"));
            tree.AddNode(new PersonNode(3, "Sena"));
            tree.AddNode(new PersonNode(44, "Baba"));
            tree.AddNode(new PersonNode(44, "Baba"));
            tree.AddNode(new PersonNode(35, "Tesen"));
            tree.AddNode(new PersonNode(18, "Sesugh"));
            tree.AddNode(new PersonNode(15, "Sedoo"));
            tree.AddNode(new PersonNode(75, "Mama Nguzung"));
            tree.AddNode(new PersonNode(-4, "Mama Nguzung"));
            tree.AddNode(new PersonNode(18, "Pilakyaa"));



            //This statement serializes a Tree to see how it loos
            string jsonString = new JavaScriptSerializer().Serialize(tree);

            // Statement to find data in a Binary Tree
            // Due to the Arrangement of items in trees you will never have to travers the
            // collection to find a given item 
            //  BIG = O(LOG N)
            var treeNode = tree.GetNode(44);

             


        }
    }
}