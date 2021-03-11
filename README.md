# ShipIt Inventory Management

## Setup Instructions
Open the project in VSCode.
You will be prompted to restore/install dependencies - click yes, OK, restore, however it's worded!
This should set up and install everything you'll need apart from the database connection!

### Setting up the Database.

- First, you need to install PostgreSQL if you don't already have it: https://www.postgresql.org/download/
- During installation, there's no need to change any of the default settings (such as the port).
- Once you get to the part where you're prompted to install Stack Builder, you can stop!
- You will now have an application called SQL Shell (psql) installed which is a terminal used to communicate with PostgreSQL servers.

The next step is to create the databases we need. You can create databases either in the psql terminal (see https://gist.github.com/Kartones/dd3ff5ec5ea238d4c546 for some useful commands) or you can use a GUI to communicate with the server visually. A good one is PgAdmin (https://www.pgadmin.org/download/).

When opening psql, you will be prompted to enter some details. You can enter the default values: server = localhost, database = postgres, port = 5432, username = postgres, password = whatever you set during installation. After this point, you can create 2 new Postgres databases - one for the main program and one for our test database (you could call them MainDb and TestDb, for example).

To create a new database, enter the line:
```
CREATE DATABASE MyDatabase;
```
where MyDatabase is the name of the database you want to create.

You can then connect to this database by entering the line:
```
\c MyDatabase
```

Once you've connected your database, ask a team member for a dump of the production databases - the dump is a .sql file which will create and populate the tables of your database. You can do this by running the command:
```
\i C:/Documents/example-dump-file.sql
```
where the second argument is the absolute file path to the dump file.

### Connecting the database to the project

Then in both the ShipIt and ShipItTest folders in the codebase, create a `.env` file. The file should contain a property named `POSTGRES_CONNECTION_STRING`.
It should look something like this:
```
POSTGRES_CONNECTION_STRING=Server=127.0.0.1;Port=5432;Database=your_database_name;User Id=your_database_user; Password=your_database_password;
```

You will need to change your_database_name according to which folder the file is in (e.g. TestDb for the ShipItTest folder), and change the User Id and Password to the correct credentials. It would be wise to add these `.env` files to your `.gitignore` so that you don't share your password by committing these files to Github!

## Running The API
Once set up, simply run dotnet run in the ShipIt directory.

## Running The Tests
To run the tests you should be able to run dotnet test in the ShipItTests directory.

## Deploying to Production
TODO
