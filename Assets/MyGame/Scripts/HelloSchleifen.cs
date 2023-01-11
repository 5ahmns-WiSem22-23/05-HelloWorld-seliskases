using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    [SerializeField]
    private float[][] myArray = { new float[] { 1, 6 }, new float[] { 7, 3, 1, 6 } };

    private void Start()
    {
        for(int i = 0; i < myArray.Length; i++)
        {
            for(int j = 0; j < myArray[i].Length; j++)
            {
                float value = myArray[i][j];
                Debug.Log($"i: {i}, j: {j}: {value}");
            }
        }
    }
}
