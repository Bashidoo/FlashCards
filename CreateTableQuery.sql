CREATE TABLE Users (
    UserID INT PRIMARY KEY,  
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE FlashCards (
    FlashCardID INT PRIMARY KEY,
    FlashCardName NVARCHAR(100) NOT NULL,
    FlashCardDescription NVARCHAR(255),
    FlashCardQuestion NVARCHAR(255) NOT NULL,
    FlashCardAnswer NVARCHAR(255) NOT NULL,
    FlashCardDifficultyLevel INT NOT NULL CHECK (FlashCardDifficultyLevel > 0),
    FlashCardInterval DATE NOT NULL,
    CategoryID INT NOT NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
