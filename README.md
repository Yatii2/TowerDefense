# TowerDefenseTemplate +gedaan
In mijn game komen er bountyhunters die je schat willen stelen aan het einde van het pad.
Je spawnt torens (cannonen) te plaatsen om de piraten dood te maken en je schat veilig te houden.

![main menu](https://github.com/Yatii2/TowerDefense/blob/main/MainMenu.jpg)

![my game](https://github.com/Yatii2/TowerDefense/blob/main/MainGame.jpg)


## Product 1: "DRY SRP Scripts op GitHub" +gedaan

(SRP) - In dit script heb ik een if statement gebruikt om te checken met een bool of het gameobject actief is of niet.
[link](https://github.com/Yatii2/TowerDefense/blob/main/TowerDefense/Assets/MainMenu/Scripts/Activate.cs)

(DRY) - In dit script heb ik een while loop gebruikt om mijn enemies te spawnen per wave waardoor ik niet elke keer een if statement hoef te maken.
[link](https://github.com/Yatii2/TowerDefense/blob/main/TowerDefense/Assets/Scripts/Enemies/RoundManager.cs)

## Product 2: "Projectmappen op GitHub" +gedaan

Je commit de mappenstructuur van je unity project op github en verwijst vanuit je readme naar de root map van je project. Met een netjes en goed gestructureerde mappenstructuur en benamingen van files toon je aan dat je dit leerdoel beheerst. 

Dit is de [ROOT](TowerDefense) folder van mijn unity project.

Zorg dat deze verwijst naar je Develop branch.

## Product 3: Build op Github +gedaan

[Release](https://github.com/Yatii2/TowerDefense/releases)

## Product 4: Game met Sprites(animations) en Textures +gedaan

![Textures Sprites](https://github.com/Yatii2/TowerDefense/blob/main/Gameplay.gif)

## Product 5: Issues met debug screenshots op GitHub +gedaan

[Hier de link naar mijn issues](https://github.com/Yatii2/TowerDefense/issues)

## Product 6: Game design met onderbouwing +gedaan

Je gebruikt een game design tool om je game design vast te leggen en te communiceren. Daarnaast onderbouw je de design keuzes ten aanzien van “playability” en “replayability” voor je game schriftelijk. 

Voorbeeld van een one page design:
![](https://github.com/Yatii2/TowerDefense/blob/main/onepagedesign.png)

Omschrijf per mechanic welke game design keuzes je hebt gemaakt en waarom je dit hebt gedaan.

*  **De game bevat vernietigbare vijanden die 1 of meerderen paden kunnen volgen.** 

*Mijn game bevat vernietigbare enemies die bountyhunters zijn, zij volgen het pad vanaf begin tot einde op de map en kunnen dood (vertietigt) gaan doordat ze geschoten worden door een cannon.*

*  **De speler kan verschillende types torens kopen en plaatsen.**  

*Ik heb 3 verschillende torens en dat zijn:
1. Weak cannons: delen 10 damage per hit.
2. Average cannon: delen 30 damage per hit.
3. Strong cannons: delen 100 damage per hit.*

*  **De game bevat een “wave” systeem waarmee er onder bepaalde voorwaarden (tijd/vijanden op) nieuwe waves met vijanden het veld in komen.**

*Mijn game heeeft een wave systeem die elke 15 seconden 5 enemies spawnt.*


## Product 7: Class Diagram voor volledige codebase 

Je brengt je volledige codebase in kaart met behulp van een class diagram. Binnen de classes hoeven geen private members te worden weergegeven. Wel alle public members (fields en methods). Ook geef je indien relevant de relaties tussen je classes weer. Je class diagram plaats je in je readme op github. Evt mag je dit doen m.b.v de [“Mermaid”](https://mermaid.js.org/syntax/classDiagram.html) tool.


```mermaid
---
title: Animal example
---
classDiagram
    note "From Duck till Zebra"
    Animal <|-- Duck
    note for Duck "can fly\ncan swim\ncan dive\ncan help in debugging"
    Animal <|-- Fish
    Animal <|-- Zebra
    Animal : +int age
    Animal : +String gender
    Animal: +isMammal()
    Animal: +mate()
    class Duck{
        +String beakColor
        +swim()
        +quack()
    }
    class Fish{
        -int sizeInFeet
        -canEat()
    }
    class Zebra{
        +bool is_wild
        +run()
    }

```

## Product 8: Prototype test video 
Je hebt een werkend prototype gemaakt om een idee te testen. Omschrijf if je readme wat het idee van de mechanics is geweest wat je wilde testen en laat een korte video van de gameplay test zien. 

[![example test video](https://ucarecdn.com/dbdc3ad0-f375-40ad-8987-9e6451b28b50/)](https://www.youtube.com/watch?v=CzzRML1swF0)

## Product 9: SCRUM planning inschatting +gedaan

Je maakt een SCRUM planning en geeft daarbij een inschatting aan elke userstory d.m.v storypoints / zelf te bepalen eenheden. (bijv. Storypoints, Sizes of tijd) aan het begin van een nieuwe sprint update je deze inschatting per userstory. 

Plaats in de readme een link naar je trello en **zorg ervoor dat je deze openbaar maakt**

[Link naar de openbare trello]([https://trello.com/b/w60wkKSU/examen-paraphrenia](https://trello.com/b/kqA3BrNz/towerdefensem5))

## Product 10: Gitflow conventions
Je hebt voor je eigen project in je readme gitflow conventies opgesteld en je hier ook aantoonbaar aan gehouden. 

De gitflow conventions gaan uit van een extra branch Develop naast de "Master"/"Main". Op de main worden alleen stabiele releases gezet.

Verder worden features op een daarvoor bedoelde feature banch ontwikkeld. Ook kun je gebruik maken van een hotfix branch vanaf develop.

Leg hier uit welke branches jij gaat gebruiken en wat voor namen je hier aan gaat meegeven. Hoe vaak ga je comitten en wat voor commit messages wil je geven?

.



