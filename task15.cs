/*
=D
*/
Console.WriteLine("Write a number of week day:");
string message = Console.ReadLine();
int number = int.Parse(message);
string answer;
if (number > 7) {
    answer = "Такого для недели не существует";
}
else if (number <= 5) {
    answer = "нет"; //грустно((
}
else {
    answer = "да";
}
Console.WriteLine(answer);
