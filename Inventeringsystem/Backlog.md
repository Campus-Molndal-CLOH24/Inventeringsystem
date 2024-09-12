# Backlog
**i got this from chatgpt which help me to create a backlog for my project**

# Backlog för inventeringssystem

1. Skapa grundläggande klasser och strukturer
[Prioritet: Hög] Skapa klassen Product:

- Attribut: id, name, quantity, price.
- Skapa en konstruktor för att initiera dessa attribut.
- Skapa getters och setters för varje attribut.

2. [Prioritet: Hög] Skapa klassen Inventory:
- Attribut: En lista (List<Product>) för att hantera produkterna.
- Detta är den grundläggande strukturen för att lagra produkter i systemet.
3. Implementera grundläggande operationer
[Prioritet: Hög] Metod: addProduct:

Syfte: Lägga till en produkt till inventeringen.
Kontrollera att produkten inte redan finns innan du lägger till den.
[Prioritet: Hög] Metod: removeProduct:

Syfte: Ta bort en produkt från inventeringen baserat på produktens ID eller namn.
Hitta produkten i listan och ta bort den.
[Prioritet: Medel] Metod: listProducts:

Syfte: Lista alla produkter i inventeringen.
Iterera genom listan och skriv ut informationen om varje produkt.
3. Utöka funktionaliteten
[Prioritet: Medel] Metod: searchProduct:

Syfte: Sök efter en specifik produkt baserat på namn eller ID.
Returnera produkten om den finns, eller meddela att den inte hittades.
[Prioritet: Låg] Metod: updateQuantity:

Syfte: Uppdatera mängden av en specifik produkt i inventeringen.
Hitta produkten och uppdatera dess quantity.
4. Implementera sortering
[Prioritet: Låg] Metod: sortProductsByName:

Syfte: Sortera produkterna i listan efter namn i alfabetisk ordning.
Använd Collections.sort() eller List.sort() och en Comparator baserat på name.
[Prioritet: Låg] Metod: sortProductsByPrice:

Syfte: Sortera produkterna baserat på deras pris (lägsta till högsta eller vice versa).
Använd liknande metod som för sortering efter namn.
5. Testa programmet
[Prioritet: Hög] Testa addProduct, removeProduct och listProducts:

Skapa några produkter och lägg till dem i inventeringen.
Lista produkterna för att se att de är korrekt tillagda.
Testa att ta bort en produkt och lista igen för att se till att borttagningen fungerar.
[Prioritet: Medel] Testa searchProduct:

Sök efter en specifik produkt och kontrollera att rätt produkt returneras.
Testa både befintliga och icke-existerande produkter.
[Prioritet: Låg] Testa sorteringsfunktionerna:

Lägg till produkter med olika namn och priser och kontrollera att de sorteras korrekt.
6. Finslip och optimera
[Prioritet: Låg] Lägg till fler testfall för att säkerställa att alla metoder fungerar under olika förutsättningar (tom lista, lista med flera produkter, etc.).
[Prioritet: Låg] Förbättra användargränssnittet genom att göra utskrifterna tydligare och lättare att förstå för användaren.
Sammanfattning av prioriteringar:
Hög prioritet (bör göras först):

Skapa klasserna Product och Inventory.
Implementera metoderna addProduct, removeProduct, och listProducts.
Testa dessa metoder grundligt.
Medelhög prioritet (kan göras efter grundläggande funktioner är klara):

Implementera searchProduct.
Uppdatera produktkvantiteten med updateQuantity.
Testa sök- och uppdateringsmetoderna.
Låg prioritet (kan göras mot slutet eller som extra funktionalitet):

Implementera sorteringsmetoder (sortProductsByName och sortProductsByPrice).
Finslipa testfall och förbättra användargränssnittet.