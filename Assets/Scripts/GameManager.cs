using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public Character player {  get; private set; }
    public List<SO_Item> itemData;

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

        SetData();


    }

    private void Start()
    {
        UIManager.Instance.MainMenuUI.OpenMainMenu();

    }

    private void SetData()
    {
        player = new Character();
        for (int i = 0; i < itemData.Count; i++)
        {
            Item item = new Item(itemData[i]);
            player.AddItem(item);
        }
        
    }
}
