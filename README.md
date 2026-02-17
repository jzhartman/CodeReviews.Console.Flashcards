# Flash Cards App

This is a simple, console based application for creating and studying stacks of flash cards.

## Description

The core unit in the Flash Cards App is a stack. A stack consists of individual, unique cards that have text on both sides.
A stack can be created or deleted by the user and must have a unique name. Users can add, edit, or delete cards within each stack.
A stack can be studied to test the user's recall. Assessment in performed by the user and reported to the console.
This is used to store the study session data, which can be retreived later.
Additionally, reports can be generated to provide the total number of sessions per mon, per year, by stack, as well as the average score per month, per year, by stack.

## Getting Started

### Technologies

* C# Console Project
* Spectre.Console
* SQL Server
* Dapper

### Initial Setup

* Clone Repository
* In FlashCards.App > appsettings.json update connection string to a valid SQL Server database
* Run the application to build the database and see with starter data

## Program Operation

### Main Menu
The main menu gets the list of stacks from the database and prints the name, card count, and study session count.
It then provides the following options:
* Review Cards in Stack
* Create New Stack
* Delete Stack
* Begin Study Session
* View Past Study Sessions
* View Reports
* Exit

Review Stack takes the user to the Review Stack Menu (see next section).

Creating a stack allows the user to enter a new stack name. Stack names must be unique and cannot be blank.

Deleting a stack will delete the stack, all cards contained in that stack, as well as all study sessions associated with it. This cannot be undone.

Beginning a study session will enter the study mode. In this mode, a stack is selected and the cards are randomly shuffled and shown to the user.
The user is able to assess their own results and the session is stored in the database.

Viewing past sessions prints a paginated list of all study sessions stored in the database.
Users can navigate through pages to view all sessions.
Sessions can be sorted by stack name, time, or score.

View reports will prompt the user for a year (based on existing study sessions within the database) and use it to generate two reports.
One will display the total number of sessions per month for that year organized by stack.
The other will display the average score per month for that year organized by stack.

Exit will close the application.

### Review Stack Menu
The Review Stack Menu is a submenu that enables the user to manage a single stack.
It provides the following options:

* Review Cards in Stack
* Add Card to Stack
* Edit Card Text
* Delete Card from Stack
* Return to Main Menu

Review Stack provides a way for the user to practice their ability to recall the card information.
Results are not recorded.

Create, Edit, And Delete cards allows the user to manage the individual cards within a stack.
All cards must have text on both sides.
Each card's front text must be unique compared to the front text of all other cards wtihin the stack, as should the back text.

Return to Main Menu returns to the main menu.

## Project Requirements
This project follows the guidelines for The C Sharp Academy Intermediate Console Application Flash Cards as found here: https://www.thecsharpacademy.com/project/14/flashcards
