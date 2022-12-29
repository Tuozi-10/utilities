using System.Collections;
using System.Collections.Generic;
using Core.Scripts.Utils;
using UnityEngine;

public class test : MonoSingleton<test>
{
    // Start is called before the first frame update
    void Start()
    {
        Logs.Log("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
