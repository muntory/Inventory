using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    [SerializeField]
    UIMainMenu uiMainMenu;
    public UIMainMenu MainMenuUI { get { return uiMainMenu; } }
    [SerializeField]
    UIStatus uiStatus;
    public UIStatus StatusUI { get { return uiStatus; } }
    [SerializeField]
    UIInventory uiInventory;
    public UIInventory InventoryUI { get { return uiInventory; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null && instance != this)
        {
            Destroy(this);
        }

    }
}
