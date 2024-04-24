## UML

```mermaid
    classDiagram
    class Animal {
        +virtual string Sound()
    }

    class Cat {
        +override string Sound()
    }

    class Dog {
        +override string Sound()
    }

    class Bat {
        +Bat()
    }

    class Bee {
        +Bee()
    }

    Animal <|-- Cat
    Animal <|-- Dog
    Animal <|-- Bat
    Animal <|-- Bee
```