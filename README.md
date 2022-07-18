# Notice
Since the end of March 2021, this is no longer usable without obtaining an older format of the game's save data and modifying it to your liking. Once you've done this, delete the newly converted save data and replace it with the old version that you just modified.

Details and an older version of save data can be found here: https://www.phasmosaveedit.xyz.

## PhasmophobiaSaveEditor
C# application to read/parse and edit save data for the game Phasmophobia.

## About
As simply stated above, this is a program that can read and parse Phasmophobia save data. This is relatively easy to do, if you've ever looked into the game's assembly (especially when it wasn't compiled with IL2CPP) you might've noticed that the data was XOR ciphered, and naturally it was easy to undo.

I have added saving capabilities to the project. Although, as it is still potentially dangerous to your progress if you make an error while editing, and is also a console application, I would still suggest [Phasmosave](https://phasmosave.com). If, on the other hand, you purely want to be able to read and export data, then please look at [this commit](https://github.com/NeoInversion/PhasmophobiaSaveEditor/tree/19be029029ec84aefe496b307de8e9dd932abeb1).

## Dependencies
If you want to build from source, you will need [JSON.Net](https://github.com/JamesNK/Newtonsoft.Json).
