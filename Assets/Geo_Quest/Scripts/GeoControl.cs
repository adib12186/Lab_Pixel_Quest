using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoControl : MonoBehaviour
{

    int Var1 = 3;
    string var1 = "hello";
    // Start is called before the first frame update
    void Start()
    { 
        
        
      Debug.Log("Hello world");
        string var2 = " world";
        Debug.Log (var1 + var2);

    }
    
   
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Var1++);
    }
}
