using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] TextMeshProUGUI text;

    void Awake()
    {
        text.gameObject.SetActive(false);
    }
    
    public void ShowText()
    {
        text.text = inputField.text;
        if (!text.gameObject.activeSelf) text.gameObject.SetActive(true);
    }
}
