int number = 1972;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int counter0  = 0;
int counter1 = 1;
int counter2 = 1;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 1;
int counter8 = 0;
int counter9 = 1;

foreach (char letter in letters)
{
    if (letter == '0') {counter0++;}
    else if (letter == '1') {counter1++;}
    else if (letter == '2') {counter2++;}
    else if (letter == '3') {counter3++;}
    else if (letter == '4') {counter4++;}
    else if (letter == '5') {counter5++;}
    else if (letter == '6') {counter6++;}
    else if (letter == '7') {counter7++;}
    else if (letter == '8') {counter8++;}
    else if (letter == '9') { counter9++;}
}
Console.WriteLine(numberAsString);