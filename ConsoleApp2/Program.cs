Console.Write("enter line: ");
string s = Console.ReadLine();
Console.WriteLine($"Line before sort: {s}");
bool b = true;
while (b)
{
    if (s.Contains("de"))
    {
        s = s.Replace("de", "ed");
    }
    else if (s.Contains("fd"))
    {
        s = s.Replace("fd", "df");
    }
    else if (s.Contains("gd"))
    {
        s = s.Replace("gd", "dg");
    }
    else if (s.Contains("fe"))
    {
        s = s.Replace("fe", "ef");
    }
    else if (s.Contains("ge"))
    {
        s = s.Replace("ge", "eg");
    }
    else if (s.Contains("gf"))
    {
        s = s.Replace("gf", "fg");
    }
    else
        b=false;
}
Console.WriteLine($"Line afterx sort: {s}");