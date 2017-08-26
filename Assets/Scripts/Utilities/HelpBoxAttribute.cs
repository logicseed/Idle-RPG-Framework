using UnityEngine;

/// <summary>
/// The attribute applied to fields to display a help box.
/// </summary>
public class HelpBoxAttribute : PropertyAttribute
{
    public string message;
    public HelpBoxMessageType messageType;

    public HelpBoxAttribute(string message, HelpBoxMessageType messageType = HelpBoxMessageType.None)
    {
        this.message = message;
        this.messageType = messageType;
    }
}
