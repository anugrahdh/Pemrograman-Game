using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swiitch : MonoBehaviour
{
    public GameObject[] Sinopsis;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= 4)
            index = 4;

        if (index < 0)
            index = 0;



        if (index == 0)
        {
            Sinopsis[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < Sinopsis.Length; i++)
        {
            Sinopsis[i].gameObject.SetActive(false);
            Sinopsis[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;

        for (int i = 0; i < Sinopsis.Length; i++)
        {
            Sinopsis[i].gameObject.SetActive(false);
            Sinopsis[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
