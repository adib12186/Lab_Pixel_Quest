using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geocontroller : MonoBehaviour
{
    string variable1 = "hello";
    int var1 = 3;

    
    
    // Start is called before the first frame update
    void Start()
    {
        string var2 = "hi how are you today";
        Debug.Log("Hello world");
        Debug.Log(variable1 + var2);

       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var1++);
        transform.position += new Vector3(0.005f, 0, 0);
    }
}
