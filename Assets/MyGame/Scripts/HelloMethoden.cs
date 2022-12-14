using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //2) Instanzvariable nutzen
    private int startValue2 = 0;

    //3) Der Wert, der dazugezählt wird, ist bei der Deklaration noch nicht bekannt
    //z.B. Random oder User Input
    private int startValue3 = 0;

    //4) Copy by value
    private int startValue4 = 0;

    //5) Return
    private int startValue5 = 0;

    private readonly string startMsg = "before startValue: ";
    private readonly string endMsg = "after startValue: ";

    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("HelloMethoden script initialized");

        //at 2)
        LogValMsg(startMsg, "startValue2", startValue2);
        startValue2++;
        LogValMsg(endMsg, "startValue2", startValue2);

        //at 3)
        LogValMsg(startMsg, "startValue3", startValue3);
        startValue3 += Random.Range(1, 10);
        LogValMsg(endMsg, "startValue3", startValue3);

        //at 4)
        LogValMsg(startMsg, "startValue4", startValue4);
        OutputDecrementedValue(startValue4);
        LogValMsg(endMsg, "startValue4", startValue4);

        //at 5)
        LogValMsg(startMsg, "startValue5", startValue5);
        startValue5 = startValue5 - 2;
        LogValMsg(endMsg, "startValue5", startValue5);
    }

    //4)
    private void OutputDecrementedValue(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

   private void LogValMsg(string msg, string name, int val)
    {
        Debug.Log(msg + name + " = " + val);
    }
}
