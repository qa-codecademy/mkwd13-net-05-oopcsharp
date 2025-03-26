# Rock Paper Scissors

## Requirements for Rock Paper Scissors Game


### 1. Game Overview
* The game allows the user to play against the computer.

* The user can choose one of the three options: Rock, Paper, or Scissors.

* The computer randomly selects one of these three options.

* The game will determine the winner based on the classic rules:

    * Rock beats Scissors.

    * Scissors beats Paper.

    * Paper beats Rock.

### 2. Functional Requirements

* User Input:

    * The user should be able to choose Rock, Paper, or Scissors by typing a corresponding option.

    * The program should handle invalid inputs and prompt the user for a correct choice if necessary.

* Computer AI:

    * The computer will randomly choose between Rock, Paper, and Scissors.

* Decision Logic:

    * The program must compare the user's choice with the computer's choice and decide the outcome:

        * Rock vs Scissors → Rock wins.

        * Scissors vs Paper → Scissors wins.

        * Paper vs Rock → Paper wins.

        * Identical choices result in a tie.

* Display Results:

    * The program should display:

        * The user’s choice.

        * The computer’s choice.

        * The result (win, lose, or tie).

* Play Again Option:

    * After each game, the user should be prompted whether they want to play again or exit the game.

### 3. Non-Functional Requirements
* Error Handling:

    * The program should handle any invalid inputs gracefully (e.g., incorrect spelling, unexpected input).

    * The game should prompt the user again for a valid input in case of invalid choices.

* User Interface:

    * The game will be text-based (command-line interface).


### 4. Game Flow
* Display a welcome message and explain the game rules.

* Prompt the user to choose Rock, Paper, or Scissors.

* The computer randomly selects Rock, Paper, or Scissors.

* Determine the winner and display the result.

* Ask the user if they want to play again. If yes, repeat from step 2. If no, exit the game.


###  Bonus Features (Optional)
* Scorekeeping: Keep track of the number of wins, losses, and ties.

* Multiple Rounds: Allow the user to play multiple rounds and keep track of the score across rounds.
