using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
