// The Context defines the interface of interest to clients.
using System;
using System.Collections.Generic;

class Context
{
    public Context()
    { }
     
    // The Context delegates some work to the Strategy object instead of
    // implementing multiple versions of the algorithm on its own.
    public void DoSomeBusinessLogic(IStrategy strategy)
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
        var result = strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

        string resultStr = string.Empty;
        foreach (var element in result as List<string>)
        {
            resultStr += element + ",";
        }

        Console.WriteLine(resultStr);
    }
}