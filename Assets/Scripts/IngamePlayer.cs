using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class IngamePlayer
{
    public long id;
    public string name;
    public Alignment alignment;
    public GameRole role;
    public bool isAlive;
}