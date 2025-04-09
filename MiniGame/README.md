# MiniGame Project

## UML Class Diagram

```mermaid
classDiagram
    class Character {
        +string Name
        +Weapon[] weapons
        +Fight() void
    }

    class Weapon {
        #float power
        +Weapon(float power)
    }

    class Gun {
        +int Ammo
        +Gun(float power, int ammo)
        +FireGun() void
    }

    class Sword {
        +float BladeLength
        +Sword(float power, float bladeLength)
        +AttackWithSword() void
    }

    class Player {
        +Player(string name)
    }

    class Enemy {
        +Enemy(string name)
    }

    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword
    Character "*--" Weapon : contains
