
Console.WriteLine("Write a number:");
string message = Console.ReadLine();
int number = int.Parse(message);
string answer;
if (((-999 <= number) && (number <= -100)) || ((100 <= number) && (number <= 999))) {
    if (number > 0) {
        answer = Convert.ToString(message[1]);
    }
    else {
        answer = Convert.ToString(message[2]);
    }
}
else {
    answer = "Isn't 3-digit number";
}
Console.WriteLine(answer);
