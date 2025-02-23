using FFCHS2.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace FFCHS2.FF6ModTranslator
{
	public class FF6ModTranslator
	{
		private class FF6Mod{}
		[ExtendsFromMod("FF6Mod"), JITWhenModsEnabled("FF6Mod")]
		private class TranslatorLoad : ForceLocalizeSystem<FF6Mod, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("FF6Mod",out var mod))
			{
				#region FF6Mod.FF6ModMenu
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.FF6ModMenu", "get_DisplayName", new ()
				{
					{"Final Fantasy: Distant Memories","最终幻想:遥远的记忆"},
				});
				#endregion FF6Mod.FF6ModMenu


				#region FF6Mod.FF6ItemStats
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.FF6ItemStats", "UpdateArmorSet", new ()
				{
					{"\nResists Earth damage","抵抗地属性"},
					{"\nResists Ice damage","抵抗冰属性"},
					{"\nResists Water damage","抵抗水属性"},
					{"\nResists Fire damage","抵抗火属性"},
					{"\nResists Poison damage","抵抗毒属性"},
					{"\nResists Dark damage","抵抗暗属性"},
					{"\nWeak against Fire damage","火属性弱点"},
					{"\nWeak against Ice, resistant to Fire damage","冰属性弱点，抵抗火属性"},
					{"\nWeak against Dark, resistant to Holy damage","暗属性弱点，抵抗圣属性"},
					{"\nResistant to Fire damage.","抵抗火属性"},
					{"\nResistant to Holy and Dark damage","抵抗圣与暗属性"},
					{"\nResistant to Holy and Bolt damage","抵抗圣与电属性"},
					{"\nResistant to Water and Dark damage","抵抗水与暗属性"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.FF6ItemStats", "UpdateStats", new ()
				{
					{"\nDefense: ","防御: "},
					{" \nMelee Damage: +","近战伤害: +"},
					{"\nMelee Crit: +","近战暴击: +"},
					{" \nRanged Damage: +","远程伤害: +"},
					{"\nRanged Crit: +","远程暴击: +"},
					{" \nMagic Damage: +","魔法伤害: +"},
					{"\nMagic Crit: +","魔法暴击: +"},
					{" \nSummon Damage: +","召唤伤害: +"},
					{"\nSummon Crit: +","召唤暴击: +"},
					{" \nThrown Damage: +","投掷伤害: +"},
					{"\nThrown Crit: +","投掷暴击: +"},
					{" \nBlitz Damage: +","必杀技伤害: +"},
					{"\nBlitz Crit: +","必杀技暴击: +"},
					{" \nTools Damage: +","工具伤害: +"},
					{"\nTools Crit: +","工具暴击: +"},
					{" \nBushido Damage: +","必杀剑伤害: +"},
					{"\nBushido Crit: +","必杀剑暴击: +"},
					{" \nWhite Magic Healing: +","白魔法治疗: +"},
					{"\nMelee Speed: +","近战速度: +"},
					{"\nAll Attack Speed: +","攻击速度: +"},
					{"\nMax Mana: +","最大魔力值: +"},
					{"\nMana Reduction: +","魔法减耗: +"},
					{"\nSummon Slots: +","召唤栏: +"},
					{"\nSummon Knockback: +","召唤击退: +"},
					{"\nMovement Speed: +","移速: +"},
					{"\nMax Run Speed: +","最大速度: +"},
					{"\nDodge Chance: +","闪避率: +"},
					{"\nIncreased jump height","增加跳跃高度"},
					{"\nIncreased life regen","增加生命再生"},
					{"\nKnockback Immunity","免疫击退"},
				});
				#endregion FF6Mod.FF6ItemStats


				#region FF6Mod.FF6World
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.FF6World", "DoBossChecklistIntegration", new ()
				{
					{"Odin","奥丁"},
				});
				#endregion FF6Mod.FF6World


				#region FF6Mod.FF6ElementalItem
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.FF6ElementalItem", "ModifyTooltips", new ()
				{
					{"This weapon deals Prism damage.","这个武器造成多属性伤害。"},
					{"This weapon deals","这个武器造成"},
					{" Fire [i:FF6Mod/FireTag]","火[i:FF6Mod/FireTag]"},
					{" Ice [i:FF6Mod/IceTag]","冰[i:FF6Mod/IceTag]"},
					{" Bolt [i:FF6Mod/BoltTag]","电[i:FF6Mod/BoltTag]"},
					{" Water [i:FF6Mod/WaterTag]","水[i:FF6Mod/WaterTag]"},
					{" Earth [i:FF6Mod/EarthTag]","地[i:FF6Mod/EarthTag]"},
					{" Wind [i:FF6Mod/WindTag]","风[i:FF6Mod/WindTag]"},
					{" Holy [i:FF6Mod/HolyTag]","圣[i:FF6Mod/HolyTag]"},
					{" Dark [i:FF6Mod/DarkTag]","暗[i:FF6Mod/DarkTag]"},
					{" Poison [i:FF6Mod/PoisonTag]","毒[i:FF6Mod/PoisonTag]"},
					{" damage.","属性伤害."},
					{" and","和"},
					{"This weapon deals Fire damage. [i:FF6Mod/FireTag]","武器造成火[i:FF6Mod/FireTag]属性伤害"},
					{"This weapon deals Ice damage. [i:FF6Mod/IceTag]","武器造成冰[i:FF6Mod/IceTag]属性伤害"},
					{"This weapon deals Bolt damage. [i:FF6Mod/BoltTag]","武器造成电[i:FF6Mod/BoltTag]属性伤害"},
					{"This weapon deals Water damage. [i:FF6Mod/WaterTag]","武器造成水[i:FF6Mod/WaterTag]属性伤害"},
					{"This weapon deals Earth damage. [i:FF6Mod/EarthTag]","武器造成地[i:FF6Mod/EarthTag]属性伤害"},
					{"This weapon deals Wind damage. [i:FF6Mod/WindTag]","武器造成风[i:FF6Mod/WindTag]属性伤害"},
					{"This weapon deals Holy damage. [i:FF6Mod/HolyTag]","武器造成圣[i:FF6Mod/HolyTag]属性伤害"},
					{"This weapon deals Dark damage. [i:FF6Mod/DarkTag]","武器造成暗[i:FF6Mod/DarkTag]属性伤害"},
					{"This weapon deals Poison damage. [i:FF6Mod/PoisonTag]","武器造成毒[i:FF6Mod/PoisonTag]属性伤害"},
				});
				#endregion FF6Mod.FF6ElementalItem


				#region FF6Mod.FF6JobPlayer
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.FF6JobPlayer", "OnHitByProjectile", new ()
				{
					{"Aero","烈气旋"},
				});
				#endregion FF6Mod.FF6JobPlayer


				#region FF6Mod.UI.StatusUI.StatusUI
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.StatusUI.StatusUI", "OnInitialize", new ()
				{
					{"Lvl: ","等级: "},
					{"EXP: ","经验: "},
					{"HP: ","生命: "},
					{"MP: ","魔力: "},
					{"Job: ","职业: "},
					{"Job Lvl: ","职业等级: "},
					{"AP: ","熟练度: "},
					{"Weakness:","弱点:"},
					{"Resistance:","抵抗:"},
					{"Immunity:","免疫:"},
					{"Absorb:","吸收:"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.StatusUI.StatusUI", "Update", new ()
				{
					{"HP: ","生命: "},
					{"MP: ","魔力: "},
					{"Job: ","职业:"},
					{"Job Lvl: ","职业等级:"},
					{"AP: ","熟练度: "},
					{"Set Bonus: ","套装奖励: "},
				});
				#endregion FF6Mod.UI.StatusUI.StatusUI


				#region FF6Mod.UI.Notifications.ExampleJoinWorldInGameNotification
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.Notifications.ExampleJoinWorldInGameNotification", "DrawInGame", new ()
				{
					{"Here we go","开始吧"},
				});
				#endregion FF6Mod.UI.Notifications.ExampleJoinWorldInGameNotification


				#region FF6Mod.UI.JukeboxUI.JukeboxUI
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.JukeboxUI.JukeboxUI", "OnInitialize", new ()
				{
					{"Pick a song!","选择歌曲"},
					{"Play the selected song, alawys","单曲循环"},
					{"Shuffle songs","随机播放"},
				});
				#endregion FF6Mod.UI.JukeboxUI.JukeboxUI


				#region FF6Mod.UI.JobUI.JobImage
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.JobUI.JobImage", "Draw", new ()
				{
					{" (Locked)","(未解锁)"},
				});
				#endregion FF6Mod.UI.JobUI.JobImage


				#region FF6Mod.UI.JobUI.JobUI
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.JobUI.JobUI", "OnInitialize", new ()
				{
					{"Close","关闭"},
				});
				#endregion FF6Mod.UI.JobUI.JobUI


				#region FF6Mod.UI.JobUI.JobUISystem
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.JobUI.JobUISystem", "SetJobDescriptions", new ()
				{
					{"Locked","未解锁"},
					{"Lvl 2: Locked","等级2：未解锁"},
					{"Lvl 3: Locked","等级3：未解锁"},
					{"Lvl 4: Locked","等级4：未解锁"},
					{"Lvl 1 - Potion Toss (Active): Throw a potion and heal the target","等级1 - 药水投掷(主动技):投掷药水治疗目标"},
					{"Lvl 2 - Pharmacology: Recover 25% more HP when using a potion","等级2 - 药理知识:生命药水治疗量增加25%"},
					{"Lvl 3 - Mix: Gain unique potion crafting recipes","等级3 - 调和:获得特殊药水配方"},
					{"Lvl 4 - Recover: Heal certain debuffs when using a healing potion","等级4 - 治愈:使用治疗药水可以去除一些减益"},
					{"Lvl 1 - Charge Magic (Passive): Can charge up Fire, Ice, and Bolt spells","等级1 - 蓄能魔法(被动技):可以蓄能火冰电魔法"},
					{"Lvl 2 - Improved Charge: Can charge to a second level","等级2 - 强化蓄能:可以蓄能到2阶段"},
					{"Lvl 3 - Enhanced Charge: Can charge to a third level","等级3 - 附魔蓄能:可以蓄能到3阶段"},
					{"Lvl 4 - Super Charge: Can charge to a fourth level","等级4 - 超越蓄能:可以蓄能到4阶段"},
					{"Lvl 1 - Dance (Active): Activate one of four random dances","等级1 - 舞蹈(主动技):随机使出4种舞蹈中的一种"},
					{"Lvl 2 - Flirt: Occasionally lower the nearest enemy's attack with your charm","等级2 - 调情:有几率降低最近的敌人的攻击"},
					{"Lvl 3 - Moonwalk: 15% Faster movement speed","等级3 - 太空步:移动速度增加15%"},
					{"Lvl 4 - Smooth moves: 10% chance to dodge any hit","等级4 - 流畅舞步:有10%几率闪避攻击"},
					{"Lvl 1 - Holy Fire (Passive): The Dia spells ignite all types of enemies","等级1 - 神圣火焰(被动技):天辉类法术能点燃所有敌人"},
					{"Lvl 2 - Shining Aura: You constantly emit light","等级2 - 闪耀光环:你会发出光芒"},
					{"Lvl 3 - Holy Aura: Nearby Undead types burst into flame automatically","等级3 - 神圣光环:附近的的不死生物会开始燃烧"},
					{"Lvl 4 - White Magic Mastery: Deal 25% extra damage with all White Magic","等级4 - 白魔法精通:白魔法伤害额外增加25%"},
					{"Lvl 1 - Gaia (Active): Different effects based on the biome you are in","等级1 - 地形(主动技):根据所处生态环境产生不同效果"},
					{"Lvl 2 - Light Step: 75% less dmg from traps","等级2 - 轻盈步伐:陷阱伤害降低75%"},
					{"Lvl 3 - Ground Sense: Permanent Mining Potion buff","等级3 - 地面感应:永久获得挖矿药水效果"},
					{"Lvl 4 - Ground Sense 2: Permanent Danger Sense buff","等级4 - 地面感应2:永久获得危险感知药水效果"},
					{"Lvl 1 - Guard (Active): Doubles Defense for a short while","等级1 - 守护(主动技):短时间内防御翻倍"},
					{"Lvl 2 - Two-Handed: Increased damage with Broadswords and Spears","等级2 - 双手持:阔剑和长枪伤害增加"},
					{"Lvl 3 - Shield Mastery: Gain an additional +3 Def per shield","等级3 - 盾牌精通:所有盾牌额外获得3防御"},
					{"Lvl 4 - Heavy Armor Mastery: Gain +3 Def extra per Heavy Armor piece worn","等级4 - 重甲精通:所有重甲部件额外获得3防御"},
					{"Lvl 1 - Corpse Explosion: Enemies defeated with Magic explode into bones","等级1 - 尸体爆炸:魔法伤害击杀的敌人爆炸并飞散出骨头"},
					{"Lvl 2 - Raise Archers: Summon skeletons when defeating enemies with Magic","等级2 - 骷髅弓手:魔法伤害击杀敌人时召唤骷髅弓手"},
					{"Lvl 3 - Raise Mages: Summon skeleton archers when defeating enemies with Magic","等级3 - 骷髅法师:魔法伤害击杀敌人时召唤骷髅法师"},
					{"Lvl 4 - Raise Ninjas: Summon skeleton ninjas when defeating enemies with Magic","等级4 - 骷髅忍者:魔法伤害击杀敌人时召唤骷髅忍者"},
					{"Lvl 1 - Level 1 and 2 spells can be cast 15% more quickly","等级1 - 1级与2级法术施法速度增加15%"},
					{"Lvl 2 - Level 1 and 2 spells deal 15% more dmg","等级2 - 1级与2级法术伤害增加15%"},
					{"Lvl 3 - Level 1 and 2 spells cost 15% less mana","等级3 - 1级与2级法术降低15%魔力消耗"},
					{"Lvl 4 - Level 1 and 2 spells have 15% increased crit rate","等级4 - 1级与2级法术暴击率增加15%"},
					{"Lvl 1 - Open Fire (Passive): When shooting a gun, chance to spawn a cannon","等级1 - 开炮(被动技):枪械攻击有几率生成加农炮"},
					{"Lvl 2 - EXP Up: Increase EXP gain by 50%","等级2 - 经验增加:经验获取增加50%"},
					{"Lvl 3 - Salvo: Increased chance to spawn a cannon","等级3 - 齐射:增加加农炮生成几率"},
					{"Lvl 4 - Bombardment: Cannons fire multiple cannonballs","等级4 - 轰炸:加农炮发出多发炮弹"},
					{"Lvl 1 - Dive (Active): Dive down and bounce off of an enemy","等级1 - 龙冲(主动技):俯冲攻击敌人并弹开"},
					{"Lvl 2 - Aeriel Manuevers: Increased jump height, no fall damage","等级2 - 空中机动:增加跳跃高度，免疫摔落伤害"},
					{"Lvl 3 - Spear Mastery: Deal increased damage with Spears","等级3 - 长枪精通:长枪伤害增加"},
					{"Lvl 4 - Lance: Dive will restore HP and Mana","等级4 - 龙枪:龙冲可以恢复生命与魔力"},
					{"Lvl 1 - Charge Magic (Passive): Can charge up Wind, Water, and Earth spells","等级1 - 蓄能魔法(被动技):可以蓄能风水地魔法"},
					{"Lvl 1 - Focus Blast (Active): Destroy projectiles and buff melee dmg","等级1 - 气合(主动技):摧毁射弹并增强近战伤害"},
					{"Lvl 2 - Chakra: Gain immunity to poison and blind","等级2 - 脉轮:免疫中毒与黑暗减益"},
					{"Lvl 3 - Vitality: Gain 10% additional Damage Resist","等级3 - 生命力:额外获得10%伤害减免"},
					{"Lvl 4 - Iron Hands: Deal more Claw / Fist damage","等级4 - 铁拳:拳/爪造成更多伤害"},
					{"Lvl 1 - Improves damage done with Spellblades","等级1 - 增加魔法剑的伤害"},
					{"Lvl 2 - Spellblades increase 1 level; Improves dmg","等级2 - 魔法剑提升1级;增加伤害"},
					{"Lvl 3 - Spellblades increase 2 levels; Improves dmg","等级3 - 魔法剑提升2级;增加伤害"},
					{"Lvl 4 - Spellblades increase 3 levels; Improves dmg","等级4 - 魔法剑提升3级;增加伤害"},
					{"Lvl 1 - Gil Toss (Active): Attack enemies by throwing money","等级1 - 投钱(主动技):扔钱攻击敌人"},
					{"Lvl 2 - Shirahadori: Chance to counter when hit","等级2 - 空手接白刃:有几率反击攻击"},
					{"Lvl 3 - Mineuchi: Chance to stun when attacking with a katana","等级3 - 刀背打:武士刀有几率晕眩敌人"},
					{"Lvl 4 - Katana Master: Deal extra damage with a Katana","等级4 - 武士刀精通:武士刀造成额外伤害"},
					{"Lvl 1 - Haste: Chance to gain Haste when hitting an enemy with Magic","等级1 - 加速:魔法攻击敌人有几率让自己加速"},
					{"Lvl 2 - Slow: Chance for Magic to inflict Slow on an enemy","等级2 - 缓慢:魔法伤害有几率让敌人缓慢"},
					{"Lvl 3 - Time Mastery: Chances of Haste and Slow increased","等级3 - 时魔法精通:加速和缓慢几率增加"},
					{"Lvl 4 - Equip Rods: Deal extra Dmg with Rods","等级4 - 节杖装备:节杖造成额外伤害"},
					{"Lvl 1 - Provoke (Active): Increase aggro, decrease enemy Def","等级1 - 挑衅(主动技):增加仇恨，降低敌人防御"},
					{"Lvl 2 - Spear Mastery: Deal 25% more damage with Spears","等级2 - 长枪精通:长枪伤害额外增加25%"},
					{"Lvl 3 - Flail Mastery: Deal 25% more damage with Flails","等级3 - 连枷精通:连枷伤害额外增加25%"},
					{"Lvl 1 - Sing (Active): Perform a song to support allies or inflict enemy targets.","等级1 - 歌唱(主动技):用歌声支援队友或妨碍敌人"},
					{"Lvl 2 - Hide: Singing makes you a less target to enemies for a short period of time.","等级2 - 躲藏:唱歌会让敌人不太容易以你为目标"},
					{"Lvl 3 - Advanced Music: Unlocked Hero Song and Requiem Song.","等级3 - 进阶歌曲:解锁英雄之歌和安魂曲"},
					{"Lvl 4 - Forbidden Music: Unlocked Love Song and Charm Song","等级4 - 禁制歌曲:解锁爱之歌和诱惑之歌"},
					{"Lvl 1 - Blue Magic (Active): Can learn and cast Blue Magic","等级1 - 青魔法(主动技):可以学习和施放青魔法"},
					{"Lvl 2 - Check: Weakness icons shown below enemy","等级2 - 识破:敌人下方会标记弱点"},
					{"Lvl 3 - Analyze: Enemy type shown below enemy","等级3 - 调查: 敌人下方会标记类型"},
					{"Lvl 4 - Mastery: Blue Magic deals extra dmg if hitting weakness","等级4 - 弱点精通:青魔法对弱点敌人造成额外伤害"},
					{"Lvl 1 - Evoke (Active): Summon a random Eidolon or Esper","等级1 - 呼出(主动技):随机召唤幻兽与幻魔"},
					{"Lvl 2 - Strengthen: Evoked summons deal more dmg","等级2 - 强化:呼出的召唤物伤害增加"},
					{"Lvl 3 - Attunement: Lowers cooldown time for Evoke","等级3 - 协调:降低呼出冷却"},
					{"Lvl 4 - Chaos Evoke: Chance for cooldown time to be 0","等级4 - 混沌呼出:有几率不需要冷却"},
					{"Lvl 1 - Cataclysm (Active): Cause a random catastrophic event to occur","等级1 - 灾难(主动技):随机造成一场灾难"},
					{"Lvl 2 - Condemn: Chance for Magic to inflict the condemn status on enemies","等级2 - 宣告:魔法伤害有几率造成死之宣告"},
					{"Lvl 3 - Predict: Cataclysm's effects are enhanced","等级3 - 预言:灾难效果提升"},
					{"Lvl 4 - Foretell: Every 30 seconds, gain the Shadow Dodge buff","等级4 - 预知:每30秒触发一次暗影闪避"},
					{"Lvl 1 - Animal Helper (Active): Summon an animal friend to assist","等级1 - 动物伙伴(主动技):召唤动物伙伴辅助你"},
					{"Lvl 2 - Bow Mastery: Deal 15% more dmg with bows and repeaters","等级2 - 弓精通:弓与连弩伤害额外增加15%"},
					{"Lvl 3 - Aim: +10% crit chance with bows and repeaters","等级3 - 精准: 弓与连弩暴击率增加10%"},
					{"Lvl 4 - Spread Shot: Fire additional arrows","等级4 - 乱射:射出额外箭矢"},
					{"Lvl 1 - Adept (Passive): Hitting enemies with a whip lowers Summon CD","等级1 - 熟手(被动技):鞭子命中敌人降低召唤冷却"},
					{"Lvl 2 - Attuned: Lesser Summons become stronger","等级2 - 协作:初级召唤物变得更强"},
					{"Lvl 3 - Advanced: Mid Level Summons become stronger","等级3 - 进阶:中级召唤物变得更强"},
					{"Lvl 4 - Master: All Summons become stronger","等级4 - 掌控:所有召唤物变得更强"},
					{"Lvl 1 - Steal (Passive): When attacking with a dagger, chance to obtain loot","等级1 - 偷窃(被动技):用匕首攻击有几率获得物品"},
					{"Lvl 2 - Sprint: Increase movement and running speed","等级2 - 冲刺:增加移速与跑步速度"},
					{"Lvl 3 - Mug: Deal extra damage when using steal","等级3 - 掠夺:偷窃伤害增加"},
					{"Lvl 4 - Artful Dodger: Gain the Shadow Dodge buff every 30 seconds","等级4 - 狡猾闪躲:每30秒触发一次暗影闪避"},
					{"Lvl 1 - Cure (Active): Heal the target at the mouse cursor","等级1 - 治疗(主动技):治疗光标处的目标"},
					{"Lvl 2 - Magic Training: Max Mana + 20%","等级2 - 魔法训练:最大魔力+20%"},
					{"Lvl 3 - Holy Aura: Take 25% less dmg from Undead npcs","等级3 - 神圣光环:不死生物伤害降低25%"},
					{"Lvl 1 - Control: Can have one additional minion","等级1 - 控制:最大仆从数+1"},
					{"Lvl 2 - Whip Mastery: Deal extra damage with Whips and Minions","等级2 - 鞭精通:鞭与仆从造成额外伤害"},
					{"Lvl 3 - Greater Control: Can have one additional minion","等级3 - 强力控制:最大仆从数+1"},
					{"Lvl 4 - Catch: Greater chance to obtain Minion summoning drops from NPCs","等级4 - 捕获:更容易获得仆从召唤物"},
					{"Lvl 1 - Berserk (Passive): Increase Melee offense, decrease Def","等级1 - 狂暴(被动技):增强近战攻击，降低防御"},
					{"Lvl 2 - Rage: When attacking, gain a stacking atk speed buff","等级2 - 愤怒:攻击时堆叠攻击速度"},
					{"Lvl 3 - Fury: When attacking, gain a stacking move speed buff","等级3 - 狂怒:攻击时堆叠移动速度"},
					{"Lvl 4 - Axe Master: +50% crit rate with Axes","等级4 - 斧精通:斧暴击率+50%"},
					{"Lvl 1 - Darkness (Active): Buff Melee Dmg, lose HP over time","等级1 - 暗黑(主动技):增加近战伤害，随时间降低生命值"},
					{"Lvl 2 - Drain Blade: Defeating an enemy with Darkness restores some HP","等级2 - 吸收剑:暗黑状态击杀敌人回复生命值"},
					{"Lvl 3 - Blade Blitz: Hitting an enemy also strikes nearby enemies","等级3 - 全体斩:命中敌人也会伤害附近的敌人"},
					{"Lvl 4 - Soul Eater: Extra Melee Dmg the lower your life is","等级4 - 噬魂:生命值越低，近战伤害越高"},
					{"Lvl 1 - Finisher (Active): A single, powerful strike","等级1 - 必杀(主动技):强力一击"},
					{"Lvl 2 - Lure: Increase enemy aggro towards yourself","等级2 - 引敌:增加敌人仇恨"},
					{"Lvl 3 - Long Reach: Melee weapons have longer range","等级3 - 后列斩:近战武器距离增加"},
					{"Lvl 4 - Underdog: Increase melee dmg based on the # of enemies around","等级4 - 败犬:根据附近敌人数增加近战伤害"},
					{"Lvl 1 - Throw (Active): Throws the currently selected item","等级1 - 投掷(主动技):投掷手持的物品"},
					{"Lvl 2 - Smoke: When hit, chance to confuse enemies and gain Shadow Dodge","等级2 - 烟雾弹:受到攻击有几率获得暗影闪避并迷惑敌人"},
					{"Lvl 3 - Image: May gain Shadow Dodge when killing enemies with Throw","等级3 - 影分身:通过投掷击杀敌人可以获得暗影闪避"},
					{"Lvl 4 - First Strike: Deal 25% more damage to enemies with full HP","等级4 - 先制攻击: 对满血敌人造成25%额外伤害"},
					{"Lvl 1 - Recovery(Active): Create a cloud of energy to remove debuffs","等级1 - 恢复(主动技):制造移除减益的活力云"},
					{"Lvl 2 - Immunity: Immune to Poison, Darkness, and Confusion debuffs","等级2 - 免疫:免疫中毒,黑暗,困惑状态"},
					{"Lvl 3 - Morph Immunity: Immune to Imp, Pig, Mini debuffs","等级3 - 变形免疫:免疫河童,猪变,小人状态"},
					{"Lvl 1 - Dark Focus (Active): Buff Magic Dmg, lose HP over time","等级1 - 黑暗集中(主动技):增强魔法伤害，随时间降低生命值"},
					{"Lvl 2 - Drainer: Defeating an enemy with Dark Focus active restores HP","等级2 - 吸血: 黑暗集中状态击杀敌人回复生命值"},
					{"Lvl 3 - Soul Drain: Defeating an enemy with Dark Focus active restores Mana","等级3 - 灵魂吸取:黑暗集中状态击杀敌人回复魔力值"},
					{"Lvl 4 - Battle Mage: Extra Magic Dmg the lower your life is","等级4 - 战斗法师:生命值越低，魔法伤害越高"},
				});
				#endregion FF6Mod.UI.JobUI.JobUISystem


				#region FF6Mod.UI.EXP.APFrame
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.EXP.APFrame", "Update", new ()
				{
					{"AP: Max","熟练度: 满"},
					{"AP: ","熟练度: "},
				});
				#endregion FF6Mod.UI.EXP.APFrame


				#region FF6Mod.UI.EXP.EXPFrame
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.EXP.EXPFrame", "Update", new ()
				{
					{"EXP: ","经验："},
					{"Lvl: ","等级："},
				});
				#endregion FF6Mod.UI.EXP.EXPFrame


				#region FF6Mod.UI.CurrentSong.CurrentSongUI
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.UI.CurrentSong.CurrentSongUI", "Update", new ()
				{
					{"Current Song: ","曲子: "},
				});
				#endregion FF6Mod.UI.CurrentSong.CurrentSongUI


				#region FF6Mod.Mechanics.SkillSystem.SkillSelectUI
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.SkillSelectUI", "OnInitialize", new ()
				{
					{"Select a Skill","选择技能"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.SkillSelectUI", "SetSkill", new ()
				{
					{"You haven't unlocked that skill!","该技能还没有学会!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.SkillSelectUI", "GetSkillDescription", new ()
				{
					{"No skill selected.","未选择技能"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.SkillSelectUI


				#region FF6Mod.Mechanics.SkillSystem.SkillUITab
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.SkillUITab", "OnInitialize", new ()
				{
					{"Blue Magic","青魔法"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.SkillUITab


				#region FF6Mod.Mechanics.SkillSystem.Skills.BioSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.BioSkill", "get_Description", new ()
				{
					{"Spawns many tornadoes","生成大量旋风"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.BioSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.CondemnedSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.CondemnedSkill", "get_DisplayName", new ()
				{
					{"Condemned","死之宣告"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.CondemnedSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.DragonsClawSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.DragonsClawSkill", "get_DisplayName", new ()
				{
					{"Dragon's Claw","龙之爪"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.DragonsClawSkill", "get_Description", new ()
				{
					{"10 Mana, close range melee strike","消耗10魔力,近距离近战攻击"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.DragonsClawSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.MindBlastSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.MindBlastSkill", "get_DisplayName", new ()
				{
					{"Mind Blast","精神冲击"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.MindBlastSkill", "get_Description", new ()
				{
					{"15 Mana, inflicts Slow on target","消耗15魔力,对目标造成缓慢"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.MindBlastSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.MissileSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.MissileSkill", "get_DisplayName", new ()
				{
					{"Missile","导弹"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.MissileSkill", "get_Description", new ()
				{
					{"15 Mana; Fires a missle towards the cursor","消耗15魔力;向光标发出导弹"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.MissileSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.SelfDestructSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.SelfDestructSkill", "get_DisplayName", new ()
				{
					{"SelfDestruct","自爆"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.SelfDestructSkill", "get_Description", new ()
				{
					{"10 Mana; Deals damage in exchange for life","消耗10魔力;消耗生命造成伤害"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.SelfDestructSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.StoneSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.StoneSkill", "get_DisplayName", new ()
				{
					{"Stone","飞石"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.StoneSkill", "get_Description", new ()
				{
					{"10 Mana; Can confuse players in PVP","消耗10魔力;可以在PVP中困惑其他玩家"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.StoneSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.ThousandNeedlesSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.ThousandNeedlesSkill", "get_DisplayName", new ()
				{
					{"Thousand Needles","千针刺"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.ThousandNeedlesSkill", "get_Description", new ()
				{
					{"100 Mana; Deals a fixed amount of damage","消耗100魔力; 造成固定伤害值"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.ThousandNeedlesSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.TsunamiSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.TsunamiSkill", "get_DisplayName", new ()
				{
					{"Tsunami","海啸"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.TsunamiSkill", "get_Description", new ()
				{
					{"35 Mana; Spawns a fast moving wave of water","消耗35魔力; 生成快速移动的水潮"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.TsunamiSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.FFMQ.BenjaminSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.FFMQ.BenjaminSkill", "get_DisplayName", new ()
				{
					{"Kain","汉化文本"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.FFMQ.BenjaminSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.Jobs.AlchemistSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.Jobs.AlchemistSkill", "Activate", new ()
				{
					{"No potions in Inventory!","没有药水可用!"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.Jobs.AlchemistSkill


				#region FF6Mod.Mechanics.SkillSystem.Skills.Jobs.BardState
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.Jobs.BardState", "GetSongString", new ()
				{
					{"Power","力量之歌"},
					{"Magic","魔力之歌"},
					{"Speed","敏捷之歌"},
					{"Vitality","生命之歌"},
					{"Hero","英雄之歌"},
					{"Requiem","安魂曲"},
					{"Love","爱之歌"},
					{"Charm","诱惑之歌"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.Jobs.BardState", "GetSongDescription", new ()
				{
					{"Increases melee damage","增加近战伤害"},
					{"Regenerates MP","恢复魔力"},
					{"Increases movement speed","增加移速"},
					{"Regenerates HP","恢复生命"},
					{"Temporarily raises level by 10","暂时提升10级"},
					{"Deals damage to undead","对不死生物造成伤害"},
					{"Decreases movement speed","降低移速"},
					{"Inflicts Muddle","造成混乱状态"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.Jobs.BardState


				#region FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Dancer
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Dancer", "Activate", new ()
				{
					{"Tempting Tango","诱惑探戈"},
					{"Jitterbug Duet","双人吉特巴"},
					{"Mystery Waltz","神秘华尔兹"},
					{"Sword Dance","剑舞"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Dancer


				#region FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Illusionist
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Illusionist", "Activate", new ()
				{
					{"Bismarck!","俾斯麦!"},
					{"Fat Chocobo!","肥陆行鸟!"},
					{"Ramuh!","拉姆!"},
					{"Ifrit!","伊弗利特!"},
					{"Shiva!","希瓦!"},
					{"Odin!","奥丁!"},
					{"Mist Dragon!","雾龙!"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Illusionist


				#region FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Oracle
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Oracle", "Activate", new ()
				{
					{"Cast","蛙变!"},
					{"Stun!","晕眩!"},
					{"Cleansing!","天崩地裂!"},
					{"Deluge!","大洪水!"},
					{"Starfall!","陨星!"},
					{"Divine Judgment!","神圣审判!"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.Jobs.Oracle


				#region FF6Mod.Mechanics.SkillSystem.Skills.FF4.KainSkill
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Mechanics.SkillSystem.Skills.FF4.KainSkill", "get_DisplayName", new ()
				{
					{"Kain","汉化文本"},
				});
				#endregion FF6Mod.Mechanics.SkillSystem.Skills.FF4.KainSkill


				#region FF6Mod.Items.Clothing.FFMQ.BenjaminBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FFMQ.BenjaminBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Dragon Claw \nA Grappling Hook that can also damage enemies","\n主动技能:龙爪\n一个可以伤害敌人的钩爪"},
				});
				#endregion FF6Mod.Items.Clothing.FFMQ.BenjaminBody


				#region FF6Mod.Items.Clothing.FFMQ.KaeliBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FFMQ.KaeliBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Giant's Axe \nInstantly fell a tree","\n主动技能:巨人之斧\n立刻砍倒一棵树"},
				});
				#endregion FF6Mod.Items.Clothing.FFMQ.KaeliBody


				#region FF6Mod.Items.Clothing.FFMQ.ReubenBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FFMQ.ReubenBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Resistance to Fire damage \n+10% Damage with Flail type weapons","\n被动技能:抵抗火焰伤害\n连枷增加10%伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FFMQ.ReubenBody


				#region FF6Mod.Items.Clothing.FF6.CelesBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.CelesBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Runic \nAbsorb one magic attack and regain Mana","主动技能:魔封剑\n将下一个命中你的射弹转化为魔力值"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.CelesBody


				#region FF6Mod.Items.Clothing.FF6.CelesDissidiaBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.CelesDissidiaBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Runic \nAbsorb one magic attack and regain Mana","主动技能:魔封剑\n将下一个命中你的射弹转化为魔力值"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.CelesDissidiaBody


				#region FF6Mod.Items.Clothing.FF6.CelesOperaBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.CelesOperaBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Runic \nAbsorb one magic attack and regain Mana","主动技能:魔封剑\n将下一个命中你的射弹转化为魔力值"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.CelesOperaBody


				#region FF6Mod.Items.Clothing.FF6.CyanBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.CyanBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Bushido\nPress the skill button to start charging \nPress it again to unleash the selected technique \nGain additional Bushido techniques by leveling up","\n主动技能:必杀剑\n按下技能按键积蓄剑技条\n再次按下技能按键释放必杀剑\n随等级提升习得新的必杀剑"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.CyanBody


				#region FF6Mod.Items.Clothing.FF6.EdgarBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.EdgarBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Engineering Maniac \n20% attack speed boost for all Tools[i:FF6Mod/ToolsTag] \nAutocrossbow has a chance to not consume arrows","主动技能:工程师狂热\n所有工具[i:FF6Mod/ToolsTag]攻速增加20%\n自动弩有几率不消耗弹药"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.EdgarBody


				#region FF6Mod.Items.Clothing.FF6.ImperialCadetBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.ImperialCadetBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Increases damage with the Magitek Armor's weapons","\n被动技能:魔导装甲武器的伤害增加"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.ImperialCadetBody


				#region FF6Mod.Items.Clothing.FF6.ImperialCorporalBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.ImperialCorporalBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Increases damage with the Magitek Armor's weapons","\n被动技能:魔导装甲武器的伤害增加"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.ImperialCorporalBody


				#region FF6Mod.Items.Clothing.FF6.ImperialSergeantBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.ImperialSergeantBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Increases damage with the Magitek Armor's weapons","\n被动技能:魔导装甲武器的伤害增加"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.ImperialSergeantBody


				#region FF6Mod.Items.Clothing.FF6.ImperialSoldierBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.ImperialSoldierBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Increases damage with the Magitek Armor's weapons","\n被动技能:魔导装甲武器的伤害增加"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.ImperialSoldierBody


				#region FF6Mod.Items.Clothing.FF6.MerchantBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.MerchantBody", "UpdateArmorSet", new ()
				{
					{"Discount at shops \nIncreased coin pickup range","商店折扣\n增加钱币拾取范围"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.MerchantBody


				#region FF6Mod.Items.Clothing.FF6.SabinBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.SabinBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Focused Blitz \nBlitz skills gain 20% attack and crit rate for a short time","\n主动技能:必杀技集气\n短时间内增加20%必杀技伤害和暴击率"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.SabinBody


				#region FF6Mod.Items.Clothing.FF6.SetzerBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.SetzerBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Slots \nPlay the slots, random effect based on outcome!","\n主动技能:老虎机\n玩老虎机造成随机效果!"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.SetzerBody


				#region FF6Mod.Items.Clothing.FF6.ShadowBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.ShadowBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Throw - Throws currently held item","\n主动技能:投掷手持的物品"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.ShadowBody


				#region FF6Mod.Items.Clothing.FF6.TerraBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.TerraBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Morph \nGain 20% boost to Magic and Summon damage, and movement","\n主动技能:变身\n提升20%魔法与召唤伤害和移速"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.TerraBody


				#region FF6Mod.Items.Clothing.FF6.TerraDissidiaBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.TerraDissidiaBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Morph \nGain 20% boost to Magic and Summon damage, and movement","\n主动技能:变身\n提升20%魔法与召唤伤害和移速"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.TerraDissidiaBody


				#region FF6Mod.Items.Clothing.FF6.UmaroBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.UmaroBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Resistance to Ice damage","\n被动技能:抵抗冰属性伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.UmaroBody


				#region FF6Mod.Items.Clothing.FF6.VargasBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF6.VargasBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Blitz Madness \nGives all Blitz skills a 100% Crit Rate for 30 seconds \nReduces your life to half of it's current amount","\n主动技能:必杀技狂热\n30秒内必杀技必定暴击\n将你的现有生命值减半"},
				});
				#endregion FF6Mod.Items.Clothing.FF6.VargasBody


				#region FF6Mod.Items.Clothing.FF4.CidFF4Body
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF4.CidFF4Body", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Enables use of Scan \nPassive Skill: +15% damage against Machine type enemies","\n主动技能:侦测\n被动技能:对机械敌人+15%伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF4.CidFF4Body


				#region FF6Mod.Items.Clothing.FF4.DCecilBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF4.DCecilBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Darkness \nFires dark energy, costs 8% of HP to use \nDamage based on currently held Melee weapon \nExtra damage if holding a Broadsword[i:FF6Mod/BSwordTag]","\n主动技能:暗黑波动\n消耗8%生命值发射黑暗能量\n伤害由手持的近战武器决定\n手持阔剑[i:FF6Mod/BSwordTag]时造成额外伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF4.DCecilBody


				#region FF6Mod.Items.Clothing.FF4.EdgeBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF4.EdgeBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Throw - Throws currently held item","\n主动技能:投掷手持的物品"},
				});
				#endregion FF6Mod.Items.Clothing.FF4.EdgeBody


				#region FF6Mod.Items.Clothing.FF4.KainBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF4.KainBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Dragoon Dive \nDive into an enemy \nDamage based on currently held Melee weapon \nDeals extra damage if using a Spear[i:FF6Mod/SpearTag]","\n主动技能:龙冲\n俯冲攻击敌人后弹开\n伤害由手持的近战武器决定\n手持长枪[i:FF6Mod/SpearTag]时造成额外伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF4.KainBody


				#region FF6Mod.Items.Clothing.FF4.RosaBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF4.RosaBody", "UpdateArmorSet", new ()
				{
					{"\nActive Skill: Aim \nNext Ranged attack has a 100% crit chance","\n主动技能:瞄准 \n下次远程攻击必定暴击"},
				});
				#endregion FF6Mod.Items.Clothing.FF4.RosaBody


				#region FF6Mod.Items.Clothing.FF4.RydiaBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF4.RydiaBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: Reduced cooldown for all Espers and Eidolons","\n被动技能:减少幻兽和幻魔的召唤冷却"},
				});
				#endregion FF6Mod.Items.Clothing.FF4.RydiaBody


				#region FF6Mod.Items.Clothing.FF3.LunethBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF3.LunethBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: +15% Melee Damage with Broadswords[i:FF6Mod/BSwordTag] \n-15% Damage with all other weapons","\n被动技能:阔剑[i:FF6Mod/BSwordTag]+15%近战伤害 \n其他武器-15%伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF3.LunethBody


				#region FF6Mod.Items.Clothing.FF2.FirionBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF2.FirionBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: +5% Melee Speed with Broadswords[i:FF6Mod/BSwordTag] \n+5% Melee Crit with Shortswords[i:FF6Mod/SSwordTag] \n+5% Melee Damage with Spears[i:FF6Mod/SpearTag]","\n被动技能:阔剑[i:FF6Mod/BSwordTag]+5%近战攻速 \n小刀[i:FF6Mod/SSwordTag]+5%近战暴击\n长枪[i:FF6Mod/SpearTag]+5%近战伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF2.FirionBody


				#region FF6Mod.Items.Clothing.FF15.FishingNoctisBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF15.FishingNoctisBody", "UpdateArmorSet", new ()
				{
					{"Raises Fishing Level by +15","渔力等级+15"},
				});
				#endregion FF6Mod.Items.Clothing.FF15.FishingNoctisBody


				#region FF6Mod.Items.Clothing.FF1.WarriorOfLightBody
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Clothing.FF1.WarriorOfLightBody", "UpdateArmorSet", new ()
				{
					{"\nPassive Skill: All Broadswords[i:FF6Mod/BSwordTag] without an Element will deal Holy damage","被动技能:所有无属性阔剑[i:FF6Mod/BSwordTag]造成圣属性伤害"},
				});
				#endregion FF6Mod.Items.Clothing.FF1.WarriorOfLightBody


				#region FF6Mod.Items.Consumables.ImperialAirForceInvasion
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Consumables.ImperialAirForceInvasion", "CanUseItem", new ()
				{
					{"The event has already started!","入侵正在进行!"},
					{"Need to use this on a Sky Island","需要在空岛使用"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Consumables.ImperialAirForceInvasion", "UseItem", new ()
				{
				});
				#endregion FF6Mod.Items.Consumables.ImperialAirForceInvasion


				#region FF6Mod.Items.Consumables.ImperialInvasion
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Consumables.ImperialInvasion", "CanUseItem", new ()
				{
					{"The event has already started!","入侵正在进行!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Items.Consumables.ImperialInvasion", "UseItem", new ()
				{
				});
				#endregion FF6Mod.Items.Consumables.ImperialInvasion


				#region FF6Mod.Projectiles.Tools.DebilitatorTarget
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Projectiles.Tools.DebilitatorTarget", "OnHitNPC", new ()
				{
					{"Failed, ","失败,"},
					{" is immune or resistant to all elements","对所有属性抵抗或免疫"},
					{" is now weak to Fire","获得火弱点"},
					{" is now weak to Ice","获得冰弱点"},
					{" is now weak to Bolt","获得电弱点"},
					{" is now weak to Water","获得水弱点"},
					{" is now weak to Wind","获得风弱点"},
					{" is now weak to Earth","获得地弱点"},
					{" is now weak to Holy","获得圣弱点"},
					{" is now weak to Dark","获得暗弱点"},
					{" is now weak to Poison","获得毒弱点"},
				});
				#endregion FF6Mod.Projectiles.Tools.DebilitatorTarget


				#region FF6Mod.Projectiles.Spells.GreyMagic.ScanProj
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.Projectiles.Spells.GreyMagic.ScanProj", "ModifyHitNPC", new ()
				{
					{" is","属于"},
					{" Undead","不死生物"},
					{" Beast","野兽"},
					{" Flying","飞行生物"},
					{" Dragon","龙"},
					{" Fiend","妖魔"},
					{" Humanoid","人类"},
					{" Machine","机械"},
					{" Plant","植物"},
					{" Flan","凝胶生物"},
					{" Giant","巨人"},
					{" Aquatic","水生生物"},
					{" Magical","魔法生物"},
					{" Insect","昆虫"},
					{" Goblin","哥布林"},
					{" Type.","类型。"},
					{" and","和"},
					{" is weak against","的弱点为"},
					{" Fire","火"},
					{" Ice","冰"},
					{" Water","水"},
					{" Bolt","电"},
					{" Earth","地"},
					{" Wind","风"},
					{" Holy","圣"},
					{" Dark","暗"},
					{" Poison","毒"},
					{" is resistant to","抵抗"},
					{" is immune to","免疫"},
					{" will absorb","吸收"},
					{" has no weaknesses or resistances.","没有弱点与抵抗属性"},
				});
				#endregion FF6Mod.Projectiles.Spells.GreyMagic.ScanProj


				#region FF6Mod.NPCs.Researcher
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Researcher", "SetChatButtons", new ()
				{
					{"Espers","幻兽"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Researcher", "GetChat", new ()
				{
					{"When Vector was destroyed, I ran off with all the magicite.  Want to buy some?","贝克塔被摧毁时,我带着所有魔石逃了出来。要买点吗?"},
					{"Ever feel like too many people are named Cid?  No?","叫西德的人很多?不是吗?"},
					{"My yellow banana outfit indiciates that I am the highest ranked researcher in the lab.","我的黄色大香蕉服装是最高级研究员的证明"},
					{"You seem to have a talent for magic.  Care to buy any magicite?","你看起来有魔法天赋，要买点魔石吗?"},
				});
				#endregion FF6Mod.NPCs.Researcher


				#region FF6Mod.NPCs.ImperialDefector
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.ImperialDefector", "SetChatButtons", new ()
				{
					{"Skills","技能"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.ImperialDefector", "GetChat", new ()
				{
					{"Hard to believe an Esper's been found intact here, 1000 years after the War of the Magi...","很难相信魔大战一千年后还能在这里发现完好无损的幻兽..."},
					{"Do you recall hearing about a monster that eats lightning?","你听说过吃雷的怪兽吗?"},
					{"Do you know where I can park my Magitek Armor for free? The merchant wants me to pay for parking.","你知道在哪里能免费停魔导装甲吗?商人说停放装甲要收费。"},
					{"Living here is way better than serving in the army, I don't want to fight monsters anymore.","住在这里比为军队卖命好多了，我不想再和怪兽作战了。"},
				});
				#endregion FF6Mod.NPCs.ImperialDefector


				#region FF6Mod.NPCs.Shopkeep
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Shopkeep", "SetChatButtons", new ()
				{
					{"Boss Items","BOSS召唤物"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Shopkeep", "GetChat", new ()
				{
					{"Have you unlocked any jobs yet?","你已经解锁职业了吗?"},
					{"Did you know that some Character Outfits have skills in addition to their stats?","你知道有些角色套装除了属性还有特殊技能吗?"},
					{"Have you ever travelled to Zozo?  Nice people, there.","你去过左左镇吗?那里的人还不错。"},
					{"Do you prefer calling it Fire 3 or Firaga?","你更喜欢叫爆炎还是高级烈火?"},
				});
				#endregion FF6Mod.NPCs.Shopkeep


				#region FF6Mod.NPCs.Enemies.Desert.Cactuar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Enemies.Desert.Cactuar", "AI", new ()
				{
					{"Bundling up something...","开始聚集..."},
				});
				#endregion FF6Mod.NPCs.Enemies.Desert.Cactuar


				#region FF6Mod.NPCs.Enemies.Desert.Gigantuar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Enemies.Desert.Gigantuar", "AI", new ()
				{
					{"Bundling up something...","开始聚集..."},
					{"Bundling up something big!!!","开始大量聚集!!!"},
				});
				#endregion FF6Mod.NPCs.Enemies.Desert.Gigantuar


				#region FF6Mod.NPCs.Enemies.Desert.Jumbotuar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Enemies.Desert.Jumbotuar", "AI", new ()
				{
					{"Bundling up something...","开始聚集..."},
				});
				#endregion FF6Mod.NPCs.Enemies.Desert.Jumbotuar


				#region FF6Mod.NPCs.Enemies.Desert.MetalCactuar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Enemies.Desert.MetalCactuar", "AI", new ()
				{
					{"Bundling up something...","开始聚集..."},
				});
				#endregion FF6Mod.NPCs.Enemies.Desert.MetalCactuar


				#region FF6Mod.NPCs.Enemies.Desert.MetalGigantuar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Enemies.Desert.MetalGigantuar", "AI", new ()
				{
					{"Bundling up something...","开始聚集..."},
					{"Bundling up something big!!!","开始大量聚集!!!"},
				});
				#endregion FF6Mod.NPCs.Enemies.Desert.MetalGigantuar


				#region FF6Mod.NPCs.Enemies.Desert.MetalJumbotuar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Enemies.Desert.MetalJumbotuar", "AI", new ()
				{
					{"Bundling up something...","开始聚集..."},
				});
				#endregion FF6Mod.NPCs.Enemies.Desert.MetalJumbotuar


				#region FF6Mod.NPCs.Bosses.Ulty.Ultros
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Ulty.Ultros", "AI", new ()
				{
					{"Ultros: Uwee hee hee... I'll see you again soon!","奥尔特洛斯:诶嘿嘿...我们很快又要见面啦!"},
					{"Ultros: Uwee hee hee... Game over! Don't tease the octopus, kids!","奥尔特洛斯:诶嘿嘿...游戏结束! 别招惹章鱼，小子!"},
					{"Delicious Morsel!","美味!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Ulty.Ultros", "OnHitByProjectile", new ()
				{
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Ulty.Ultros", "OnKill", new ()
				{
				});
				#endregion FF6Mod.NPCs.Bosses.Ulty.Ultros


				#region FF6Mod.NPCs.Bosses.Ulty.Ultros2
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Ulty.Ultros2", "AI", new ()
				{
					{"Ultros: Uwee hee hee... I'll see you again soon!","奥尔特洛斯:诶嘿嘿...我们很快又要见面啦!"},
					{"Ultros: No, really, this us our LAST battle! Trust me!","奥尔特洛斯:不，实际上这是我们最后一战了!相信我!"},
					{"Ultros: Today I've brought a pal! Mr. Typhon! Come on down!","奥尔特洛斯:今天我带来了帮手!提丰老师!干掉他!"},
					{"Typhon: Fungahhh!","提丰:呼啊啊啊啊!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Ulty.Ultros2", "OnKill", new ()
				{
				});
				#endregion FF6Mod.NPCs.Bosses.Ulty.Ultros2


				#region FF6Mod.NPCs.Bosses.ThunderBeard.Ramuh
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.ThunderBeard.Ramuh", "AI", new ()
				{
					{"Ramuh: I am Ramuh... The esper Ramuh.","拉姆:你寻求力量来阻止一场灾祸。"},
					{"Ramuh: Then withstand my might and prove your worth!","拉姆:那就承受住我的力量，证明你的价值!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.ThunderBeard.Ramuh", "OnKill", new ()
				{
				});
				#endregion FF6Mod.NPCs.Bosses.ThunderBeard.Ramuh


				#region FF6Mod.NPCs.Bosses.Odin.OdinBoss
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Odin.OdinBoss", "AI", new ()
				{
					{"You have grown strong!","你变得更强了!"},
					{"Odin: Lo siento, el player de Terraria","奥丁:Lo siento, el player de Terraria"},
					{"Odin: Esto es el fin.","奥丁:Esto es el fin."},
					{"Odin: FILO ATOMO!","奥丁:FILO ATOMO!"},
					{"Odin: You must earn my respect.","奥丁:你必须赢得我的尊敬."},
					{"Odin: Prove your strength and courage to me!","奥丁:向我证明你的力量和勇气!"},
					{"Odin: Let us begin!","奥丁:开始吧!"},
				});
				#endregion FF6Mod.NPCs.Bosses.Odin.OdinBoss


				#region FF6Mod.NPCs.Bosses.IfritShiva.Ifrit
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.IfritShiva.Ifrit", "AI", new ()
				{
					{"Ifrit: I sense a kindred spirit...","伊弗利特:我感觉到了同类的气息..."},
					{"Shiva: Who are you...?","希瓦:你是谁...?"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.IfritShiva.Ifrit", "OnKill", new ()
				{
				});
				#endregion FF6Mod.NPCs.Bosses.IfritShiva.Ifrit


				#region FF6Mod.NPCs.Bosses.FatChoco.FatChocobo
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.FatChoco.FatChocobo", "AI", new ()
				{
					{"Fat Chocobo: Let's see if you are strong enough to claim my power!","肥陆行鸟:看看你能否强大到接受我的力量吧!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.FatChoco.FatChocobo", "OnKill", new ()
				{
				});
				#endregion FF6Mod.NPCs.Bosses.FatChoco.FatChocobo


				#region FF6Mod.NPCs.Bosses.Chupon.ChuponBoss
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Chupon.ChuponBoss", "OnKill", new ()
				{
					{"Typhon: Fungahhh!","提丰:呼啊啊啊啊!"},
				});
				#endregion FF6Mod.NPCs.Bosses.Chupon.ChuponBoss


				#region FF6Mod.NPCs.Bosses.Chupon.TyphonBoss
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Chupon.TyphonBoss", "OnKill", new ()
				{
					{"Typhon: Fungahhh!","提丰:呼啊啊啊啊!"},
				});
				#endregion FF6Mod.NPCs.Bosses.Chupon.TyphonBoss


				#region FF6Mod.NPCs.Bosses.Carby.Carbuncle
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Carby.Carbuncle", "AI", new ()
				{
					{"Carbuncle can no longer reflect projectiles!","红宝石兽不再反弹射弹了!"},
					{"Carbuncle can reflect projectiles!","红宝石兽开始反弹射弹!"},
				});
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Bosses.Carby.Carbuncle", "OnKill", new ()
				{
				});
				#endregion FF6Mod.NPCs.Bosses.Carby.Carbuncle


				#region FF6Mod.NPCs.Invasions.ImperialAirForce
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Invasions.ImperialAirForce", "ImperialAirForceWarning", new ()
				{
					{"The Imperial Airforce! We're surrounded!","是帝国空军!我们被包围了!"},
					{"The Imperial Airforce retreats.","帝国空军撤退了。"},
				});
				#endregion FF6Mod.NPCs.Invasions.ImperialAirForce


				#region FF6Mod.NPCs.Invasions.ImperialAirForceBar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Invasions.ImperialAirForceBar", "Update", new ()
				{
					{"Invasion Progress: ","入侵进度: "},
				});
				#endregion FF6Mod.NPCs.Invasions.ImperialAirForceBar


				#region FF6Mod.NPCs.Invasions.ImperialArmy
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Invasions.ImperialArmy", "ImperialArmyWarning", new ()
				{
					{"The Imperial Army is invading!","帝国军队入侵了!"},
					{"The Imperial Army retreats.","帝国军队撤退了"},
				});
				#endregion FF6Mod.NPCs.Invasions.ImperialArmy


				#region FF6Mod.NPCs.Invasions.ImperialArmyBar
				TranslatorLoad.LocalizeByTypeFullName("FF6Mod.NPCs.Invasions.ImperialArmyBar", "Update", new ()
				{
					{"Invasion Progress: ","入侵进度: "},
				});
				#endregion FF6Mod.NPCs.Invasions.ImperialArmyBar


			}
		}
	}
}
