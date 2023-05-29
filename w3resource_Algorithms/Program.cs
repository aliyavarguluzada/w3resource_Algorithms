/* 1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12 
*/


//string first = Console.ReadLine();

//string second = Console.ReadLine();

//int number1;
//int number2;

//bool case1 = int.TryParse(first, out number1);
//bool case2 = int.TryParse(second, out number2);


//int Sum = 0;
//if (number1 != number2)
//{
//    Sum = number1 + number2;
//}
//if(number1 == number2)
//{
//    Sum = (number1 + number2) * 3;
//}

//Console.WriteLine(Sum);


///////////////////////////////////////////////////////////



/* 
2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.

Sample Input:
53
30
51
Expected Output:
6
21
0
 */


//string number = Console.ReadLine();

//int n;

//bool caseU = int.TryParse(number, out n);

//int x = 0;
//if (n > 51)
//{
//    x = (n - 51) * 3;
//}
//else
//{
//    x = 51 - n;
//}


//Console.WriteLine(x);


////////////////////////////////



/*
 * 
 3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

Sample Input:
30, 0
25, 5
20, 30
20, 25
Expected Output:
True
True
True
False

 */


string num = Console.ReadLine();

int a;

bool casea = int.TryParse(num, out a);


string num2 = Console.ReadLine();
int b;
bool caseb = int.TryParse(num2, out b);
int result = a + b;

bool x;
if (a == 30 || b == 30 || result == 30)
{
    x = true;
}
else
{
    x = false;
}

Console.WriteLine(x);





