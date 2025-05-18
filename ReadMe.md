# Design Patterns — Варіант 20

У цьому репозиторії зібрані демонстраційні проекти для шаблонів проектування:

-   **Creational**: Prototype
-   **Structural**: Composite (ще в розробці)
-   **Behavioral**: Hierarchical Visitor (ще в розробці)
-   **Concurrency**: Lock (ще в розробці)

---

## Prototype

Патерн **Prototype** дозволяє створювати нові об'єкти шляхом клонування вже наявних екземплярів, що корисно, коли ініціалізація об'єкта є дорогою чи складною.

### UML-діаграма класів

```mermaid
classDiagram
    class IPrototype {
      <<interface>>
      +Clone(): IPrototype
    }

    class ConcretePrototypeA {
      -State: string
      +ConcretePrototypeA(state: string)
      +Clone(): IPrototype
    }

    IPrototype <|.. ConcretePrototypeA
```

### UML-діаграма послідовності

```mermaid
sequenceDiagram
    participant Client
    participant Proto as IPrototype
    participant Copy

    Client->>Proto: Clone()
    Proto-->>Client: new ConcretePrototypeA
    Client->>Copy: modify State
```

### Демонстраційний код

Папка PrototypeDemo/ містить консольний проект з реалізацією IPrototype, ConcretePrototypeA і простим прикладом у Program.cs.

---

## Structural Pattern: Composite

Патерн **Composite** дозволяє клієнтам працювати з ієрархією об'єктів (складених і простих) однаково через спільний інтерфейс.

### UML-діаграма класів

```mermaid
classDiagram
    class IComponent {
      <<interface>>
      +Operation(): void
    }

    class Leaf {
      +Operation(): void
    }

    class Composite {
      -children: List~IComponent~
      +Add(c: IComponent): void
      +Remove(c: IComponent): void
      +Operation(): void
    }

    IComponent <|.. Leaf
    IComponent <|.. Composite
    Composite o-- "0..*" IComponent : children
```

### UML-діаграма послідовності

```mermaid
sequenceDiagram
    participant Client
    participant Root as Composite
    participant Leaf

    Client->>Root: Add(Leaf)
    Client->>Root: Operation()
    Root->>Leaf: Operation()
```

### Демонстраційний код

Див. папку CompositeDemo/ — консольний проект із реалізацією IComponent, Leaf, Composite та прикладом використання в Program.cs.

---
