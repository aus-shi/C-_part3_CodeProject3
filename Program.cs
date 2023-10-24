Console.Clear();
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

/* 
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/


string delimiter = "I like";
// int? periodLocation; //to hold the location of the period character within a string.

for (int i = 0; i < myStrings.Length; i++)
{
    if (i == 0)
    {
        string tempString = myStrings[i];
        // string[] segments = tempString.Split(new[] { delimiter }, StringSplitOptions.RemoveEmptyEntries);
        // string formattedText = segments.Replace("\n",segments);
        string formattedText = tempString.Replace(".","\n.");
        // Console.WriteLine($"{formattedText}");
        string periodText = formattedText.Replace(".","");
        // Console.WriteLine(periodText);
        string trimmedText = periodText.TrimStart();
        Console.WriteLine(trimmedText);
    }
}