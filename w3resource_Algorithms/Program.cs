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


string first = Console.ReadLine();

string second = Console.ReadLine();

int number1;
int number2;

bool case1 = int.TryParse(first, out number1);
bool case2 = int.TryParse(second, out number2);


int Sum = 0;
if (number1 != number2)
{
    Sum = number1 + number2;
}
if(number1 == number2)
{
    Sum = (number1 + number2) * 3;
}

Console.WriteLine(Sum);




