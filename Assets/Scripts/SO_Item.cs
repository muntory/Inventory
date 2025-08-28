using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Data", menuName = "Item/New Item")]
public class SO_Item : ScriptableObject
{
    public string Name;
    public Sprite ItemIcon;
    public float AttackValue;
    public float DefenceValue;
    public float HealthValue;
    public float CriticalValue;

}
