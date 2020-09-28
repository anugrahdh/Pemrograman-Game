using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{
    public int[] intArray;
    // Start is called before the first frame update
    void Start()
    {
        //intArray = new int[4];
        //intArray[0] = 10;
        //intArray[1] = 20;
        //intArray[2] = 30;
        //intArray[3] = 40;
        Debug.Log("Menampilkan seluruh Array");
        foreach (int a in intArray)
        {
            Debug.Log (a);
        }
        //Debug.Log("Nilai Index ke 2 adalah " + intArray[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
