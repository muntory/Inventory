using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    Button backButton;
    [SerializeField]
    UISlot slotPrefab;
    [SerializeField]
    Transform slotsParentTransform;

    public List<UISlot> slots = new List<UISlot>();

    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.MainMenuUI.OpenMainMenu);
        InitInventoryUI(GameManager.Instance.player.Inventory);
    }

    private void Update()
    {
        Character player = GameManager.Instance.player;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (player.Equipment.Contains(player.Inventory[0]))
            {
                player.UnEquipItem(player.Inventory[0]);
            }
            else
            {
                player.EquipItem(player.Inventory[0]);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (player.Equipment.Contains(player.Inventory[1]))
            {
                player.UnEquipItem(player.Inventory[1]);
            }
            else
            {
                player.EquipItem(player.Inventory[1]);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (player.Equipment.Contains(player.Inventory[2]))
            {
                player.UnEquipItem(player.Inventory[2]);
            }
            else
            {
                player.EquipItem(player.Inventory[2]);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (player.Equipment.Contains(player.Inventory[3]))
            {
                player.UnEquipItem(player.Inventory[3]);
            }
            else
            {
                player.EquipItem(player.Inventory[3]);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (player.Equipment.Contains(player.Inventory[4]))
            {
                player.UnEquipItem(player.Inventory[4]);
            }
            else
            {
                player.EquipItem(player.Inventory[4]);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (player.Equipment.Contains(player.Inventory[5]))
            {
                player.UnEquipItem(player.Inventory[5]);
            }
            else
            {
                player.EquipItem(player.Inventory[5]);
            }
        }
    }

    private void InitInventoryUI(List<Item> inventory)
    {
        for (int i = 0; i < 15; ++i)
        {
            UISlot uiSlot = Instantiate(slotPrefab, slotsParentTransform);
            if (i < inventory.Count)
            {
                uiSlot.SetItem(inventory[i]);

            }
            else
            {
                uiSlot.SetItem(null);

            }
            slots.Add(uiSlot);

        }

        RefreshAll();
    }

    public void RefreshAll()
    {
        foreach (UISlot uiSlot in slots)
        {
            uiSlot.RefreshUI();
        }
    }
}
