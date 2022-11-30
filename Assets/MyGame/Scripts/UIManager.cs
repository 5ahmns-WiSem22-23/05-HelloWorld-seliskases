using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private InputField inputField;
    [SerializeField]
    private TextMeshProUGUI text;

    private void Awake()
    {
        text.gameObject.SetActive(false);
    }

    public void SetText()
    {
        if(!text.gameObject.activeSelf) text.gameObject.SetActive(true);

        text.text = inputField.text;
    }
}
