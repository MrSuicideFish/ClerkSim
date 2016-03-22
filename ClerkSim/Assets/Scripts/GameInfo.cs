using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInfo
{
    public static string m_PlayerName { get; set; }

    public GameInfo( string playerName )
    {
        m_PlayerName = playerName;
    }
}