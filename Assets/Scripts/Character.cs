using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Title {  get; private set; }
    public string Name {  get; private set; }
    public int Level { get; private set; }
    public int Exp {  get; private set; }
    public int MaxExp { get; private set; }

    public float Attack { get; private set; }
    public float Defense { get; private set; }
    public float MaxHealth { get; private set; }
    public float Health { get; private set; }
    public float CriticalRate { get; private set; }
    public string Description { get; private set; }

    public List<Item> Inventory { get; private set; }
    public List<Item> Equipment { get; private set; }


    public Character()
    {
        Title = "Newbie";
        Name = "Chad";
        Level = 10;
        Exp = 9;
        MaxExp = 12;
        Attack = 40f;
        Defense = 10f;
        MaxHealth = 100f;
        Health = MaxHealth;
        CriticalRate = 0.25f;
        Description = "This character is Newbie.";
        Inventory = new List<Item>();
        Equipment = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void EquipItem(Item item)
    {
        if (!Inventory.Contains(item))
        {
            return;
        }

        Attack += item.AttackValue;
        Defense += item.DefenceValue;
        Health += item.HealthValue;
        CriticalRate += item.CriticalValue;

        Equipment.Add(item);

        UIManager.Instance.InventoryUI.RefreshAll();
        Debug.Log($"{item.Name}을 장착 했습니다");
    }

    public void UnEquipItem(Item item)
    {
        if (!Inventory.Contains(item))
        {
            return;
        }

        Attack -= item.AttackValue;
        Defense -= item.DefenceValue;
        Health -= item.HealthValue;
        CriticalRate -= item.CriticalValue;

        Equipment.Remove(item);
        UIManager.Instance.InventoryUI.RefreshAll();

        Debug.Log($"{item.Name}을 장착해제 했습니다");
    }
}
