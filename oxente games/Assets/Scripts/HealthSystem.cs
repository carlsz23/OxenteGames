using System;

public class HealthSystem
{
    public event EventHandler OnHealthChanged;
    private int health;
    private int maxHealth;

    public HealthSystem(int maxHealth){
      this.maxHealth = maxHealth;
      health = maxHealth;
    }

    public int GetHealth(){
      return health;
    }

    public float GetHealthPercent(){
      return (float)health/maxHealth;
    }

    public void Damage(int dano){
      health -= dano;
      if(health < 0) health = 0;
      if(OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }

}
