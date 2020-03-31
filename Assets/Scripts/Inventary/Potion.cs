using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Potion",menuName="Items/Potion",order = 1)]

public class Potion : ScriptableObject
{
   [SerializeField]
   string objectName = "Potion";
   [SerializeField]
   int healthRestore;
   [SerializeField,TextArea(3,10)]
   string description;

    public int HealthRestore { get => healthRestore; }
}
