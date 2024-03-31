using System;
using UnityEngine;

[System.Serializable]
public class PlayerProfile
{
    public long id;
    public string name;
    public string email;
    public string registrationDate;
    public int totalGamesPlayed;
    public int winCount;
    public int level;
    public long experience;
    public int karma;


    public PlayerProfile(long id, string name, string email, string registrationDate, int totalGamesPlayed, int winCount, int level, long experience, int karma)
    {
        this.id = id;//set id +1
        this.name = name;
        this.email = email;
        this.registrationDate = registrationDate;
        this.totalGamesPlayed = totalGamesPlayed;
        this.winCount = winCount;
        this.level = level;
        this.experience = experience;
        this.karma = karma;
    }


    public PlayerProfile()
    {
        //todo set id +1
        this.registrationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        this.totalGamesPlayed = 0;
        this.winCount = 0;
        this.level = 0;
        this.experience = 0;
        this.karma = 2;
    }
}