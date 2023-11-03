using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
namespace IntBST;
class Program
{
    public static void TestBST()
    {
        MyBinaryTree tree = new MyBinaryTree();
        tree.Input();
        Console.WriteLine("Cac thanh phan cua BST(NLR): ");
        tree.PreOrder();
        Console.WriteLine();
        Console.WriteLine("So la cua cay:" + tree.CountLeaf());
        Console.WriteLine("Gia tri lon nhat cua cay: " + tree.FindMax().Data);
        Console.WriteLine("Gia tri nho nhat cua cay: " + tree.FindMin().Data);
        do
        {
            Console.Write("Nhap gia tri x muon tim: ");
            int.TryParse(Console.ReadLine(), out int x);
            if (tree.FindX(x) == null) Console.WriteLine($"Khong ton tai {x} trong BST");
            else
            {
                Console.WriteLine($"Ton tai {x} trong BST");
            }
            Console.Write("Nhap gia tri x muon xoa: ");
            int.TryParse(Console.ReadLine(), out int y);
            if(tree.Remove(y) == false) Console.WriteLine($"Khong ton tai {y} trong BST");
            else
            {
                Console.WriteLine($"Da xoa {y} thanh cong");
            }
            Console.WriteLine("BST sau khi xoa");
            tree.PreOrder();
            return;

        } while (true);
    }
    static void Main()
    {
        TestBST();
    }
}