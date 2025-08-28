using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public string Name {  get; private set; }
    public Sprite Icon { get; private set; }
    public float AttackValue {get; private set;}
    public float DefenceValue {get; private set;}
    public float HealthValue {get; private set;}
    public float CriticalValue {get; private set;}

    public Item(SO_Item itemData)
    {
        Name = itemData.Name;
        Icon = itemData.ItemIcon;
        AttackValue = itemData.AttackValue;
        DefenceValue = itemData.DefenceValue;
        HealthValue = itemData.HealthValue;
        CriticalValue = itemData.CriticalValue;
    }
}
