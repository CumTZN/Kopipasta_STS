using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int StartHealth;
    public int CurrentHealth;
    void Start()
    {
        CurrentHealth = StartHealth;
    }

    // Update is called once per frame
    public void TakeDmg(int amount)
    {
        CurrentHealth -= amount;

        if (CurrentHealth <= 0)
        {
            gameObject.SetActive(false);

        }

        
    }
}
