using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField]
    Button backButton;
    [SerializeField]
    TextMeshProUGUI attackValueText;
    [SerializeField]
    TextMeshProUGUI defenceValueText;
    [SerializeField]
    TextMeshProUGUI healthValueText;
    [SerializeField]
    TextMeshProUGUI criticalRateText;

    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.MainMenuUI.OpenMainMenu);
    }

    public void SetStatusView(Character player)
    {
        attackValueText.text = player.Attack.ToString();
        defenceValueText.text = player.Defense.ToString();
        healthValueText.text = player.Health.ToString();
        criticalRateText.text = (player.CriticalRate * 100).ToString("N2");
    }
    
}
