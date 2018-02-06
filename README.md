# hanggirl
A text-based hangman game

The computer player should start by secretly selecting a word from a dictionary of known words. 

The display should include the following:
A secret word. This will initially be a set of underscores - one for each letter. As the game progresses, underscores will be replaced with the known letters.

An ascii-art gallows. As the game progresses, a person will be drawn in under the gallows indicating the number of incorrect guesses.

A list of previously guessed letters (correct and incorrect)

A prompt asking the user to select a letter.

Gameplay:
Each time the user guesses, the screen is refreshed.
If the user guesses a non-letter or a letter that has already been guessed, there is no change in the game.
If the user guesses a letter that is in the secret word, all instances of the letter are revealed in the secret word and the guessed letter is added to the list of guesses.
If the user guesses a letter that is not i nthe secret word, a new piece of the hanging character is drawn.

If the entire hanging character is drawn, the game ends in a reported loss.
If the entire secret word is revealed, the game ends in a reported win.

After the game ends, the user should be prompted to play again or quit.
