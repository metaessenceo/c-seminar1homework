
Console.WriteLine("Write a number:");
string message = Console.ReadLine();
int number = int.Parse(message);
string answer;
if ((number >= 100) && (number <- 999)) {
    answer = Convert.ToString(message[1]);
}
else {
    answer = "Isn't 3-digit number";
}
Console.WriteLine(answer);
