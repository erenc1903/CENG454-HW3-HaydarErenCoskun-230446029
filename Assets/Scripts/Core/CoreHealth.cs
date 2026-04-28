using UnityEngine;
using System;

public class CoreHealth : MonoBehaviour, IDamageable
{
    public int maxHealth = 100;
    private int currentHealth;

    //OBSERVER EVENT
    public static event Action<int> OnCoreDamaged;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("Core hasar aldı: " + damage);

        // Observer event tetikle
        OnCoreDamaged?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}
