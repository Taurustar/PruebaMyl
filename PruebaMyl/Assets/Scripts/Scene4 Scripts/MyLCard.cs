using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLCard : ScriptableObject {


    public enum Cards 
    {
        ALLY,
        WEAPON,
        TOTEM,
        TALLISMAN,
        GOLD
    }
    
    public Cards cardType;
    public string name, legend;
    public int cost, damage;


    public MyLCard(Cards card)
    {
        cardType = card;
    }
}
