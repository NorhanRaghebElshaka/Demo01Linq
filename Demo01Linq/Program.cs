using Demo01Linq;

internal class Program
{
    //static var Print(var X) // Invaled
    //{
    // return X;
    //}

    static dynamic Print(dynamic X)
    {
        return X;
    }
    static void Main()
    {
        ////// C# Keywards: Implicitly Typed Local Variable [Var - Dynamic]

        #region C# Keyword : var


        ////// var

        ////var Data01 = "Ahmed";
        //////Compiler will Detect DataType Of Local Variable based on Initial Value, At Compilation Type
        ////// Must Be Initialized
        ////// can't Initialized Local Varialble Wiht Null
        ////// Can't Change the datatype of the local variable after Initialization
        ////// Can't Use var as Parameter or ReternType 

        ////// var X = 12;
        ////// var X; // Invaled
        ////// var X = null;

        ////// Data01 = 12; // Invaled
        ////Data01 = "asad"; // Valed

        /////* Java script
        //// var X = 12 ;
        //// X = "Ahmed";
        //// X = new Object();            
        //// */ 

        #endregion

        #region C# Keyword: dynamic
        // dynamic

        ////dynamic Data02 = "Ahmed"; // Like var in JS

        ////// CLR Will Detect DataType Of Local variable Based on The last Value, At Runtime
        ////// Don't need to be Initialized
        ////// Can initalized Local variable with null
        ////// Can Change DataType of local variable0 After Initialization
        ////// Be careful while using dynamic Keyword 


        ////Data02 = 12;
        ////Console.WriteLine(Data02.GetType().Name);

        ////Data02 = 'a';
        ////Console.WriteLine(Data02.GetType().Name);

        ////Data02 = 1.2;
        //////Data02 = new Object();
        ////Console.WriteLine(Data02.GetType().Name);

        //////dynamic C = null;
        //////Console.WriteLine(C); 
        #endregion

        #region Extension Methods 
        //////int Number = 12345; // 54321

        //////var Result = IntExtesntion.Reverse(Number);
        //////Console.WriteLine(Result);

        //////var y = Number.Reverse();
        //////Console.WriteLine(y); 
        #endregion

        #region Anonymos Types
        // Anonymos Types

        ////////Employee Emp = new Employee() {Id =12 , Name = "Ahmed", Salary = 12000.0 };

        //////var Emp01 = new  { Id = 12, Name = "Ahmed", Salary = 12000.0 }; // Anonymous Type
        //////var Emp02 = new { Id = 12, Name = "Ahmed", Salary = 12000.0 };

        ////////var Emp02 = Emp01 with { Id = 5}; // NEW Feature C# 10.0



        ////////Console.WriteLine(Emp01.GetType().Name); //<>f__AnonymousType0`3
        ////////Console.WriteLine(Emp02.GetType().Name); //<>f__AnonymousType0`3

        ////////Console.WriteLine(Emp01);
        ////////Console.WriteLine(Emp02);


        ////////Emp.Id = 123; // Invaled -- Immutable Type - Can't Change Its value After Creation

        //////if (Emp01.Equals(Emp02))
        //////{
        //////    Console.WriteLine("Equals");
        //////}
        //////else
        //////{
        //////    Console.WriteLine("!Equals");
        //////}


        //////// The same Anonymous As Long as:
        //////// 1. the property Naming [Case Sensitive]
        //////// 2. the property order 
        //////// 3. the property DataType 
        #endregion

        #region LINQ Overview
        // LINQ : Language Integrated Query
        //      : +40 Estension Methods (LINQ Operators) using Against Any Data [Data in Sequance], Regrdless Data Store
        //      : 13 Category
        //      : LINQ Operators Exist Class "Enumerable"

        // Secquance: Object From Class Implement Interface "IEnumerable" 

        // Local Sequancne: L2O [LINQ To Object], L2XML [LINQ To XML]
        // Remote Sequance: L2EF [LINQ To EF Core]

        // Input Sequance --> LINQ Operator --> Output Sequance
        // Input Sequance --> LINQ Operator --> One value
        //                --> LINQ Operator --> Output Sequance 





        //List<int> Numbers = new List<int>() {1,2,3,4,5,6 };
        //var Result = Enumerable.Where(Numbers ,x => x % 2 == 0);
        //var Result  =Numbers.Where( x => x % 2 == 0);

        //Numbers.Any();
        //var Result = Enumerable.Range(5, 100);

        //foreach (var x in Result)
        //{
        //    Console.WriteLine(x);
        //} 
        #endregion

        #region LINQ syntax
        // LINQ syntax: 

        // 1. Fluent syntax
        // use LINQ Methods
        // 1.1. LINQ Operator As => Class Member methods Through class "Enumerable"

        //List<int> Numbers = new List<int>() { 88,3,2,1,45,46,4,8,9,7};

        // Where

        //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);



        // 1.2. LINQ Operator As => Extension Methods Through the Sequance [Recommended]

        //Numbers.Where(N => N % 2 == 0);

        //foreach (int n in Numbers)
        //{
        //    Console.WriteLine(n);
        //}


        // 2. Query syntax [Query Expresstion] Like SQL Style
        // Start With    From
        // End with      Select or group by
        // Query syntax easier than Fluent [Join, Group by, Let, Into]

        ////List<int> Numbers = new List<int>() { 88, 3, 2, 1, 45, 46, 4, 8, 9, 7 };
        ////var Result = from N in Numbers
        ////             where N > 5
        ////             select N;

        /////*
        //// Select N
        //// from Numbers
        //// where N>5

        //// */


        ////foreach (var N in Result)
        ////{
        ////    Console.WriteLine(N);
        ////} 
        #endregion

        #region LINQ Execution Ways

        // LINQ Execution Ways
        // 1. Differed Execution Way  : 10 Category
        // 2. Immidiate Execution Way : 3  Category [Elements operators - Casting operators - Aggregate operators]

        ////List<int> Numbers = new List<int>() {54,12,4,5,47,6,3,3 };

        ////var Result = Numbers.Where(N => N > 8); // Where Is Deffered

        ////Numbers.AddRange(new int[] { 10, 11, 12 });

        ////foreach (int N in Result) // here
        ////{
        ////    Console.WriteLine(N);
        ////}
        ///


        ////List<int> Numbers = new List<int>() { 54, 12, 4, 5, 47, 6, 3, 3 };

        ////var Result = Numbers.Where(N => N > 8).ToList(); // Where Is Deffered // here

        ////Numbers.AddRange(new int[] { 10, 11, 18 });

        ////foreach (int N in Result) // here
        ////{
        ////    Console.WriteLine(N);
        ////} 
        #endregion

        #region Data Setup
        // ListGenerator.ProductsList

        Console.WriteLine(ListGenerator.ProductsList[0]);
        Console.WriteLine(ListGenerator.CustomersList[1]);
        #endregion

    }
}
