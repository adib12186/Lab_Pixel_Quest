using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int coinCount = 0;
    public int Health = 3;
    public int maxHealth = 3;
    private PlayerUIController _PUC;
     public int CoinsInLevel = 0;
    void Start()
    {
        _PUC = GetComponent<PlayerUIController>();
        _PUC.UpdateHealth(Health, maxHealth);
        CoinsInLevel = GameObject.Find("Coins").transform.childCount;
        _PUC.UpdateText(coinCount + "/" + CoinsInLevel);
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
                    Health--;
                    _PUC.UpdateHealth(Health, maxHealth);
                    if (Health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                }
                case "Coin":
                {
                    coinCount++;
                    _PUC.UpdateText(coinCount + "/" + CoinsInLevel);
                    Destroy(other.gameObject);
                    break;
                }
            case "Health":
                {
                    if (Health < 3)
                    {
                        Health++;
                        _PUC.UpdateHealth(Health, maxHealth);
                        Destroy(other.gameObject);
                    }
                    break;
                }
        }
    }
}
