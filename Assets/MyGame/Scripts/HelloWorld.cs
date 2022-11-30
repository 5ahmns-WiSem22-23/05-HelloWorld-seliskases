using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        string msg = Application.systemLanguage switch
        {
            SystemLanguage.French => "Bonjour",
            SystemLanguage.German => "Hallo",
            SystemLanguage.Italian => "Ciao",
            SystemLanguage.Chinese => "你好",
            SystemLanguage.Japanese => "こんにちは",
            _ => "Hello",
        };

        Debug.Log(msg);
    }
}
