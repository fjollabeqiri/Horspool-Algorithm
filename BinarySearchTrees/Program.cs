using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    
    class Program
    {struct BstNode
    {
        int data;
        BstNode* Left;
        BstNode *Right;
    }
        BstNode* getNewNode(int data)
        {
            BstNode* newNode = new BstNode();
            newNode->data = data;
            newNode->Left = NULL;
            newNode->Right = NULL;
            return newNode;
        }
        static void Main(string[] args)
        {

        }
    }
}
