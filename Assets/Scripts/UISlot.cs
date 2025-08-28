using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField]
    Image iconImage;
    [SerializeField]
    Image onEquipImage;

    public Item currentItem;

    public void SetItem(Item item)
    {
        currentItem = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (currentItem == null)
        {
            iconImage.sprite = null;
            onEquipImage.gameObject.SetActive(false);

        }
        else
        {
            iconImage.sprite = currentItem.Icon;
            if (GameManager.Instance.player.Equipment.Contains(currentItem) )
            {
                onEquipImage.gameObject.SetActive(true);

            }
            else
            {
                onEquipImage.gameObject.SetActive(false);

            }
        }

    }
}
