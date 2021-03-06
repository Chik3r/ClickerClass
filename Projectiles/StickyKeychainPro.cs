using Microsoft.Xna.Framework;
using Terraria;

namespace ClickerClass.Projectiles
{
	public class StickyKeychainPro : ClickerProjectile
	{
		public Vector2 location = Vector2.Zero;

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.projFrames[projectile.type] = 3;
		}

		public override void SetDefaults()
		{
			projectile.width = 72;
			projectile.height = 72;
			projectile.aiStyle = -1;
			projectile.penetrate = -1;
			projectile.timeLeft = 300;
			projectile.friendly = true;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.usesLocalNPCImmunity = true;
			projectile.localNPCHitCooldown = 30;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return new Color(255, 255, 255, 200) * (0.005f * projectile.timeLeft);
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			projectile.frame = (int)projectile.ai[0];

			if (projectile.ai[1] < 1f)
			{
				location = player.Center - projectile.Center;
				projectile.ai[1] += 1f;
			}

			projectile.Center = new Vector2(player.Center.X, player.Center.Y + player.gfxOffY) - location;
		}
	}
}