using Terraria.ModLoader;

namespace DD2Expansion
{
	class DD2Expansion : Mod
	{
		public DD2Expansion()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
