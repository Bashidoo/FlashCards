INSERT INTO Users (UserID, UserName, Email, Password) VALUES
(1, 'Alice Johnson', 'alice@example.com', 'AlicePass123'),
(2, 'Bob Smith', 'bob@example.com', 'BobPass456'),
(3, 'Charlie Brown', 'charlie@example.com', 'CharliePass789'),
(4, 'David White', 'david@example.com', 'DavidPass012'),
(5, 'Eve Black', 'eve@example.com', 'EvePass345'),
(6, 'Frank Green', 'frank@example.com', 'FrankPass678'),
(7, 'Grace Lee', 'grace@example.com', 'GracePass901'),
(8, 'Henry Adams', 'henry@example.com', 'HenryPass234'),
(9, 'Ivy Scott', 'ivy@example.com', 'IvyPass567'),
(10, 'Jack Miller', 'jack@example.com', 'JackPass890');

INSERT INTO Categories (CategoryID, CategoryName) VALUES
(1, 'Mathematics'),
(2, 'Science'),
(3, 'History'),
(4, 'Geography'),
(5, 'Programming'),
(6, 'English Vocabulary'),
(7, 'Physics'),
(8, 'Chemistry'),
(9, 'Biology'),
(10, 'Economics');

INSERT INTO FlashCards (FlashCardID, FlashCardName, FlashCardDescription, FlashCardQuestion, FlashCardAnswer, FlashCardDifficultyLevel, FlashCardInterval, CategoryID) VALUES
(1, 'Basic Addition', 'Simple math problem', 'What is 5 + 3?', '8', 1, '2025-02-01', 1),
(2, 'Water Boiling Point', 'Physical science question', 'At what temperature does water boil?', '100°C', 2, '2025-02-02', 2),
(3, 'First U.S. President', 'History trivia', 'Who was the first President of the United States?', 'George Washington', 2, '2025-02-03', 3),
(4, 'Capital of France', 'Geography question', 'What is the capital of France?', 'Paris', 1, '2025-02-04', 4),
(5, 'C# Loop Types', 'Programming basics', 'Which loop in C# is used when the number of iterations is known?', 'for loop', 3, '2025-02-05', 5),
(6, 'Antonym of Happy', 'Vocabulary test', 'What is the antonym of "Happy"?', 'Sad', 1, '2025-02-06', 6),
(7, 'Newton’s First Law', 'Physics concept', 'What does Newton’s First Law state?', 'An object in motion stays in motion...', 3, '2025-02-07', 7),
(8, 'Periodic Table Element', 'Chemistry question', 'What is the symbol for Gold?', 'Au', 2, '2025-02-08', 8),
(9, 'DNA Structure', 'Biology question', 'What is the shape of a DNA molecule?', 'Double helix', 2, '2025-02-09', 9),
(10, 'Supply and Demand', 'Economics principle', 'What happens to price when demand increases and supply remains constant?', 'Price increases', 3, '2025-02-10', 10);
