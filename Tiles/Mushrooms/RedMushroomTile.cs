using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Mushrooms
{
    public class RedMushroomTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("RedMushroom");
            minPick = 20;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Red Mushroom");
            AddMapEntry(new Color(255, 50, 50), name);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.35f;
            g = 0.05f;
            b = 0.05f;
        }
    }
}