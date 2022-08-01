using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.LRU
{
    public class LRuCache
    {

        private class Node
        {
            public int Key { get; set; }
            public int Val { get; set; }
        }
        public int Capacity { get; private set; }
        private LinkedList<Node> circularList;
        private Dictionary<int, LinkedListNode<Node>> map;
        private int Size;
        public LRuCache(int capacity)
        {
            Capacity = capacity;
            circularList = new LinkedList<Node>();
            map = new Dictionary<int, LinkedListNode<Node>>();
            Size = 0;

        }
        public int Get(int key)
        {
            //When getting the data, if already present then move to the first.

            if (!map.ContainsKey(key))
                return -1;
            var node = map[key];
            circularList.Remove(node);
            //Adding current item to the top.
            circularList.AddFirst(node);
            return node.Value.Val;

        }
        public void Put(int key, int val)
        {
            //If already present, the move to the front of LL
            if (map.ContainsKey(key))
            {

                var node = map[key];
                circularList.Remove(node);
                circularList.AddFirst(node);
                node.Value.Val = val;
                return;
            }
            else
            {
                //If linked list is full, remove elemt from the last.
                if (Capacity == Size)
                {
                    var node = map[key];
                    map.Remove(key);
                    circularList.RemoveLast();
                    Size--;
                    return;

                }
            }
            var newnode = new Node()
            {
                Key = key,
                Val = val
            };
            //Add element at first and store in the Map.
            circularList.AddFirst(newnode);
            map.Add(key, circularList.First);
            Size++;
        }
    }
}
