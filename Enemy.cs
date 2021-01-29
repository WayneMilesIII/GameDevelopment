using System;

public class Enemy
{
	private int health;
	private int damage;
	public Enemy()
	{
		health = 2;
		damage = 1;
	}
	public int getDamage()
    {
		return damage;
    }
	public void movement()
    {

    }
	public void loseHealth()
    {
		health = health - 1;
		if (health == 0) death();
    }
	public void death()
    {
		//despawn enemy
    }

}
