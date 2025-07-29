using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    w
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Water") { waterCheck =true; }

    }

    // Update is called once per frame
    void Update()
    {          
        _groundcheck = Physics2D.OverlapCapsule(point: feetCollider.position,
       size: new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,0,groundMask);
         
        if (Input.GetKeyDown(KeyCode.Space)&& (_groundcheck||waterCheck))   
             
        {
            _rigidbody2d.velocity = new Vector2(_rigidbody2d.velocity.x, jumpforce);
        }

        if (_rigidbody2d.velocity.y < 0)
        {
            _rigidbody2d.velocity +=  gravityforce * (fallforce * Time.deltaTime);
        }
      

    }   
    
     
           
}

       
         
          
       
