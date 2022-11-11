using UnityEngine;

public class ShopTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject shopUI;

    [SerializeField]
    string playerTag = "Player";

    private bool isOn = false;

    void ShowUI(bool shouldShow)
    {
        shopUI.SetActive(shouldShow);
        isOn = shouldShow;
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (shopUI == null || !collision.CompareTag(playerTag))
            return;
        ShowUI(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (shopUI == null || !collision.CompareTag(playerTag))
            return;
        ShowUI(false);
    }
}
