# Backlog
**i got this from chatgpt which help me to create a backlog for my project**

# Backlog för inventeringssystem

| Steg | Klass | Klass | Beskrivning | Testmål |
|-----------------|-----------------|-----------------|
| 1 | Product | Konstruktor | Skapa konstruktorn för klassen Product med attribut som namn, kategori och pris. |Kontrollera att ett objekt kan skapas med korrekta värden. |
| 2 | Product | Getters/Setters |Implementera getters och setters för varje attribut. |Verifiera att attributen kan hämtas och ändras korrekt. |
| 3| Inventory | Konstruktor |Skapa klassen Inventory med en tom lista för att lagra Product-objekt. |Se till att en tom lista skapas vid objektinitiering. |
| 4 | Inventory  | AddProduct() |Skapa en metod som tar emot ett Product-objekt och lägger till det i listan. |Kontrollera att objektet kan läggas till listan korrekt. |
| 5 | Inventory  | RemoveProduct() |Implementera en metod för att ta bort ett objekt baserat på dess namn eller ID från listan. |Testa att ett objekt tas bort korrekt från listan. |
| 6 | Inventory | ListAllProducts() |Skapa en metod som returnerar alla objekt i listan och deras detaljer. |Verifiera att alla objekt kan visas korrekt. |
| 7 | Inventory  | SearchProduct() |Implementera en sökmetod som söker efter ett objekt baserat på namn eller kategori. |Se till att sökningen fungerar och returnerar korrekt resultat. |
| 8 | Inventory  | SortProducts()|Implementera en metod för att sortera listan baserat på ett attribut (t.ex. pris eller namn). |Testa att sorteringen fungerar korrekt. |
| 9 | Main | Menu() |Skapa en meny i Main som låter användaren interagera med de olika funktionerna (lägga till, ta bort, visa, söka, sortera). |Kontrollera att användaren kan navigera mellan de olika alternativen. |
| 10 | Main | RunProgram() |Implementera en metod för att köra programmet, inklusive att läsa indata från användaren och kalla på rätt metoder i Inventory. |Verifiera att hela flödet från inmatning till resultat fungerar korrekt. |