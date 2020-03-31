using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Potion",menuName="Items/Potion",order = 1)]

public class Potion : Consumable
{
   
   [SerializeField]
   int points;
 
    public int Points { get => points; }

    public override void Drink()
    {
        base.Drink();
        Debug.Log("Consumed");
    }
}
