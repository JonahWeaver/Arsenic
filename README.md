# Arsenic

## Table of Contents
- [1. Introduction](#1-introduction)
  - [1.1 Project Overview](#11-project-overview)
  - [1.2 Importance of Documentation](#12-importance-of-documentation)
  - [1.3 Technologies](#13-technologies)
- [2. Concept Statement](#2-concept-statement)
  - [2.1 Target Audience](#21-target-audience)
    - [2.1.1 Appealing to Target Audience](#211-appealing-to-target-audience)
    - [2.1.2 Appealing to Broader Audience](#212-appealing-to-broader-audience)
  - [2.2 Working Title](#22-working-title)
  - [2.3 Genre](#23-genre)
  - [2.4 Uniqueness/Innovative Design](#24-uniquenessinnovative-design)
- [3. Product Design](#3-product-design)
  - [3.1 Plot and Setting](#31-plot-and-setting)
    - [3.1.1 Global Setting and History](#311-global-setting-and-history)
      - [3.1.1.1 Historical Context](#3111-historical-context)
      - [3.1.1.2 Key Conflicts](#3112-key-conflicts)
    - [3.1.2 Local Setting](#312-local-setting)
      - [3.1.2.1 Cultural Elements](#3121-cultural-elements)
      - [3.1.2.2 Significant Locations](#3122-significant-locations)
  - [3.2 Gameplay Core Loops](#32-gameplay-core-loops)
    - [3.2.1 Tactical Battles](#321-tactical-battles)
      - [3.2.1.1 Battle Objectives and Progression](#3211-battle-objectives-and-progression)
      - [3.2.1.2 Battle Rewards](#3212-battle-rewards)
      - [3.2.1.3 Feeding To/From Other Loops](#3213-feeding-tofrom-other-loops)
      - [3.2.1.4 Systems to Enable Tactical Play](#3214-systems-to-enable-tactical-play)
    - [3.2.2 City Management](#322-city-management)
      - [3.2.2.1 Management Objectives and Progression](#3221-management-objectives-and-progression)
      - [3.2.2.2 Management Rewards](#3222-management-rewards)
      - [3.2.2.3 Feeding To/From Other Loops](#3223-feeding-tofrom-other-loops)
  - [3.3 Visual Style](#33-visual-style)
  - [3.4 Audio Style](#34-audio-style)
- [4. Rambling](#4-rambling)
  - [4.1 How games tackle long form gameplay](#41-how-games-tackle-long-form-gameplay)

## 1. Introduction

With the rise of the rogue-like genre, with the growing understanding by more casual gamers that smaller feedback loops actually have high compatibility with busier schedules and lives and more non-commital gamers, it's difficult to innovate longer form games that can keep the player engaged long term. 

I discuss more about how games tackle this here: https://github.com/JonahWeaver/Arsenic/blob/main/README.md#41-how-games-tackle-long-form-gameplay

To circumvent this with standard gameplay designs, various difficulties will be available, and all "crossroads" the player can traverse will be available at some point. A focus on high "transferring" between elements of the gameplay loop will be employed, along with highly compartmentalized goals for the player to accomplish such that they can feel a sense of accomplishment in the smaller part of the game to carry them throughout the larger part.

### 1.1 Project Overview
The idea behind Project Arsenic is to allow the player to innovate in and revive a dying culture in their revolution against global superpowers. 

Magic is a scarce and powerful resource for the development of civilizations in the world of this game, and has developed a culture of fear as it develops as a weapon of war. Countries have further harnessed its capabilities for destruction to build empires, and a small continent at the epicenter of global powers is believed to hold the power to conquer the world with magic. The son of a heros, born in the underground city that holds the secrets sought by the world, learns of the power of the 13 Zodiacs born to protect the world from evil, and follows in the footsteps of his mother who died in birth to protect him as the Monster Bearer Zodiac: Ophiuchus. Aiming to unite legendary reincarnations of warriors, in grand strategy and management of colonies torn apart by war, the fate and stability of the world can only be protected by those of the Zodiac.

### 1.2 Importance of Documentation
A log of the intended interactions between mechanics is important not to lose sight of the overall goals of the project as defined in this document. Cohesion between elements of the gameplay loop is critical, along with the player being able to solidly identify sub-goals and interact with the game in an effective way to achieve those goals.

### 1.3 Technologies
Unity will be used for this project. Early on, if it's decided that certain design decisions are better suited to Unreal for implementation, the pivot will be made.

## 2. Concept Statement
Manipulating ancient and modern spells of Magic, rebuilding a crumbling continent, and reuniting the hearts of people of the world, you play the rising leader of the Ophiucus Zodiac. It will be under your strategy, intellect, and fervor that you will raise this continent in a revloutionary war against the power hungry tyrants that aim to devour the world.

### 2.1 Target Audience
Fans of strategy games like Fire Emblem, XCOM, Unicorn Overlord, and etcetera are the niche audience this game would hopefully immediately attract. The main concern is adapting the city management concept into the game. More robust supports, when intergrated correctly, have greatly benefitted all franchises, but the opposite is true for management. The closest was XCOM's simple hub location, and even then it's not really that loved compared to the rest of the game.

Approaching implementation with the idea that a given mechanic can apply to every other one can make cross-implementation easier for a dynamic system. Say if we want to interpret a decision as creating rules for another decision to operate by, we can inject dependenies accordingly. This is a bit complicated for the context of a design document, if things will work this way, but it's important to think about what players think about when looking for a game and creating different ways of appealing to that.

#### 2.1.1 Appealing to Target Audience
Engaging strategic gameplay and non-obtrusive and interesting city management and interactions are the basics for ensuring that this game appeals to its target audience. Characters should not be 2D cardboard cutouts of basic ideas that never grow or change (I'm the shy character that's crippling scared of people. Also I like tomatoes, because that's a personality trait). Writing more compelling characters is, of course, very difficult though, I suppose.

City management will need to be simplified in the number of rules as much as possible. It should likely also try to synergize with the goals the target audience might internalize and hope to try to achieve when picking a game like this up. For example, my brother picks up Fire Emblem hoping to marry boys that he likes in game. He realizes he can achieve this by pairing characters up or having them next to each other in combat to build support points, which amount to support conversations to learn more about the character in an interesting (enough) conversation. City management should be able to meet broader goals than just resource accumulation; how can they benefit the player to meet personal sub-goals?

#### 2.1.2 Appealing to Broader Audience

* Snappy and intuitive menus and controls
* Romantic/Platonic relationships with other characters
  * Can build on this in all parts of the core gameplay loop, with each one typically able to contribute to certain facets of a relationship
  * Maybe this can include a rivalry system where different NPCs can be annoyed in the resources invested in another? Sounds like a lot for not a lot of gain
    * Maybe this all can be designed in a way where the intuitive "response" of someone in the world is apathy
* Creating a "build" and then executing on a plan
  * Allowing for customizability in an approach to accomplishing a plan is important to some players, though this might be too much and not addressing a player's desire necessarily in the context of a "loadout" in a tactics game
    * This might often require the ability for the player to have information of their enemies in advance to prepare their "build"
      * This should be fine. If gameplay scenarios are deterministic, this should be possible since metagaming exists. If the game isn't determistic and instead more procedurally generated, it's a great mechanic as an option for players.
  *Maybe an overarching mechanic like "approach" or "formation" or "platoons" might help in build customization. A large part of the current idea in strategy games is the stats of a unit, including their mobility. Maybe there can be ideas of more dynamic attacks that affect positioning and forced movement, but that doesn't address the "build" idea.
  *Allowing for character specs with reclassing options might be beneficial, like Fire Emblem Heart Seals or Second Seals. I think FE Engage does it best, where weapon affinity decides ability to reclass
    *What to maintain:
      *Logical soundness: Reclassing a brute into a mage class or a scrawny girl into an armored infantry class shouldn't be possible. Builds/classes should serve to enhance character identity.
      *Meaningful bonuses to build advancement options: The player should have to choose between given options in order to advance their playstyle. This involves having build/class identity that synergizes with their understanding of the game and what they want from a character. (DON'T FORGET, THEY SHOULD ALWAYS BE ABLE TO CHANGE THEIR DECISION SOMEHOW)
      *If going down the familiar "promotions" route, having multiple promotions that allow for independent character identity would be great for players to have diverse playstyles.
* Keep track of environmental details and reward players for paying attention to them. Attention-to-detail and environmental story-telling are critical to keep players hooked
  * Includes immersion and atmosphere
* Perks/boosts/buffs and any increases to the player's arsenal should have significant and visible effects on gameplay (they're kicking much more ass now, or they're able to support their team much more)
  * Can be balanced with much more dynamic and powerful enemies that need their own strategy to handle, along with older enemies to highlight the bonuses they earned that make them stronger
* Narrative, satisfying movements, looks and sounds pretty enough etc.
  * Narrative can be dripped through the gameplay battle scenes as well as other scenes, though exposition dumps should be tried to be kept to a minimum


### 2.2 Working Title
The first and current working title is Arsenic, which is simply a word that starts with "A", the first letter of the alphabet. (like hurricanes)

### 2.3 Genre
Tactical-RPG and small city Builder

### 2.4 Uniqueness/Innovative Design
Heightened cohesion between interesting game states in the core gameplay loop while maintaining simplicity is the goal to appeal this game to as wide of an audience as possible.

There's also the nature of exploration incorporated into the game, allowing players to explore the world naturally before entering combat or other interesting scenarios. This allows for advanced planning and strategy while also learning about the world around them. (Unicorn Overlord did this first, but now I'll do it in **3D**)

## 3. Product Design

The desired outcome from this design is to unravel the intricate history of the world as naturally to the player as possible as they overcome interesting and unique strategic decisions and challenges and come to understand and appreciate this world around them.

### 3.1 Plot and Setting
While the plot highlights multiple countries, the physical setting of the game will highlight the central continent and its defense. The priority of how elements of the plot of the game will be delivered is in order as follows: 

  1. Environmental details
  2. Battle exposition between characters
  3. Exposition between characters
  4. Direct exposition

"Exposition" can refer to any interaction between a character and something else that communicates information. Ideally, exposition itself follows a priority list of presenting the natural implications of the only possible thing(s) that are desired to communicate to the player, then dialogue that explicitly addresses information. I.E. show, don't tell.

#### 3.1.1 Global Setting and History
TBD

##### 3.1.1.1 Historical Context
TBD

##### 3.1.1.2 Key Conflicts
TBD

#### 3.1.2 Local Setting
TBD

##### 3.1.2.1 Cultural Elements
TBD

##### 3.1.2.2 Significant Locations
TBD

### 3.2 Gameplay Core Loops
As mentioned, the core gameplay loops in the overall design is as follows:

1. The battle sequence, where the player commands their squad of Zodiacs against an enemy force
2. The city management phase, which itself has certain properties and decisions
  1. You use this time to bond with Zodiacs or other characters and engage in quests, which can lead to interesting, maybe dangerous scenarios
  2. You can prepare certain buildings for construction that provide unique bonuses to complement the player's grand strategy
  3. You can command regiments of forces to attack enemy bases, fortify player bases, or scout for ambushes or other information
  4. Purchasing and enhancement of equipment and characters
  5. Exploration of the world around the player, including outside the colony
  6. Hopefully much more



#### 3.2.1 Tactical Battles
Combat occurs on a square grid and initiates in the order of player's relevant initiative stat calculation (how quick and dextrous they are). 

Here are the list of stats and how they generally affect combat:

1. Hit Points - You know what this is
2. Strength - Physical power and ability to wield weapons and equipment
3. Affinity - Magic power
4. Dexterity - Affects weapon accuracy, turn initiative
5. Defense - Ability to withstand physical blows
6. Willpower - Magic Resistance
7. Speed - How quickly the user can move, amplifying ability to attack, along with their ability to evade attacks
8. Movement - Calculated by speed and equipment, affecting unit mobility

Generally the formula should work as Attacking Stat - Defending Stat = Damage, and the defending unit's HP is subtracted by this damage if it's greater than 0. If HP becomes zero, the unit dies. However, calculations can change somewhat based on equipment. The unit can also evade attacks based on their speed and the weight of their equipment avoiding damage.

During a unit's turn, they can use an action to use an item in their inventory, utilize weapons to perform a physical attack, or perform an available spell. Equipment can be melee or ranged weapons, and they can respond to worn equipment and character physical of magic defense in different ways. For example, a fire arm shot at a soldier wearing heavy steel armor might not do any damage, but it can reduce their mobility. Here's the list of equipment types and how they interact

Weapons:

1. Swords - Medium damage, low weight
2. Hammers - Ignores armor in damage calculation, high damage, high weight
3. Axes - High damage, medium weight
4. Lances - Medium damage, medium weight, only melee weapon always usable for horseback (med-high damage, low weight on horseback)
5. Quarter Staffs - Easy to inscribe with magic, medium damage, easy to use
6. Muskets - Can fire large damage medium range single shot. Damage is constant and not affected by stats. Adds attack weight to armored enemies that resist its damage. Needs reload every shot. Can attach sword as a bayonet, though this adds to the weapons weight and can make it more difficult to wield.
7. Flintlock Pistols - Can fire medium damage short range single shot. Damage is constant and not affected by stats. Adds attack weight to armored enemies that resist its damage. Needs reload every shot.
8. Bows - Fires medium damage high range attacks. Diverse, as there are many different types of bows and arrows to handle different situations.

Equipment:

1. Clothing - Can more easily be inscribe with magic
2. Light Armor - Small boon to defense, difficult to inscribe with magic
3. Medium Armor - Low penalty to speed, Medium boon to defense, difficult to inscribe with magic
4. Heavy Armor - High penalty to speed, High boon to defense, difficult to inscribe with magic. Units wearing this armor can act as cover against ranged attacks.

Offhand/side equipment:
  1. Flintlock pistol (Same as before, but don't have to reload)
  2. Shield - Protects against attacks, low-medium weight
  3. Greatshield - Strongly protects against attacks, high weight
  4. Crystals - Enhances affinities or certain stats

NOTE: Weight of equipment affects accuracy, evasion, and mobility. Cannot wear weight of equipment that exceeds strength capabilities.

There can also be skills characters can utilize to aid in combat, that can be attained by class/path progression, special events, etc.

##### 3.2.1.1 Battle Objectives and Progression
Goals can pertain to, but are not limited to, defeat of a commander, a whole regiment, survival for a number of turns, etc.

##### 3.2.1.2 Battle Rewards
Rewards for a combat scenario are relevant to the context that can be one of as follows:

1. Stronghold Conquer - Acquire the resources produced by the holding that can be used for development
2. Stronghold Defense - Thwart enemy attack and reduce their advance and aggression
3. Quest Combat - Specific quest rewards
4. Inner city combat - Reduces crime and increases city development and output

All combats should provide the armaments and equipment of enemy forces if they aren't able to retreat. 

##### 3.2.1.3 Feeding To/From Other Loops
Relationship building can occur as a result of allies fighting together, which can advance "social links" between the player character and allies, which can then improve the player's party.

Resources used for city building and control can be acquired through these missions, along with arming local militia for future scouting, offense, and defense.

##### 3.2.1.4 Systems to Enable Tactical Play
TBD.

#### 3.2.2 City Management
Allows for utilization of resources to construct facilities to enhance play.

##### 3.2.2.1 Management Objectives and Progression
TBD.

##### 3.2.2.2 Management Rewards
Access to certain weapons, magic spells, etc. TBD

##### 3.2.2.3 Feeding To/From Other Loops
TBD.

### 3.3 Visual Style
Defines the artistic style and visual direction. **TBD**

### 3.4 Audio Style
Describes the sound design and music style. **TBD**

## 4. Rambling
Below is where I ramble about the specifics of reasonings of certain design choices among other observations. While relevant to the "why" of certain decisions, it's not necessary for the direction of the project.

### 4.1 How games tackle long form gameplay
Persona 5 performs this with a simple gameplay loop and compelling characters, narrative, and overall artstyle. 

Legend of Zelda: Tears of the Kingdom performs this through its dynamic feedback loop and gameplay system, along with "goal setting". By this, the game accomplishes engagement by presenting the player with many interesting challenges that each have their own immediate reward that's quantifiable to the player. This allows the player to direct simple goals into a satisfying gameplay loop. For example, the game has a total of 120 shrines, which are a significant part of the its progression. The player compartmentalizes these simply as shrines, but this isn't all that they are. They are a portal to a test of skill to the player to collect various rewards along with an orb at the end, which is necessary to increasing certain stats. These stats are health and stamina, which allow for better navigation of the world and improved tanking abilities for combat and other navigation.

Why do I call all of the above "goal setting"? Because, for a normal player, not all of this can be accomplished in one sitting. This should be obvious, but this can create a "nagging" in the player's mind that can return them to the game. Perhaps like "I remember seeing a few shrines in a place. If I can get those I can explore an area I haven't been to yet and maybe acquire something". Always keeping alive that "black box" to the player while making discovering it rewarding both gameplay wise and personally is a great.

Elden Ring accomplishes this in a similar way, but much more focused to certain areas. Elden Ring's currency allowing any creature to give the player currency and loot upon death can naturally allow them to fell intrigue in approaching even dangerous places. A brilliant example of this is the combination of the game's opening along with the "Scarlet Bog". he game's opening highlights the danger of the world along with an instinct by the player to desire staying alive. This is highlighted by if the player sees the Scarlet Bog early on, they aren't limited by an arbitrary wall preventing them from entering the area like other games. They're prevented by their own caution and lack of experience to traverse a clearly dangerous area, and are more likely to respect the developers' "intended" path. This counter-intuitively builds player confidence, as they're not just tackling enemies. They're trusting their understanding of their setting to make decisions, which can allow them to ask questions about this world around them.

To build on this, Elden Ring has a great balance between leveraging narrative elements of the world and its characters and the dangers it presents and the player's goals in its core loops. Elden Ring's loops are not explicit; you can be attacked by an enemy at technically any point in the game. This is a very subtle design choice that adds to the feeling of danger in any interaction. It might be the player's perogative to attack enemies ahead of time; trust no one. But maybe the player encounters someone who wasn't aggressing now making their lives difficult becuase they're so strong? Or maybe the player wouldn't want to risk it in the first place. Regardless, building this caution asks the player to listen to everything a potential aggressor might say, which portrays the world of the game as one interconnected between the NPCs and what they represent. It's no longer just "this big enemy" or another. It's "Godrick the Golden" who is the last of his lineage who disgraced it by utilizing the world's practice of "grafting" to attain strength that is nowhere near that of even stronger enemies later in the game. This is all organically built up by the player's own observations of the enemies, world, and characters around them. 

While the above sounds more like strong adherence to the fundamentals of world building - which is correct- it's also the stepping stone for the player to engage with the world around them. No game mentioned in this excerpt has had one single gameplay mechanic that crafted the image of the game in the player's head to continue going forward. Persona 5 has its monster-catching system along with its narrative. Tears of the Kingdom has its colorful world and the challenges to acquire resources to explore it and defend against it. The SoulsBorne games developed by FromSoft have always had a key theme in these games, and its the idea that no matter the setting, the player slowly becomes nothing but a pawn to success in the game. This is communicated directly in Dark Souls, where the player loses humanity as they die. While the character can restore this, it's implied throughout the story that there is still "something" lost as the player moves forward. The player, no matter who they must kill or hurt, will still move forward until they win. The challenge of the game no longer becomes a triumph, but a test to the player of how far they're willing to go. Of course, the player is not less moral for what they have to do, but this slowly dying consideration of the world around them - optimizing this understanding only for the accomplishment of the player's goals- is expertly utilized by the developers to not just present mind-boggling enemy design that force the player to stop and consider what they're doing, but also morally questionable ones. A great example is Elden Ring's (lady of the moon or whatever. I've got to stop writing here because I don't want to waste time.)

How do we implement these and similar ideas into a larger tactics game? It feels simply as though building small and rewarding feedback loops that can organically be chosen by the player is the immediate "correct solution". How is this formed organically by the player? How do we prevent risking them formulating on their decision for too long and not ultimately allowing them to reward themselves?

* Difficulty levels can be used to better tailor the player experience. This might require questioning how this can be integrated into a system that bypasses alot of redesign work between difficulties, but this can be considered later.
* "Crossroads should be retraversable". In rogue-likes, there are often decisions that allow the player to trend decisions towards a "build". Say you can only choose 1 of 3 pieces of equipment that boosts bow damage by a percent. Ideally, you'd continually choose the "bow" choice until the run ends. Since the game has a short run, there isn't much consequence to the bow being bad if it is; the player can just restart and not much isn't lost. This is a bad idea for a long form game. If the player doesn't like their choice for their style of play, they were just completely unrewarded for them playing the game.
* Gameplay loops feed into each other
  * The easiest way of doing this is allowing for, in some way, to allow the parts of a loop to provide currencies in another part of a loop. Like how in Civ 5 settling or city conquering can provide resources for further development, or maybe how some currencies can allow for more development in others. The risk in this is creating a system that has may too many currencies and rules can drive away most players who might have difficulty in having fun doing math and science (Stellaris). This can be circumvented by only allowing certain resources to be relevant as the game progresses, allowing the player to learn that the game does have resources relevant to the gameplay loop that have compartmentalized functions.
  * The only other way of feeding loops into each other are logical loops, but that's likely pretty similar. As in, if the player makes certain decisions, it creates "roadblocks" that prevent certain events, which can pertain to multiple loops at once. This is highly specific to each loop and might require specific design dicsussion on its own, if it's even different enough from the currency idea.
* Compartmentalized goals with quantifiably significant reward
  * Like hearts/stamina in TOTK or palace/Tartarus completion in Persona 5, something larger scale that the player can break down easily into goals allows the gameplay loop
  * Bosses
    * Bosses are what I was trying to describe with the Elden Ring thing. Story significant characters or creatures that are built up both narratively and gameplay wise to highlight challenge to the player are a great goal for players to set to defeat.
    * Reward?
  * Forts/Strongholds
    * Similar to bosses in that this is CAN be a quantifiable goal that the player can conquer strongholds to recapture the country or something. This can allow for significant gains to resources or other things to acquire in this or other gameplay loops. Whether this should be different or intermingled with "bosses" is ?
    * Reward? 
  * Other positions?
    * What if "Strongholds" aren't the only major areas to conquer. This might become confusing then. While it might be fun to have multiple different areas for the player to conquer for differing rewards, TOTK doesn't have things like "Green shrines" or "Purple shrines". It might be best to keep things simple while also using a word that accurately describes all of these important positions.
