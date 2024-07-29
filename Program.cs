using System.Collections.Generic;
using CSharpLesson4;

int amount = 1234;
int months = 12;
int yearlyWage = Utilities.CalculateYearlyWage(amount, months);
Console.WriteLine($"Yearly vage :{yearlyWage}");

/* ‹access modifier> ‹return type> Method_Name (Parameters)
    { method statement }  METHOD SYNTAX */


// Variable Scope= Degisken kapsami


/* public int AddNumbers (int a, int b, int c=100){
    int sum = a + b + c;
    return sum;
}
AddNumbers(10, 20);
AddNumbers(10,20,30)  */ //OPTIONEL PARAMETRE

/* public static void UsingNamedArguments
int amount = 1234;
int months = 12;
int bonus = 500;
int yearlyWageForEmployee = CalculateYearlyWageWithNamed(bonus: bonus,
monthlyWage: amount, number0fMonthsWorked: months);  NAMED ARGUMENT siranin onemi yok */


/* public static void UsingNamedArguments
int amount = 1234;
int months = 12;
int bonus = 500;
int yearlyWageForEmployee = CalculateYearlyWageWithNamed(bonus: bonus,
monthlyWage: amount, number0fMonthsWorked: months);  EXPRESSION BODIED MEMBERS kisa yolu */


int 1 = myString.Length;
// Get the length of the string Learning


string upper = myString. ToUpper ();
// uppercase


string lower = myString. ToLower ();
// lowercase

bool b = myString. Contains( "Hello");
// Check if a string contains "Hello", return bool

string s = myString.Replace("a", "b");
// Replace "a" with "b" in the string

string sub = myString.Substring(1, 3);
//2. siradaki ve 4. sira arasindaki elemanlarla yeni dizi 