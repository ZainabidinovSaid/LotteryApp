Lottery Number Simulator

A simple C# console application that simulates a lottery draw, compares the player's numbers with randomly generated winning numbers, and saves game results to a file.

Features

-User enters 6 unique numbers from 1 to 49

-Program generates 6 random winning numbers

-Calculates how many numbers matched

-Saves game results to results.txt

-Allows user to view past statistics

-Simple menu interface

-Uses:

    --Arrays

    --Loops

    --Conditional statements

    --File I/O

    --Classes & OOP

Project Structure: 

LotteryApp/
│── Program.cs
│── LotteryGame.cs
│── StatisticsManager.cs
│── results.txt      // auto-created after first game
│── README.md
│── LotteryApp.csproj

How to Run
1. Install .NET SDK

Download the .NET SDK from:
https://dotnet.microsoft.com/en-us/download

Check installation:

dotnet --version

2. Run the project

Inside the project folder:

dotnet run


You will see:

===== Lottery Number Simulator =====
1. Play
2. View Statistics
3. Exit

Example Gameplay
Введите 6 чисел от 1 до 49:
Число 1: 5
Число 2: 12
Число 3: 19
Число 4: 25
Число 5: 33
Число 6: 44

Ваши числа:       5, 12, 19, 25, 33, 44
Выигрышные числа: 7, 12, 19, 30, 33, 48
Совпадений: 3

Результат сохранен в файл results.txt

File Output Example (results.txt)
---- Новая игра ----
Выбор пользователя: 5, 12, 19, 25, 33, 44
Выигрышные номера:  7, 12, 19, 30, 33, 48
Совпадений: 3
Дата: 11/29/2025 17:58:10
