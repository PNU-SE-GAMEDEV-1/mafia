using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChatMessage
{
    private long senderId;
    public string sender;
    public MessageStyle.StyleType style;
    public string message;
    public float timeSent;
}
/*public class ChatManager : MonoBehaviour
{
    public GameState gameState;

    public void SendMessage(string sender, string message)
    {
        ChatMessage chatMessage = new ChatMessage { Sender = sender, Message = message, TimeSent = Time.time };
        gameState.ChatMessages.Add(chatMessage);
        // Update UI to display the new message
    }
}*/