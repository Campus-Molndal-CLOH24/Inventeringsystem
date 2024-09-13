# Inventeringsystem
A simple project to manage products in your inventory.

# Project Background: How This Project Came to Be.
This project started as an assignment that we needed to submit to our professor. My first thought was to create an inventory system, which brought me back to when I worked at a clothing store. We often faced problems with inventory management. The staff said it was difficult for them to find the items they wanted. This experience inspired the idea for this project. As a beginner, I wanted to create something practical that could be applied to the real world. By using the knowledge I gained while learning object-oriented programming (OOP) concepts in C#, I focused on data types, algorithms, and sorting and searching products.  

# Development journey 
- At the Beginning: I started by writing down my overall idea for the project and removed any parts that weren’t really relevant. Then, I drew a class diagram by hand and moved on to the next step in my mind. I created two classes: Product and Inventory, to store variables and define constructors. The Product class represents basic information about a product (name, amount, and price).
- During the Journey: I took a simple approach, focusing on understanding my code and ideas clearly. I especially concentrated on implementing methods in small steps, testing each method individually. Initially, I used a linear search for finding products, but it was slow, so I switched to a binary search. To do that, I first wrote a selection sort method to order the products.
- Learning Challenges: Lists, loops, and algorithms were challenging, particularly the logic behind them. I feel that I still need more practice in this area.
-What I Learned: This project helped me understand basic algorithms better, like sorting (bubble sort, selection sort) and searching (linear search, binary search).

# Features. 
- Add Product : User can add a product with name, amount and price.
- Remove Product : User can remove product which they don't want it to store in their inventory by writes a product's name.
- View all product : Display all product on the list. 
- Sorting product by price : Display a product with sorting by a price.
- Search product : By using or give product name. 

# Class diagram 

# Class struture
- *Main Handles the user interface and menu interactions.
- *Product*: Represents individual products with properties like Name, Price, and Amount.
- *Inventory*: Contains methods to manage products, such as AddProduct, RemoveProduct, SearchProduct, and SortProduct.
 
# Future Development
The system could be improved to update the amount of a product if the user adds the same product with a different amount, instead of listing it as a new entry. This would allow the program to increase the existing product's quantity.
A graphical user interface (GUI) or a Windows form would make the program more user-friendly and visually appealing for potential buyers.

  
