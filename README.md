# ATM Simulator (Bancomat2)

## Overview

**Bancomat2** is a Windows Forms ATM simulator written in C# that
connects to a SQL Server database. The application allows users to
authenticate using a PIN and perform basic ATM operations such as:

-   Login using PIN
-   Deposit money
-   Withdraw money
-   Transfer money to another account via IBAN
-   View current account balance

The system interacts with a SQL Server database (`AtmDB`) that stores
user information including PIN, IBAN, and account balance.

------------------------------------------------------------------------

# Features

## Authentication

-   Users log in using a **PIN code**
-   The application verifies the PIN against the **Users table** in the
    database
-   If valid:
    -   The user gains access to ATM operations
    -   Their balance is displayed
-   If invalid:
    -   An error message is shown

------------------------------------------------------------------------

## Deposit Money

Users can deposit money into:

### Personal Account

Funds are added to the logged-in user's account.

### Another Account

Users can deposit money into another account using an **IBAN**. The
application checks if the IBAN exists in the database.

### Currency Conversion

Deposits can be made in:

-   RON
-   USD
-   EUR

Conversions used:

    USD → RON = * 4.63
    EUR → RON = * 4.98

------------------------------------------------------------------------

## Withdraw Money

Users can withdraw money using:

-   Fixed withdrawal amounts
-   Custom withdrawal amount

Validation checks:

-   Withdrawal amount must not exceed the available balance.
-   Custom withdrawal must contain a valid numeric value.

------------------------------------------------------------------------

## Balance Display

After login the application displays the current balance.

------------------------------------------------------------------------

# Database Structure

## Database

    AtmDB

## Table: Users

  Column   Type      Description
  -------- --------- -------------------------
  Id       int       User ID
  Pin      varchar   User PIN
  IBAN     varchar   Bank account IBAN
  Sold     double    Current account balance

------------------------------------------------------------------------

# Technologies Used

-   C#
-   Windows Forms
-   SQL Server
-   ADO.NET
-   .NET Framework

------------------------------------------------------------------------

# Database Connection

The application connects to SQL Server using a connection string.

Example:

conn = new SqlConnection(
"Server=.;Database=AtmDB;Trusted_Connection=True;");

Depending on your SQL Server installation, you may need to modify the connection string.

------------------------------------------------------------------------

# Application Workflow

### 1. Start Application

-   ATM interface loads
-   Login controls are active

### 2. Enter PIN

-   PIN is entered using numeric buttons

### 3. Authentication

-   Application checks database
-   If valid → unlocks ATM operations

### 4. Select Operation

User can choose:

-   Deposit
-   Withdraw
-   View balance

### 5. Perform Transaction

Database updates user balance accordingly.

------------------------------------------------------------------------

# Input Validation

The application includes several validation rules:

-   Numeric input only for amounts
-   Alphanumeric characters only for IBAN
-   IBAN must be **24 characters**
-   Withdrawal cannot exceed available funds

------------------------------------------------------------------------

# How to Run

1.  Clone or download the project
2.  Open it in **Visual Studio**
3.  Ensure **SQL Server Express** is installed
4.  Create the database `AtmDB`
5.  Create the `Users` table
6.  Update the connection string if necessary
7.  Run the application

------------------------------------------------------------------------

# Example User Record

``` sql
INSERT INTO Users (Pin, IBAN, Sold)
VALUES ('1234', 'RO49AAAA1B31007593840000', 1000);
```

------------------------------------------------------------------------

# Author

ATM Simulator project for learning **C#, Windows Forms, and SQL Server
database interaction**.
