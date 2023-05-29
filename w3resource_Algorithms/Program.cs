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


string number = Console.ReadLine();

int n;

bool caseU = int.TryParse(number, out n);

int x = 0;
if (n > 51)
{
    x = (n - 51) * 3;
}
else
{
    x = 51 - n;
}


Console.WriteLine(x);




