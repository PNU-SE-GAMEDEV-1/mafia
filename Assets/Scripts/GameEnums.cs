using System;

public enum MessageStyle
{
    NORMAL,
    DEAD,
    UNKNOWN,
    WARNING,
    ERROR,
    SUCCESS,
    DAY,
    NIGHT,
    SYSTEM
}

public enum Alignment 
{ 
    CIV, 
    MAF 
}

public enum GameRole 
{ 
    CIV, 
    MAF 
}

public enum GamePhase 
{ 
    NIGHT_CHAT, 
    NIGHT_VOTE, 
    DAT_CHAT, 
    DAY_VOTE, 
    GAME_OVER 
}
