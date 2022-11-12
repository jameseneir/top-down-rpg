using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ItemSlotUI : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI priceText;
    public void SetUp(Item data)
    {
        image.sprite = data.sprite;
        priceText.text = data.price.ToString();
    }
}
