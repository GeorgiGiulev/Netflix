Registration Page: Contains a username, password , and re-type password boxes with validations, "sign in" button, which is linked to the SQL server and a "login" button if you already have an account;

Login Page: usernam and password boxes, when the user enters the mathcing information with the sql table, the "enter" button will let him enter the next page; there is also a "back" button, which transfers back to the register page

Filter Page: with three filters for FilmType, Category, and AgeRating; the "search" button combines the selected filters and se3arches for such a row in the sql table; the "clear" button clears all selected filters and the listView; if you double click on a cell on the listView, it will enter the purchasing page with the same filters as the ones on the row of the cell clicked.

Purchasing page: the purchasing page contains the preselected filters and the user needs to enter card details: name, card number, expiry date, and CVV to make the purchase. The details are stored in the sql database's table
