using System.Collections.Generic;

public static class ListExtensions
{
    public static string ToDelimitedString(this List<string> list, string delimiter = ", ")
    {
        return string.Join(delimiter, list.ToArray());
    }
}
