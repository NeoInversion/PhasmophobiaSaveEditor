# PhasmophobiaSaveEditor
C# application to read/parse and edit save data for the game Phasmophobia.

## About
As simply stated above, this is a program that can read and parse Phasmophobia save data. This is relatively easy to do, if you've ever looked into the game's assembly (especially when it wasn't compiled with IL2CPP) you might've noticed that the data was XOR ciphered, and naturally it was easy to undo.

I have added saving capabilities to the project. Although, as it is still potentially dangerous to your progress if you make an error while editing, and is also a console application, I would still suggest [Phasmosave](https://phasmosave.com).