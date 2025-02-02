# Pustaka Console System
_"Your one stop solution for pus (library) system, now on the console!"_

## Usage

((work in progress))

## User Classification

### Pustakawan (administrator)

Abilities:
* Create, Read, Update, and Delete books from the book database
* Update total of the book item stock
* Create a borrowing/returning transaction

### Anggota (member)

Abilities:
* Create a borrowing/returning transaction

Abilities:
((work in progress))

## Diagram

```mermaid

erDiagram
    BOOKINFO {
        string ISBN
        string Title
        string Author
    }
    ITEM {
        string ID
        string ISBN
        Availability Status
    }
    USER {
        string Username
        UserCategory Cat
    }
    TRANSACTION {
        string ID
        string Username
        TransactionKind Kind
        string ItemID
    }

    ITEM }o--|| BOOKINFO : "has one"
    TRANSACTION ||--|| ITEM : "has one"
    TRANSACTION ||--|| USER : "has one"

```