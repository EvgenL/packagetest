using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestScript
{
    [MenuItem("Test package/Say hello")]
    public static void Hello()
    {
        Debug.Log("Hello World");
    }
    
}