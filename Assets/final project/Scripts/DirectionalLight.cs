using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class DirectionalLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Create a new GameObject 
        GameObject lightGameObject = new GameObject("Directional Light");


        // Add a Light component
        Light lightComp = lightGameObject.AddComponent<Light>();


        // Set light type to Directional 
        lightComp.type = LightType.Directional;



        // Set light color and intensity 
        lightComp.color = Color.white;
        lightComp.intensity = 1f;


        // set rotation 
        lightGameObject.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
