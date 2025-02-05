
var deez = "WWCCWCCW";

foreach (char ch in deez)
{
    if (ch == 'W')
    {
        deez.Remove(ch);
    }
}

var doze = "";