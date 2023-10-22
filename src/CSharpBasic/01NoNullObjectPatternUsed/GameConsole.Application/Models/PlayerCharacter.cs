namespace GameConsole.Application.Models;

public class PlayerCharacter
{
	private readonly ISpecialDefence _specialDefence;

	public string Name { get; set; }
	public int Health { get; private set; } = 100;

	public PlayerCharacter(ISpecialDefence specialDefence)
	{
		_specialDefence = specialDefence;
		Name = string.Empty;
	}

	public void Hit(int damage)
	{
		var damageReduction = _specialDefence.CalculateDamageReduction();

		var totalDamageTaken = Math.Abs(damage - damageReduction);

		Health -= totalDamageTaken;

		Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
	}
}