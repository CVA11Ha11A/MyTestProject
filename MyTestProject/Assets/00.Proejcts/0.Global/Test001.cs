using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test001 : MonoBehaviour
{

    static int TestNum = 0;

    
    void Start()
    {
        DE.Log("Start");
        StartCoroutine(CTest());
    }

    // Update is called once per frame
    void Update()
    {
        if (TestNum++ < 20)
        {
            DE.Log("Update");
        }

    }


    IEnumerator CTest()
    {
        int temp = 0;
        for (int i = 0; i < 10; i++)
        {
            DE.Log($"CallCount : {temp++}");
            yield return null;

        }
    }
}
