using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph<T> where T : IComparable
    {

        // list of all nodes in the graph
        private LinkedList<GraphNode<T>> nodes;


        // constructor – set nodes to new empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }


        // only returns true if the graph’s list of nodes is empty
        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }



        // only returns true if node is present in the graph
        public bool ContainsGraph(GraphNode<T> node)
        {
            //search based on ID 
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;
        }



        // only returns true if nodes “from “ and “to” are adjacent
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
	            {
                    if (from.GetAdjList().Contains(to.ID))
	    	        return true;
                }
            }
            return false;
        }





        // add a new node (with this “id”) to the list of nodes
        public void AddNode(T id)
        {
            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }

        //returns the node with this id
        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                    return n;
               
            }
            return null;

        }






        // Add a directed edge between the node with id "from" and the node with id “to” 
        public void AddEdge(T from, T to)
        {
            this.GetNodeByID(from).AddEdge(this.GetNodeByID(to));
             
        }


        //Perform a DFS traversal starting at the node with id “startID”
        //leaving a list of visited id’s in the visited list. 

        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();

            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Push(startID);

            while (toVisit.Count != 0)
            {

                //to be completed. Hint: get current node to the list of visited nodes 
                //and add its adjacent nodes (only those not already visited) to toVist 

            }
        }



        //Perform a BFS traversal starting at the node with id “startID”
        //leaving a list of visited id’s in the visited list. 

        public void BreadthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                this.GetNodeByID(toVisit.Dequeue());

                //to be completed. Hint: get current node to the list of visited nodes
                //and add its adjacent nodes (only those not already visited) to toVisit
            }
        }



        // Return a list which contains the id's of the nodes that are mother           vertices. For example, return the list ['A',C','B'] if the nodes with id’s = A, C and B are mother vertices

        public List<T> mothervertices()
        {
            
            // Hint: Implement a method Boolean ListEq(List<T> l1, List<T> l2)  
            // that only returns true if two lists of type List<T> 
            // contain the same elements. Use ListEq and a traversal method (BFS or DFS)
            // to check if a vertex is a mother vertex. 

        }


    } //end class

}