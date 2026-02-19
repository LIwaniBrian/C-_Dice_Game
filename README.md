🎲 Dice Game (C# Console Application)
📌 Overview

This is a simple C# console-based dice game where a player competes against an opponent (computer).

The game runs for 10 rounds.
Each round:

The player rolls a dice (1–6)

The opponent rolls a dice (1–6)

The higher number wins the round

Points are tracked

Final winner is announced at the end

🧠 How It Works

Uses the Random class to generate dice rolls

Uses a for loop to run 10 rounds

Tracks score using integer counters

Uses conditional logic (if / else if / else) to determine the winner

Adds delay with Thread.Sleep() for better user experience

🛠 Technologies Used

C#

.NET Console Application

System namespace

Basic OOP structure

🎮 Game Flow

Player presses any key to roll the dice

Player roll is displayed

Opponent roll is generated

Round winner is announced

Score updates

After 10 rounds → final winner is displayed

📷 Example Output
Press any key to roll the dice
You rolled a 4
Opponent rolled a 2
Player wins this round
The score is now - Player: 1. Enemy: 0

🚀 How To Run

Clone the repository:

git clone https://github.com/LiwaniBrian/C-_Dice_Game.git


Open the project in Visual Studio or VS Code

Run the project:

dotnet run

📚 What I Learned

Working with random number generation

Using loops and conditional logic

Managing program flow

Basic game logic implementation

Improving console user interaction

🔥 Future Improvements

Add input validation

Allow custom number of rounds

Convert to object-oriented structure (separate Dice class)

Add replay option

Improve UI formatting

👨‍💻 Author

Brian Liwani
Aspiring Backend C# Developer
