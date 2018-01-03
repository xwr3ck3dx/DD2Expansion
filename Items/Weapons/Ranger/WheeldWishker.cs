using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DD2Expansion.Items.Weapons.Ranger
{
	public class WheeldWishker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wheeld Wisker");
			Tooltip.SetDefault("BEST GUN EVER");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 50;
			item.height = 18;
			item.useTime = 4;
			item.useAnimation = 12;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item31;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 11f;
			item.useAmmo= AmmoID.Bullet;
			item.reuseDelay=15;
			item.scale=1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15,0);
		}
		
	}
}
