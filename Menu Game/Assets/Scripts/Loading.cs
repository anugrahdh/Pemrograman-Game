using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loading : MonoBehaviour
{
    //waktu delay untuk load scene
    [SerializeField] private float delayLoading = 3f;

    [SerializeField] private string namaScene;

    private float timeElapsed;

    //  nama scene untuk pindah scene yang diinputkan pada Inspector
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayLoading)
        {
            SceneManager.LoadScene(namaScene);
        }
    }



}
