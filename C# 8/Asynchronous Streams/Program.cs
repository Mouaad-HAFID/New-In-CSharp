/*
Starting with C# 8.0, you can create and consume streams asynchronously. A method that returns an asynchronous stream has three properties:

    1-It's declared with the async modifier.
    2-It returns an IAsyncEnumerable<T>.
    3-The method contains yield return statements to return successive elements in the asynchronous stream.
*/

using System.Collections;
using System.Threading;

static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
{
    for (int i = 0; i < 20; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}

await foreach (var number in GenerateSequence())
{
    Console.WriteLine(number);
}