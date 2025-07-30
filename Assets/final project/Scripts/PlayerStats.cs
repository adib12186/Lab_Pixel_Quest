using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int coinCount = 0;
    public int Health = 3;
    public int maxHealth = 3;
 
     public int CoinsInLevel = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        switch (other.tag)
        {
            
                case "Death": //damage system
                {

                    if (Health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    break;
                }
                case "Coin":
                {
                    coinCount++;
                    
                    Destroy(other.gameObject);
                    break;
                }
            case "Health":
                {
                    if (Health < 3)
                    {
                        Health++;
            
                        Destroy(other.gameObject);
                    }
                    break;
                }
        }
    }
}
