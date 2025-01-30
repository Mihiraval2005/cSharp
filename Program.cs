// using System; // Importing library

// class Program
// {
//     static void Greet(string name)
//     {
//         Console.WriteLine($"Hello {name}");
//     }
//     static void Main()
//     {
//          Greet("Mihir Raval");
//         // int m = 0;
//         // double price = 20000;

//         //   if(m >=  20){
//         //     Console.WriteLine("add");
//         //   }
//         //   else{
//         //     Console.WriteLine("Back");
//         //   }

//         // for (int m = 0; m < 5; m++)
//         // {
//         //     System.Console.WriteLine($"{m*20}");
//         // }
//         // Console.WriteLine($"Hello {m} & price:{price}"); 


//         // int[] arr = {1,2,3,4,5,6,7};

//         // for(int m = 0; m<arr.Length; m++){
//         //     System.Console.WriteLine($"{m}");
//         // }
//         // System.Console.WriteLine(arr);

//     }
// }


// ==============Class & Object================

// using System;

// class Mihir
// {
//     public string name;
//     public int age;

//     public void A()
//     {
//         System.Console.WriteLine($"{name},{age}");
//     }
// }
// class Add
// {
//     static void Main()
//     {
//         Mihir m = new Mihir();
//         m.A();
//     }
// }



// <access_modifier> <return_type> <method_name>(<parameters>)
// {
//     // Method body - code to execute
// }



using System;


class Mihir
{

    // public static void Greet(string name){
    //     System.Console.WriteLine($"{name}");
    // }

    // static void Main(){
    //     Greet("Mihir");
    //     Greet("Raval");
    // }

    // returnType
    // public static int Add(int a,int b){
    //     return a*b;
    // }

    // static void Main(){
    //     int res = Add(1,5);
    //      System.Console.WriteLine(res);
    // }


    // Method Overloading 
    // public static int Add(int a, int b,int x)
    // {
    //     return a + b + x;
    // }
    // public static float Add(int c, int d)
    // {
    //     return c / d;
    // }


    // static void Main(){
    //     System.Console.WriteLine(Add(6,2,2));
    //     System.Console.WriteLine(Add(1423424,2));
    // }

    //  Pass by Value vs. Pass by Reference
    // public static void In(int num)
    // {
    //     num += 1;
    //     System.Console.WriteLine($"dsf{num}");
    // }
    // public static void In1()
    // {

    //     int a = 20;

    //     In(a);
    //     System.Console.WriteLine(a);
    // }

    // static void Main()
    // {
    //     int x = 20;

    //     In1();
    //     System.Console.WriteLine(x);
    // }



    // public static void Cal (int a,int b,out int pl,out int min){
    //     pl = a+b;
    //     min= a-b;
    // }

    // static void Main(){
    //     int pl,min;
    //     Cal(90,20,out pl,out min);
    //  System.Console.WriteLine($"{pl} -|- {min}");
    // }



    // public void Hyy()
    // {
    //     System.Console.WriteLine("Raval....is here");
    // }

    // static void Main()
    // {
    //     Mihir obj = new Mihir();
    //     obj.Hyy();

    // }


    // public static void Count(int num){
    //     if(num<=0){
    //         System.Console.WriteLine("close");
    //         return;
    //     }
    //     System.Console.WriteLine(num);
    //     Count(num-1);
    // }

    // static void Main(){
    //     Count(10);
    // }

    // static int Rec(int n)
    // {
    //     if (n == 1)
    //         return 1;
    //     return n * Rec(n - 1);

    // }
    // static void Main()
    // {
    //     System.Console.WriteLine(Rec(10));
    // }


    

}