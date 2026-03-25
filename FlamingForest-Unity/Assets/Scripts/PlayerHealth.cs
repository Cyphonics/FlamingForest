using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int StartingHealth = 3;
    private int CurrentHealth;
    private void Awake()
    {
        CurrentHealth = StartingHealth;
    }
    public void ChangeHealth()
    {
        int ChangeAmount = 1;
        CurrentHealth = CurrentHealth - ChangeAmount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, StartingHealth);
        if (CurrentHealth < 1)
        {
        Kill();
        }

    }
    public void Kill()
    {
        Destroy(gameObject);
    }
 
}
