´´´mermaid
classDiagram
    class Program {
        + Program prog
        Program()
        Start()
        ShowMenu()
        InsertPlayer()
        ListPlayers()

    }
    class PlayerOrder {
        + ByScore = 1
        + ByName = 2
        + ByNameInverse = 3
    }
    class Player {
        string Name
        int Score
        string ToString()
        int CompareTo()
    }
    
    class CompareByName {
        +bool ord
        int Compare()
        CompareByName()
    }

    Program o-- PlayerOrder
    Program o-- CompareByName
    Program *-- Player
    CompareByName <-- Player
