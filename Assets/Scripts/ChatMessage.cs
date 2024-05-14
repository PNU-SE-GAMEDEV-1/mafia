using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChatMessage
{
    private long senderId;
    public string sender;
    public MessageStyle style;
    public string message;
}