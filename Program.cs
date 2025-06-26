// string message = "Find what is (inside the parentheses)";

// int opeingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(opeingPosition);
// // Console.WriteLine(closingPosition);

// opeingPosition += 1;

// int length = closingPosition - opeingPosition;

// Console.WriteLine(message.Substring(opeingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "hello there";

// int first_h = message.IndexOf('h'); // returns first occurence
// int last_h = message.LastIndexOf('h'); // returns last occurence

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

while (true)
{
    int opeingPosition = message.IndexOf('(');
    if (opeingPosition == -1) break;

    opeingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - opeingPosition;
    Console.WriteLine(message.Substring(opeingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

