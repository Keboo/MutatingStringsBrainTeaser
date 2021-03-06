# MutatingStringsBrainTeaser

To [quote Randall Munroe](http://xkcd.com/356/)
> There's a certain type of brain that's easily disabled. If you show it an interesting problem, it involuntarily drops everything else to work on it

This is a simple brain teaser in C# that asks you to simply mutate a string.
There are two unit tests that each make a couple assertions on a local string constant.

### Rules
1. The only changes that may be made to Tests.cs should be within the `CauseIdentityCrisis` methods.
2. No pre/post build steps. This can be done with only C# code.
3. No IL manipulation.
4. You are free to make any modifications outside the Tests.cs file that you see fit (hint, none are required, but creative solutions are always welcome)

### How about some hints?
[Hint 1](https://github.com/Keboo/MutatingStringsBrainTeaser/blob/master/MutatingStrings/MutatingStrings/MutatingStrings.csproj#L29)

[Hint 2](https://en.wikipedia.org/wiki/String_interning) 

### Solution
Though I recommend thinking on it rather than jumping straight to the solution. For those who have to know, [here it is](https://github.com/Keboo/MutatingStringsBrainTeaser/blob/solution/MutatingStrings/MutatingStrings/Tests.cs). You can see the full solution on the "solution" branch. (provided by [@savbace](https://github.com/savbace)).  

### But Why?
Because brain teasers are fun and I love C#. As a professional developer I love learning the details of how my favorite language and its compiler work. 
*I do __not__ recommend that anyone write code like this in a production application. This type of code is best left to brain teasers.*
