using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

[System.Serializable]
public class GameState
{
    public GamePhase.PhaseType currentPhase;
    public List<IngamePlayer> players;
    public List<ChatMessage> chatMessages;
    public int minLevel = 0;
    public int maxLevel = 20;
    public int minPlayers = 3;
    public int maxPlayers = 8;
    private String password = null;
    public int playerCount = 0;


    public GameState(int minLevel, int maxLevel, int minPlayers, int maxPlayers, string password)
    {
        this.minLevel = minLevel;
        this.maxLevel = maxLevel;
        this.minPlayers = minPlayers;
        this.maxPlayers = maxPlayers;
        this.password = password;
        this.players = new List<IngamePlayer>();
        this.chatMessages = new List<ChatMessage>();
        this.playerCount = 0;
    }
    /*public void SaveGameState()
    {
        string json = JsonUtility.ToJson(gameState);
        // Save json to a file or PlayerPrefs
    }

    public void LoadGameState()
    {
        // Load json from a file or PlayerPrefs
        string json = *//* loaded json string *//*;
        gameState = JsonUtility.FromJson<GameState>(json);
    }*/
}