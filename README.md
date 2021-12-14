# Subnautica Mod Menu

First time creating a mod for a game. I haven't actually played through Subnautica yet but wanted to get into reverse engineering and this game happeend to be one I wanted to play and seemed quite easy to make mods for. As I play through the game and understand more features within the game, I'll add more features in the mod menu and probably continue creating mods for BZ as well. Although there are cheats built into the game, I'm creating this more for myself understanding different ways to achieve results. 
</br>
</br>
For example, rather than setting `LiveMixin.invincible = true`, I would rather `LiveMixin.health = LiveMixin.maxHealth if LiveMixin.player is Player` where it will only write the maximum health value to current health if the thing taking damage (method that I patched) is of the `Player` class. My reasons behind this are
- It creates a more universal method across many games. Moving `maxHealth` into `health` and `oxygenCapacity` into `oxygenAvailable` are 2 examples of a very similar technique. I have seen this used often in many games as it accounts for the max limits of these values potentially changing such as a characters level up and increases their max health, craft better gear to increase oxygen capacity, etc.
- It's a different way of thinking. Although it may be more complex and someone could simply set `LiveMixin.invincible = true` and there's nothing wrong with that. I even used that initially but I always try to be as universal and consistent as I can with my way of thinking while also keeping an open mind knowing there are **MANY** solutions for each result.
- I like a challenge. When I get bored of something because it's too easy, I'll just end up quitting and moving on. I always like to work on something I haven't done in order to challenge myself and better my skills. Perfect example is with this mod. It took me forever (because I'm dumb) to find out that I had to pass the `__instance` of the `class` of the `method` that I wanted to patch. Once I created infinite health, the other infinite options in v1.0.0 were extremely easy and I decided to start looking at more complicated possibilities such as different modifiers for future features (after I actually play through the game and know what these classes and methods are actually referring to :S)

## 📝 Usage & Requirements

[QModManager v4.3.0+](https://www.nexusmods.com/subnautica/mods/201) </br>
[SMLHelper v2.12.1+](https://www.nexusmods.com/subnautica/mods/113) </br>
[VersionChecker v1.3.1.1+](https://www.nexusmods.com/subnautica/mods/467) (Optional but very useful) </br> 
Extract the folder in the .zip to %SteamInstall%\steamapps\common\Subnautica\QMods </br>


## ✅ Completed

- [x] Infinite Health
- [x] Infinite Oxygen
- [x] Infinite Hunger
- [x] Infinite Thirst


## 🚧 Future Features

- [ ] Unlimited Ammo
- [ ] Inventory Modifiers
- [ ] Plant Growth Modifier
- [ ] Damage Modifier
- [ ] Infinite Vehicle Energy
- [ ] No Resource Cost to Craft

`Note: These definitely won't be the only updates I plan on making, they are only what I can currently think of from what I've been browsing in dnSpy. I literally haven't even gotten 15 minutes into the game before starting to reverse engineer it so I'm not exactly sure what most of the things in the game are. This mod is going to be focused as a cheat menu. I will focus on and create QoL mods once I actually start playing the game and hopefully I can think of some other fun and creative ideas :).`
