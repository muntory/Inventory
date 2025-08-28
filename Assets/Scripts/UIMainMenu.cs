using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField]
    Button statusButton;
    [SerializeField]
    Button inventoryButton;
    [SerializeField]
    TextMeshProUGUI titleText;
    [SerializeField]
    TextMeshProUGUI levelText;
    [SerializeField]
    TextMeshProUGUI nameText;
    [SerializeField]
    TextMeshProUGUI expText;
    [SerializeField]
    TextMeshProUGUI descriptionText;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }
    public void OpenMainMenu()
    {
        UIManager.Instance.StatusUI.gameObject.SetActive(false);
        UIManager.Instance.InventoryUI.gameObject.SetActive(false);
        UIManager.Instance.MainMenuUI.gameObject.SetActive(true);
        SetPlayerDescDiv(GameManager.Instance.player);

    }

    public void OpenStatus()
    {
        UIManager.Instance.StatusUI.gameObject.SetActive(true);
        UIManager.Instance.InventoryUI.gameObject.SetActive(false);
        UIManager.Instance.MainMenuUI.gameObject.SetActive(true);
        UIManager.Instance.StatusUI.SetStatusView(GameManager.Instance.player);

    }

    public void OpenInventory()
    {
        UIManager.Instance.StatusUI.gameObject.SetActive(false);
        UIManager.Instance.InventoryUI.gameObject.SetActive(true);
        UIManager.Instance.MainMenuUI.gameObject.SetActive(true);

    }

    public void SetPlayerDescDiv(Character player)
    {
        titleText.text = player.Title;
        nameText.text = player.Name;
        descriptionText.text = player.Description;
        levelText.text = player.Level.ToString();
        expText.text = $"{player.Exp} / {player.MaxExp}";
    }
}
