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

## Behavioral Pattern: Hierarchical Visitor

Патерн **Visitor** дозволяє додавати нові операції над елементами об'єктної ієрархії, не змінюючи самі класи цих елементів. У варіанті "Hierarchical Visitor" ми демонструємо, як один відвідувач може обробляти різні підкласи елементів.

### UML-діаграма класів

```mermaid
classDiagram
    class IVisitor {
      <<interface>>
      +VisitElementA(a: ElementA)
      +VisitElementB(b: ElementB)
    }

    class IElement {
      <<interface>>
      +Accept(v: IVisitor)
    }

    class ElementA {
      +Accept(v: IVisitor)
      +OperationA()
    }

    class ElementB {
      +Accept(v: IVisitor)
      +OperationB()
    }

    class ConcreteVisitor {
      +VisitElementA(a: ElementA)
      +VisitElementB(b: ElementB)
    }

    IVisitor <|.. ConcreteVisitor
    IElement <|.. ElementA
    IElement <|.. ElementB
    ElementA o-- IVisitor : accepts
    ElementB o-- IVisitor : accepts
```

### UML-діаграма послідовності

```mermaid
sequenceDiagram
    participant Client
    participant A as ElementA
    participant B as ElementB
    participant V as ConcreteVisitor

    Client->>A: Accept(V)
    A->>V: VisitElementA(this)
    V-->>A: [оброблено]

    Client->>B: Accept(V)
    B->>V: VisitElementB(this)
    V-->>B: [оброблено]
```

### Демонстраційний код

Див. папку VisitorDemo/ — консольний проект із реалізацією IVisitor, IElement, двома елементами та одним відвідувачем.

---

## Concurrency Pattern: Lock

Патерн **Lock** (м'ютекс) використовується для синхронізації доступу до спільних ресурсів у багатопотокових сценаріях. Він гарантує, що лише один потік виконує критичну секцію коду одночасно.

### UML-діаграма класів

```mermaid
classDiagram
    class SharedResource {
      -_counter: int
      +Increment(): void
      +GetCount(): int
    }

    class LockDemo {
      +RunDemo(): void
    }

    SharedResource o-- LockDemo : uses
```

### UML-діаграма послідовності

```mermaid
sequenceDiagram
    participant T1 as Thread1
    participant T2 as Thread2
    participant Res as SharedResource

    T1->>Res: Lock, Increment()
    Res-->>T1: Unlock

    T2->>Res: Lock, Increment()
    Res-->>T2: Unlock
```

### Демонстраційний код

Папка LockDemo/ містить консольний проект, де два потоки безпечним способом інкрементують спільний лічильник використовуючи lock.

---
