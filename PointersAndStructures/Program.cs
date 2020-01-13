using System;

namespace PointersAndStructures
{
    //Pointers can be used with structures if the structure contains ONLY value types as its members
    struct MyStruct
    {
        public int x;
        public int y;
        public void SetXY(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        unsafe static void Main(string[] args)
        {
            MyStruct ms; //Not necessary to instantiate aan instance of a struct with new keyword
            MyStruct* ms1 = &ms;
            ms1->SetXY(10, 20);
            ms1->ShowXY();
        }
    }
}
