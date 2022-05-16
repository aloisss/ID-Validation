// See https://aka.ms/new-console-template for more informati



Console.WriteLine("Please Enter Your ID number");
var number = Console.ReadLine();
int digit = 0;
int sum = 0;

for (int i = 0; i <= number.Length - 1; i++)
{
    //checking the position of the digit for correct Iteration

    if (i % 2 == 1)
    {
        digit = int.Parse(number.Substring(i, 1));
        sum += DoubleDigitValue(digit);

        
    }
    else
    {
        digit = int.Parse(number.Substring(i, 1));
        sum += digit;
    }

}
;
if (sum % 10 == 0)
{
    Console.WriteLine("Your ID number is valid");
}
else
{
    Console.WriteLine("Your ID number is Invalid");
}





//Method to check if number above 9 and to add the two digits if the number is greater than 9

static int DoubleDigitValue(int digit)
{
    int sum;
    int doubledDigit = digit * 2;
    if (doubledDigit >= 10)
    {
        sum = 1 + doubledDigit % 10;
    }
    else
    {
        sum = doubledDigit;
    }
    return sum;
}

