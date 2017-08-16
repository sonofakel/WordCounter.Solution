# _Word Counter_

#### _A web app that counts words, Aug 14, 2017_

#### By _**Charlie Kelson**_

## Description

_This web app will return how frequently a word appears in a given string. The user inputs the word to be checked as well as the string of words to check._

|  Behavior |  Input | Output  | Reasoning|
|----|----|----|------|
|  User enters a word and a sentence that doesn't contain the word and is returned 0, which is the number of time that words occurs in sentence   |   cats, I love dogs  |  0  |  This is the simplest behavior for the user to experience from the web app. They enter a word that is not in the long string of words and 0 is returned   |
|  User enters a word and a sentence that contains the word once and is returned 1, which is the number of times that words occurs in sentence    | lamp, I love lamp   |  1  |   Logical next step in increasing complexity. From hear we will see if the program can handle two words  |
|  User enters a word and a sentence that contains the word 2 times, 2 is returned | you, I love you and you love me  |  2  |  I didn't need to loop to find an occurrence of 1. 2 is the next logical step as the program increases in complexity.      |
|  User enters a partial word and a sentence that contains the full word and 0 is returned | ho, I love house   | 0   | This was a requirement of the the app and I tacked this after I knew that the program could handle multiple words.    |
|  User enters a word in capital letters and a sentence that contains the word in lower-case and 1 is returned | BUNNY, I see a bunny.   | 1   |  Wanted to make sure the program could handle capital words. This was more of a qa spec and seemed appropriate as the last spec.   |





## Setup/Installation Requirements

* _Clone repo and set up .NET dependencies to view locally_


## Known Bugs

_No known Bugs_



## Technologies Used

* _ASP.NET MVC_

### License

MIT License

Copyright (c) 2015 **_Charlie Kelson_**
