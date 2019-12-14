using Terraria.ModLoader;

namespace OldCalamityMusic
{
	public class OldCalamityMusic : Mod
	{
		public OldCalamityMusic()
		{
		}
		public override void Load()
		{
			{
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldCalamitas"), ItemType("CalamitasOldMusicBox"), TileType("CalamitasOldMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AbyssMiniboss"), ItemType("AbyssMinibossMusicBox"), TileType("AbyssMinibossMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldSCal1"), ItemType("SCalOldMusicBox1"), TileType("SCalOldMusicBox1"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldSCal2"), ItemType("SCalOldMusicBox2"), TileType("SCalOldMusicBox2"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldDoG"), ItemType("DoGOldMusicBox"), TileType("DoGOldMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldPolterghast"), ItemType("PolterghastOldMusicBox"), TileType("PolterghastOldMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Planetoid"), ItemType("PlanetoidMusicBox"), TileType("PlanetoidMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Doomsayer"), ItemType("DoomsayerMusicBox"), TileType("DoomsayerMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldPBG"), ItemType("PBGOldMusicBox"), TileType("PBGOldMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OldProvi"), ItemType("ProviOldMusicBox"), TileType("ProviOldMusicBox"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstralSlime"), ItemType("AstralSlimeMusicBox"), TileType("AstralSlimeMusicBox"));
			}
		}
	}
}