//Indices and ranges provide a concise syntax for accessing single elements or ranges in a sequence (array...)
//This relies on two new types and operators:
/*
    1-System.Index represents an index into a sequence.
    2-The index from end operator ^, which specifies that an index is relative to the end of the sequence.
    3-System.Range represents a sub range of a sequence.
    4-The range operator .., which specifies the start and end of a range as its operands.
*/

//The ^0 index is the same as sequence[sequence.Length]
//sequence[^0] throws an exception
// For any number n, the index ^n is the same as sequence.Length - n

//A range specifies the start and end of a range. The start of the range is inclusive, but the end of the range is exclusive.

var words = new string[]
{
                // index from start    index from end
    "The",      // 0                   ^9
    "quick",    // 1                   ^8
    "brown",    // 2                   ^7
    "fox",      // 3                   ^6
    "jumped",   // 4                   ^5
    "over",     // 5                   ^4
    "the",      // 6                   ^3
    "lazy",     // 7                   ^2
    "dog"       // 8                   ^1
};              // 9 (or words.Length) ^0

Console.WriteLine($"The last word is {words[^1]}");
// writes "dog"

//The following code creates a subrange with the words "quick", "brown", and "fox". It includes words[1] through words[3]. The element words[4] isn't in the range.
var quickBrownFox = words[1..4];

//The following code creates a subrange with "lazy" and "dog". It includes words[^2] and words[^1]. The end index words[^0] isn't included
var lazyDog = words[^2..^0];

//Open ended examples
var allWords = words[..]; // contains "The" through "dog".
var firstPhrase = words[..4]; // contains "The" through "fox"
var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

//Ranges can be declared inside variables
Range phrase = 1..4;

//The ranges can then be used within brackets
var text = words[phrase];