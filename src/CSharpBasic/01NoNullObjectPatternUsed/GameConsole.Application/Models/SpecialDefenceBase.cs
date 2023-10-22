namespace GameConsole.Application.Models;

public abstract class SpecialDefenceBase : ISpecialDefence
{
	public abstract int CalculateDamageReduction();

	public static SpecialDefenceBase Null { get; } = new NullDefence();

	private class NullDefence : SpecialDefenceBase
	{
		public override int CalculateDamageReduction() => 0;
	}
}
