System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

var date1 = DateTime.Now;
var badFormats = new List<string>();

Console.WriteLine($"{"Date String",-37} {"Date",-19}\n");
foreach (var dateString in date1.GetDateTimeFormats())
{
    DateTime parsedDate;
    if (DateTime.TryParse(dateString, out parsedDate))
        Console.WriteLine($"{dateString,-37} {DateTime.Parse(dateString),-19}");
    else
        badFormats.Add(dateString);
}

// Display strings that could not be parsed.
if (badFormats.Count > 0)
{
    Console.WriteLine("\nStrings that could not be parsed: ");
    foreach (var badFormat in badFormats)
        Console.WriteLine($"   {badFormat}");
}
