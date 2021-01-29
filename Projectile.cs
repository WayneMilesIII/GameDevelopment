using System;

public class Projectile
{
	private int cycles;
	private int damageDealt;
	protected final int xOrigin, yOrigin;
	protected double angle;
	protected Sprite sprite;
	protected double nx, ny;
	protected double speed, rateOfFire, range, damage;



	private const int TICKS = 2;

	// damage counter
	public void damageCounter
    {
		damageDealt = health - 1;

    }


	public Projectile(int x, int y, int dir)
	{
		Console.WriteLine("Hi");
		xOrigin = x;
		yOrigin = y;
		angle = dir;

		cycles = 2;
		damageDealt = 1;
	}
}
