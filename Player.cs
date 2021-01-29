using System;

public class Player
{
	private int lives;
	private int health;
	public Player()
	{
		lives = 3;
		health = 3;
	}
	
	public void loseHealth(Enemy x)
    {
		health = health - x.getDamage();
		if(health == 0)
        {
			lives = lives - 1;
			health = 3;
        }
		if(lives == 0)
        {
			gameOver();
        }
    }
	public void shoot()
    {

    }
	public void movement()
    {

    }
	public void gameOver()
    {

    }
}
