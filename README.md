:warning: | __The contents of this repository is explicitly NOT LICENSED for use, modification, or sharing. Per GitHub's terms of service it may only be viewed. See [No License] for more information.__ | :warning:
--------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ---------

[No License]: https://choosealicense.com/no-permission/

Design Seminar for Software Engineers I & II - CIS4961 Winter 2017 & CIS4962 Summer 2017
======
>For our senior capstone project, we were tasked with performing the entire software development
>lifecycle with a real client: from requirements gathering through multiple deployments. Our client
>wanted a modular framework written for Unity that would be fully extensible and provide an easy
>method for creating an idle-progress roleplaying game for Android and iOS devices.

### Details

__Students:__ Marc King, Bageshri Bhavsar, Ali Dashti, Jeff Wright, Mark Malkowski

__Professor:__ Dr. Bruce Maxim / Dr. Kiumi Akingbehin

__School:__ University of Michigan - Dearborn

__My Contributions:__ Design, architecture, implementation, documentation

__Timeline:__ 8 months for requirements gathering, design, implementation, testing, and deployment

### Technologies

* .NET Framework 3.5
* Unity 5.6.3

### Sample Game

The following animations comprise a sample game that was created to showcase the framework to the
client. All art is placeholder art, and the interface is more simplistic than the hooks provided
by the framework can allow.

*Upon loading the game the player is presented with the world map. They can pan around the world map,
see which zones they have unlocked, and enter any unlocked zone. Entering a zone allows the player
to pan around the zone map, see which stages they have unlocked, and enter any unlocked stage. While
on either the world map or a zone map the player is able to select allies, equipment, and abilities
or upgrade their hero and allies.*

[![StageSelection](Screenshots/StageSelection.gif?raw=true "StageSelection")](Screenshots/StageSelection.gif?raw=true)

*The hero needs allies, equipment, and abilities to survive; enter the first stage will result in a
quick death if none have been selected.*

[![YouNeedAllies](Screenshots/YouNeedAllies.gif?raw=true "YouNeedAllies")](Screenshots/YouNeedAllies.gif?raw=true)

*The player is able to unlock many different allies by completing stages, but can only take three
of them to battle on stages.*

[![AllySelection](Screenshots/AllySelection.gif?raw=true "AllySelection")](Screenshots/AllySelection.gif?raw=true)

*Players can collect equipment that can then be assigned to their hero. A hero can have armor and a
weapon, or a weapon and shield, or a two-handed weapon assigned.*

[![EquipmentSelection](Screenshots/EquipmentSelection.gif?raw=true "EquipmentSelection")](Screenshots/EquipmentSelection.gif?raw=true)

*Abiliies allow the hero to perform special actions during combat. A hero always has the defend ability
and can assign up to three more abilities. New abilities are learned from allies when they are acquired.*

[![AbilitySelection](Screenshots/AbilitySelection.gif?raw=true "AbilitySelection")](Screenshots/AbilitySelection.gif?raw=true)

*The player can spend currency to upgrade their hero. The hero's attribute scores increase with each
level.*

[![UpgradeHero](Screenshots/UpgradeHero.gif?raw=true "UpgradeHero")](Screenshots/UpgradeHero.gif?raw=true)

*Currency can also be spent to upgrade the attribute scores of allies. Only certain attribute scores are
increased; which ones depend on the type of ally being upgraded.*

[![UpgradeAllies](Screenshots/UpgradeAllies.gif?raw=true "UpgradeAllies")](Screenshots/UpgradeAllies.gif?raw=true)

*Battles can be much easier with allies and abilities. Toward the end of a stage a boss may spawn.*

[![Skirmish](Screenshots/Skirmish.gif?raw=true "Skirmish")](Screenshots/Skirmish.gif?raw=true)

*Stages can contain obstacles that characters and enemies must walk around.*

[![Obstacles](Screenshots/Obstacles.gif?raw=true "Obstacles")](Screenshots/Obstacles.gif?raw=true)

### Inspector Screenshots

*Nearly every aspect of the game is exposed to the Unity inspector to ease customization. The developers
should be careful when changing some values as they can be game-breaking changes. Extensive documentation
was provided to the client to detail the effect of changing these values.*

[![InspectorGameManager](Screenshots/InspectorGameManager.png?raw=true "InspectorGameManager")](Screenshots/InspectorGameManager.png?raw=true)

*All the entities are implemented using Unity's ScriptableObjecct methodology, making it simple and
straight-forward to create and maintain.*

[![InspectorAlly](Screenshots/InspectorAlly.png?raw=true "InspectorAlly")](Screenshots/InspectorAlly.png?raw=true)

[![InspectorEquipment](Screenshots/InspectorEquipment.png?raw=true "InspectorEquipment")](Screenshots/InspectorEquipment.png?raw=true)

[![InspectorAbility](Screenshots/InspectorAbility.png?raw=true "InspectorAbility")](Screenshots/InspectorAbility.png?raw=true)

[![InspectorEnemy](Screenshots/InspectorEnemy.png?raw=true "InspectorEnemy")](Screenshots/InspectorEnemy.png?raw=true)

[![InspectorRandomLoot](Screenshots/InspectorRandomLoot.png?raw=true "InspectorRandomLoot")](Screenshots/InspectorRandomLoot.png?raw=true)

[![InspectorStaticLoot](Screenshots/InspectorStaticLoot.png?raw=true "InspectorStaticLoot")](Screenshots/InspectorStaticLoot.png?raw=true)

[![InspectorQueue](Screenshots/InspectorQueue.png?raw=true "InspectorQueue")](Screenshots/InspectorQueue.png?raw=true)

### Development

*The following animations shows some of the features being tested in isolation.*

[![CasterTest](Screenshots/CasterTest.gif?raw=true "CasterTest")](Screenshots/CasterTest.gif?raw=true)

[![EnemySpawnTest](Screenshots/EnemySpawnTest.gif?raw=true "EnemySpawnTest")](Screenshots/EnemySpawnTest.gif?raw=true)

[![MeleeTest](Screenshots/MeleeTest.gif?raw=true "MeleeTest")](Screenshots/MeleeTest.gif?raw=true)

[![RangedTest](Screenshots/RangedTest.gif?raw=true "RangedTest")](Screenshots/RangedTest.gif?raw=true)

[![SkirmishTest](Screenshots/SkirmishTest.gif?raw=true "SkirmishTest")](Screenshots/SkirmishTest.gif?raw=true)
