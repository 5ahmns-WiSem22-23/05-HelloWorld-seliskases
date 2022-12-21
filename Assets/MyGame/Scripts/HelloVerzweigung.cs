using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    [SerializeField]
    int i;

    [SerializeField]
    int x = 7;

    private void Start()
    {

        if(i > 0)
        {
            Debug.Log("i is greater than zero");
        } else if(x > 8)
        {
            Debug.Log("i isnt greater than zero and x is greater than 8");
        } else
        {
            Debug.Log("i isnt greater than zero and x isnt greater than 8");
        }

        switch(i)
        {
            case 5:
                Debug.Log("i is 5");
                break;
            default:
                Debug.Log("i isnt 5");
                break;
        }

        var y = (i > 6) ? "T" : "F";
        Debug.Log(y);

        if(x > i)
        {
            if(i < 8)
            {
                Debug.Log("x is greater than i and i is smaller than 8");
            } 
        }
    }
}
