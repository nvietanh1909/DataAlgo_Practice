namespace DSLKDon
{
    class Program
    {
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            Console.WriteLine("DSLK so lon nhat:" + list.GetMax().Data);
            Console.WriteLine("DSLK so nho nhat:" + list.GetMin().Data);
            Console.WriteLine("DSLK chi chua so chan:");
            MyList evenList = list.GetEvenList();
            evenList.ShowList();
            Console.WriteLine("DSLK chi chua so le:");
            MyList oddList = list.GetOddList();
            oddList.ShowList();
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
