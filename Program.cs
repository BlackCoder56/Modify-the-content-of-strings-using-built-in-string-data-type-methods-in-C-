string message = "Find what is (inside the parentheses)";

int opeingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(opeingPosition);
Console.WriteLine(closingPosition);