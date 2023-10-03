namespace DSLKDon
{
    class Program
    {
        static void TestInput()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            MyList list = new MyList();
            Console.WriteLine("List 1:");
            list.Input();
            Console.WriteLine("------------------");
            Console.WriteLine("DSLK các số nguyên:");
            list.ShowList();
            Console.WriteLine("------------------");
            Console.WriteLine("DSLK số lớn nhất:" + list.GetMax().Data);
            Console.WriteLine("------------------");
            Console.WriteLine("DSLK số nhỏ nhất:" + list.GetMin().Data);
            Console.WriteLine("------------------");
            Console.WriteLine("DSLK chỉ chứa những số chẵn:");
            MyList evenList = list.GetEvenList();
            evenList.ShowList();
            Console.WriteLine("------------------");
            Console.WriteLine("DSLK chỉ chứa những số lẻ:");
            MyList oddList = list.GetOddList();
            oddList.ShowList();
            Console.WriteLine("------------------");
            Console.Write("Nhập x cần tìm: ");
            try
            {
                int.TryParse(Console.ReadLine(), out int x);
                Console.WriteLine(list.SearchX(x).Data);
            } catch (Exception e)
            {
                Console.WriteLine($"Lỗi: {e.Message}");
            }
            Console.WriteLine("List 2:");
            MyList list2 = new MyList();
            list2.Input();
            Console.WriteLine("DSLK các số nguyên:");
            list2.ShowList();
            Console.WriteLine("------------------");


            Console.WriteLine("List 3 (Gộp list 1 và list 2):");
            MyList list3 = list.JoinList(list2);
            Console.WriteLine("DSLK các số nguyên:");
            list3.ShowList();
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
