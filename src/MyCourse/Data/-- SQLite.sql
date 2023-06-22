-- SQLite
CREATE TABLE Courses (
    Id     INTEGER NOT NULL CONSTRAINT PK_Courses PRIMARY KEY AUTOINCREMENT,
    Title   TEXT (100) NOT NULL,
    Description   TEXT (10000) NOT NULL,
    ImagePath     TEXT (100) NOT NULL,
    Author   TEXT (100) NOT NULL,
    Email   TEXT (100) NOT NULL,
    Rating  REAL  NOT NULL DEFAULT (0),
    FullPrice_Amount  Numeric  NOT NULL DEFAULT (0),
    FullPrice_Currency  TEXT(3)  NOT NULL DEFAULT ('EUR'),
    CurrentPrice_Amount  Numeric  NOT NULL DEFAULT (0),
    CurrentPrice_Currency  TEXT(3)  NOT NULL DEFAULT ('EUR')

);