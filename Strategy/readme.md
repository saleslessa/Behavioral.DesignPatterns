# Strategy Pattern simple example

This code contains an example of a design pattern called Strategy.
Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

Basically this pattern contains three actors (or roles):
- IStrategy: The interface in which the concrete alternatives should implement.
- Concrete Implementations: Classes that offers alternatives to the algorithm (replacing if/elses throughout the code).
- Context: The class in which the code runs an would have the if/else chain (that we are trying to solve).

