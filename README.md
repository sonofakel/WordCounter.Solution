# _Word Counter_

#### _A web app that counts words, Aug 14, 2017_

#### By _**Charlie Kelson**_

## Description

_This web app will return how frequently a word appears in a given string. The user inputs the word to be checked as well as the string of words to check._

|  Behavior |  Input | Output  | Reasoning|
|----|----|----|------|
|  User enters a word and a sentence that doesn't contain the word and is returned 0, which is the number of time that words occurs in sentence   |   cats, I love dogs  |  0  |  This is the simplest behavior for the user to experience from the web app. They enter a word that is not in the sentence and 0 is returned   |
|  User enters a word and a sentence that contains the word once and is returned 1, which is the number of times that words occurs in sentence    | lamp, I love lamp   |  1  |   Logical next step in increasing complexity  |
|  User enters a word and a sentence that contains the word n number of times and is returned n, which is the number of times that words occurs in sentence  | I love n, n   |  n  |  Logical next step in increasing complexity     |
|  User enters a partial word and a sentence that contains the full word and 0 is returned | ho, I love house   | 0   |  Logical next step in increasing complexity   |
|  User enters a word in capital letters and a sentence that contains the word in lower-case and 1 is returned | BUNNY, I see a bunny.   | 1   |  Logical next step in increasing complexity   |




## Setup/Installation Requirements

* _Clone repo and set up .NET dependencies to view locally_


## Known Bugs

_No known Bugs_



## Technologies Used

* _ASP.NET MVC_

### License

Copyright (c) 2015 **_Charlie Kelson_**
