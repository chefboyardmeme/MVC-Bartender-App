# MVC-Bartender-App
The following provides an overview of how the user request is handled:
1. Index page that acts as a homepage for Bartender application from where patrons can access order
option and from where bartenders can access order queue option.
2. A controller that receives the user request as an HTTP GET or POST request.
3. The controller examines the user request and calls the model asking it to return the cocktails bar
menu.
4. The model is responsible for getting menu information from the database.
5. The controller will use the appropriate view to display cocktail menu data to the user.
6. The user reviews the menu and places an order for a cocktail drink.
7. The controller examines user request and the parameters and calls the model asking it to store
cocktail order information in the database.
8. When the bartender chooses the order queue option in the index page, the controller examines the
user request and calls the model asking it to return the list of cocktail orders.
9. The model is responsible for getting cocktail order information from the database.
10. The controller will use the appropriate view to display cocktail orders to the user
