using System.Collections.Generic;

/// <summary>
/// Methods that extent the built-in List collection.
/// </summary>
public static class ListExtensions
{
    /// <summary>
    /// Generates a string of the list delimited by a string.
    /// </summary>
    /// <param name="list">The list to display.</param>
    /// <param name="delimiter">The string delimiter.</param>
    /// <returns>A string of the list delimited by a string.</returns>
    public static string ToDelimitedString(this List<string> list, string delimiter = ", ")
    {
        return string.Join(delimiter, list.ToArray());
    }
}