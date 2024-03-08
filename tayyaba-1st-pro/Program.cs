//See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Tayyaba!");

//reserve keywords
//string @class = "sawera";
//Console.WriteLine(@class);

//example
//string name = "sawera";
//int age = 20;
//Console.WriteLine("I am " + name + " and I am " + age);
//string Interpolation
//Console.WriteLine($"Hello! I am {name} and I am {age} year old");
//Calculate BMI(body mass index)
//double weight = 50.2,
//    height = 2.45,
//    bmi;

//bmi = weight / (height * height);
//Console.WriteLine($"bmi : {bmi:0.#} \n");

//datatypes
//Sbyte
//sbyte signedbyte = 126;
//Console.WriteLine(signedbyte);
//Console.WriteLine($"the min value of sbyte is {sbyte.MinValue}");
//Console.WriteLine($"the min value of sbyte is {sbyte.MaxValue} \n");

//Byte
//byte unsignedbyte = 255;
//Console.WriteLine(unsignedbyte);
//Console.WriteLine($"the min value of byte is {byte.MinValue}");
//Console.WriteLine($"the min value of byte is {byte.MaxValue} \n");

//Short
//short shortvalue  =32000;
//Console.WriteLine(shortvalue);
//Console.WriteLine($"the min value of short is {short.MinValue}");
//Console.WriteLine($"the min value of short is {short.MaxValue} \n");

//Ushort
//ushort ushortvalue = 65000;
//Console.WriteLine(ushortvalue);
//Console.WriteLine($"the min value of ushort is {ushort.MinValue}");
//Console.WriteLine($"the min value of ushort is {ushort.MaxValue} \n");

//object
//string uni = "Karachi University";
//Console.WriteLine(uni[8]);
//Console.WriteLine(uni.IndexOf("r").GetType());
//Console.WriteLine(uni.GetType());

//Dynamic Datatype
//dynamic number = "2";
//Console.WriteLine(number);

//Var Datatype
//var num = "sawera";
//Console.WriteLine(num);

//Convert into PKR
//Console.WriteLine($"Enter the number");
//var x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x * 278.59 + "PKR");

//comparison operator
//int a = 4;
//a += 5; //a= a+5

//var b = 14;
//b -= 14;

//Console.WriteLine(a == b);
//Console.WriteLine(b);

//Logical AND Operator(&)

//if (a == b & b == a)
//{
//    Console.WriteLine("both condition are true");

//}
//else
//{
//    Console.WriteLine("false condition");
//}
//Logical Conditional AND Operator(&&)

//if (a == b && b == a)
//{
//    Console.WriteLine("both condition are true");

//}
//else
//{
//    Console.WriteLine("false condition");
//}

//Logical OR Operator

//if(a == b | b == a)
//{
//    Console.WriteLine("both condition are true");

//}
//else
//{
//    Console.WriteLine("false condition");
//}

//C# raw string JSON
//var jsonn = """{"Name" : "Sawera", "age": "20"}""";
//Console.WriteLine(jsonn);

//Raw String Interpolation with JSON
//var named = "tayyaba";
//var json = $$"""{"Name" : {{named}}, "age" :"20"}""";
//Console.WriteLine(json);
//Raw strin in XML
//var XML = @"<books>
//<name> C# </name>
//</books>";
//Console.WriteLine(XML);

//To show variable path
//Console.WriteLine(@"c:\temp\no.txt");

//to see the difference btw parse and int
//Console.WriteLine(Convert.ToInt32(8));
//Console.WriteLine(int.Parse(null)); it will give exceptional error

//Nested IF
//Console.WriteLine("Enter Your Age");
//int ages = Convert.ToInt32(Console.ReadLine());


//if (age >= 18)
//{
//    Console.WriteLine("Do You Have CNIC???");
//    bool CNIC = Convert.ToBoolean(Console.ReadLine());
//    if (CNIC == true)
//    {
//        Console.WriteLine("You are eligible to vote");
//    }
//    else
//    {
//        Console.WriteLine("CNIC bawalo");
//    }
//}
//else
//{
//    Console.WriteLine("bary hojao");
//}

//Else IF
//Console.WriteLine("Select Day");
//var Day = Convert.ToString(Console.ReadLine());

//if (Day == "Monday")
//{
//    Console.WriteLine("GO to Aptech");
//}
//else if (Day == "Tuesday")
//{
//    Console.WriteLine("GO to Sleep");
//}
//else if (Day == "Wednesday")
//{
//    Console.WriteLine("GO to Market");
//}
//else if (Day == "Thurday")
//{
//    Console.WriteLine("GO to School");
//}
//else if (Day == "Friday")
//{
//    Console.WriteLine("GO to College");
//}
//else if (Day == "Saturday")
//{
//    Console.WriteLine("GO to University");
//}
//else if (Day == "Sunday")
//{
//    Console.WriteLine("GO to Park");
//}
//else
//{
//    Console.WriteLine("Go");
//}

//Switch Statement
//switch (Day)
//{
//    case "Monday":
//        Console.WriteLine("Today is Monday");
//        break;
//    case "Tuesday":
//        Console.WriteLine("Today is Tuesday");
//        break;
//    case "Wednesday":
//        Console.WriteLine("Today is Wednesday");
//        break;
//    case "Thurday":
//        Console.WriteLine("Today is Thurday");
//        break;
//    case "Friday":
//        Console.WriteLine("Today is Friday");
//        break;
//    case "Saturday":
//        Console.WriteLine("Today is Saturday");
//        break;
//    case "Sunday":
//        Console.WriteLine("Today is Sunnday");
//        break;
//    default:
//        Console.WriteLine("Please Enter Correct Day");
//        break;
//    }

//    ternary operator
//int a = 4;
//int b = 7;

//string stat = (a > b) ? "A is greater than B" : "B is greater than A";
//object stat = (a > b) ? "A is greater than B" : 5;
//Console.WriteLine(stat);

//var n = null ?? "Sawera";
//Console.WriteLine(n);

//loop
//Console.WriteLine("While Loop");

//int u = 0;

//while (u <= 10)
//{
//    Console.WriteLine(u);
//    u++;
//}

//infinite loop
//int x = 10;
//while (x > 5)
//{
//    x++;
//    Console.WriteLine(x);
//}

//do while loop
//int y = 0;

//Console.WriteLine("do while loop");

//do
//{

//    Console.WriteLine(y);
//    y++;

//} while (y < 10);


//Console.WriteLine("For Loop");

// for loop 
//with break
//for (int i = 0; i < 10; i++)
//{ 
//    if (i == 5)
//    {
//        break;
//    }

//    Console.WriteLine(i);
//}

// for loop 
//with continue


//int sum = 0;
//for (int i = 1; i < 23; i++)
//{
//    if (i % 2 == 0)
//    {

//        continue;
//    }

//    sum += i;

//Console.WriteLine($"{i}");
//}
//    Console.WriteLine($"sum of number" + sum);


//Array

//int[] marks = new int[4];
//marks[0] = 90;
//marks[1] = 80;
//marks[2] = 70;
//marks[3] = 60;

//Console.WriteLine(marks[2]);
//1st method
//for loop

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"index {i}). {marks[i]}");
//}

//2nd method
//string[] names = new string[3] { "sawera", "ansari", "ayra" };
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"index {i}). {names[i]}");
//}


//3rd method
//object[] value = { "sawera", "ayra", "mirha" };
////array mehtod
//Array.Sort(value);
//Array.Reverse(value);
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"index {i}). {value[i]}");
//}
//4th method
//object[] name = { 10 ,89 ,20 , 5 };
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"index {i}). {name[i]}");
//}
////array mehod
//Console.WriteLine(name.Min());
//Console.WriteLine(name.Max());
//Console.WriteLine(name.Contains(89));

//multidimensional 2D Array
int[,] arr2D = new int[3, 3]
{
    { 2,4,5 },
    { 3,4,5 },
    { 6,7,9 },
};
int row = arr2D.GetLength(1);

Console.WriteLine(row);

//2D dimensional array with loop

int[,] array2D = new int[3, 3]
{
    { 2,4,5 },
    { 3,4,5 },
    { 6,7,9 },
};
int row1 = array2D.GetLength(0);
int col = array2D.GetLength(1);

//for loop
//for (int i = 0; i < row1; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        Console.WriteLine($"index {i}). {array2D[i,j]}");
//    }
//    Console.WriteLine();
//}
Console.WriteLine("2D array");
//foreach
foreach (var value in arr2D)
{
    Console.WriteLine(value);

}

//3D Array
Console.WriteLine("3D Array");

int[,,] arr3D = new int[3, 2, 3] {
{
    { 2,4,5 },
    { 3,4,5 },

},
{
     { 2,4,5 },
     { 3,4,5 },
},
{
    { 2,4,5 },
    { 3,4,5 },
 }
};

int row3d = arr3D.GetLength(0);
int each_arr_row = arr3D.GetLength(1);
int col3d =arr3D.GetLength(2);

foreach (var item in arr3D)
{
    Console.WriteLine(item);
}
for (int i = 0; i < row3d; i++)
{
    for (int j = 0; j < each_arr_row; j++)
    {
        for (int k = 0; k < col3d; k++)
        {

        Console.WriteLine($"index {i}). {arr3D[i,j,k]}");
        }
    }
    Console.WriteLine();
}

//jagged array

Console.WriteLine("jugged array");

int[][] jugged = new int[3][];

jugged[0] = new int[] { 2, 55, 4 };
jugged[1] = new int[] { 2, 55, 4, 88 };
jugged[2] = new int[] { 2, 55, };

int arr = jugged.Length;

for (int l = 0; l < arr; l++)
{
    for (int i = 0; i < jugged[l].Length; i++)
    {
        Console.Write(jugged[l][i] + " ");
    }
    Console.WriteLine();
}


//for each loop

Console.WriteLine("\nForeach jugged");
foreach (int[] innerArray in jugged)
{
    foreach (int value in innerArray)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}
