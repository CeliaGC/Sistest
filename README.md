# Sistest

This repository contains consisting in a console application ready to be build and check the results for 3 exercises in the context of a technical test. In the PDF
there can be found the exercises statements.

## Setup Instructions

### Prerequisites
- MariaDB or MySQL installed
- .NET SDK installed

### Step 1: Set Up the Database

1. Clone this repository
2. Open your MariaDB or MySQL client (e.g., phpMyAdmin, MySQL Workbench, command line).
3. Run the `setup.sql` script provided in the repository to create the necessary tables and insert sample data.

mysql -u root -p < setup.sql

### Step 2: Update de connection string

1. Open the C# project in your preferred IDE (e.g., Visual Studio).
2. Locate the file where the connection string is defined (Exercise3.cs, line 14).
3. Update the connection string with your database details:

string connectionString = "Server=your_server;Database=your_database_name;User=your_user;Password=your_password;Port=your_port;SslMode=your_ssl_mode";

### Step 3: Run the project

1. Build and run the project from your IDE.
2. The output should display the results of exercises in your console window. Try to give different inputs by modifying the arguments given 
to each function in Program.cs
3. Have fun!

## Project Structure

- Exercises: Contains three classes, one for each exercise, with the logic to obtain de required results for each of them.
- Program.cs: The main entry point of the application where the solution is compiled and inputs are provided to the functions.
- setup.sql: SQL script to set up the database schema and insert initial data for exercise 3



Contact
For any questions or issues, please open an issue or contact me at garciacastillacelia@gmail.com .




