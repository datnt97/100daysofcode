using System;
using GameConsole;

var sarah = new PlayerCharacter(new DiamondSkinDefence())
{
	Name = "Sarah"
};
PlayerCharacter amrit = new(new IronBonesDefence())
{
	Name = "Amrit"
};
PlayerCharacter gentry = new(new NullDefence())
{
	Name = "Gentry"
};

sarah.Hit(10);
amrit.Hit(10);
gentry.Hit(10);

_ = Console.ReadLine();
