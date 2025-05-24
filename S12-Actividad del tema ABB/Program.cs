using System;
namespace ejercicio_11
{
    internal class arbolbusquedabinaria
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
        public class BinarySearchTree
        {
            public Node Root { get; set; }
            public BinarySearchTree()
            {
                Root = null;
            }
            public void Insert(int data)
            {
                Root = InsertRec(Root, data);
            }
            private Node InsertRec(Node root, int data)
            {
                if (root == null)
                {
                    root = new Node(data);
                    return root;
                }
                if (data < root.Data)
                    root.Left = InsertRec(root.Left, data);
                else if (data > root.Data)
                    root.Right = InsertRec(root.Right, data);
                return root;
            }

            public bool Search(int data)
            {
                return SearchRec(Root, data) != null;
            }
            private Node SearchRec(Node root, int data)
            {
                if (root == null || root.Data == data)
                    return root;
                if (data < root.Data)
                    return SearchRec(root.Left, data);
                return SearchRec(root.Right, data);
            }
            public void Delete(int data)
            {
                Root = DeleteRec(Root, data);
            }
            private Node DeleteRec(Node root, int data)
            {
                if (root == null)
                    return root;
                if (data < root.Data)
                    root.Left = DeleteRec(root.Left, data);
                else if (data > root.Data)
                    root.Right = DeleteRec(root.Right, data);
                else
                {
                    if (root.Left == null)
                        return root.Right;
                    else if (root.Right == null)
                        return root.Left;

                    root.Data = MinValue(root.Right);
                    root.Right = DeleteRec(root.Right, root.Data);
                }
                return root;
            }
            private int MinValue(Node root)
            {
                int minValue = root.Data;
                while (root.Left != null)
                {
                    minValue = root.Left.Data;
                    root = root.Left;
                }
                return minValue;
            }

            public void PreOrder()
            {
                PreOrderRec(Root);
                Console.WriteLine();
            }
            private void PreOrderRec(Node root)
            {
                if (root != null)
                {
                    Console.Write(root.Data + " ");
                    PreOrderRec(root.Left);
                    PreOrderRec(root.Right);
                }
            }
            public void InOrder()
            {
                InOrderRec(Root);
                Console.WriteLine();
            }
            private void InOrderRec(Node root)
            {
                if (root != null)
                {
                    InOrderRec(root.Left);
                    Console.Write(root.Data + " ");
                    InOrderRec(root.Right);
                }
            }

            public void PostOrder()
            {
                PostOrderRec(Root);
                Console.WriteLine();
            }
            private void PostOrderRec(Node root)
            {
                if (root != null)
                {
                    PostOrderRec(root.Left);
                    PostOrderRec(root.Right);
                    Console.Write(root.Data + " ");
                }
            }
        }
    }
}