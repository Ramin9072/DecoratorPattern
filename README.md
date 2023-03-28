Okay, we’ve seen that representing our beverage and condiments with inheritance has not worked out very well—we get class explosions and rigid designs, or we add functionality to the base class that isn’t appropriate for some of the subclasses.So, here’s what we’ll do instead: we’ll start with a beverage and “decorate” 
it with the condiments at runtime. For example, if the customer wants a Dark Roast with Mocha and Whip, then we’ll

1- Start with a DarkRoast object.
2- Decorate it with a Mocha object.
3- Decorate it with a Whip object.
4- Call the cost() method and rely on delegation to 
5- add up the condiment costs

Okay, but how do you “decorate” an object, and how does delegation  come into this? A hint: think of decorator objects as “wrappers.” Let’s see  how this works..

1- We start with our DarkRoast object.
      
2- The customer wants Mocha, so we create a Mocha   object and wrap it around the DarkRoast.

3- The customer also wants Whip, so we create a Whip decorator and wrap Mocha with it.

4- Now it’s time to compute the cost for the customer. We do this by calling cost() on the outermost decorator, Whip, and Whip is going to delegate computing the cost to the objects it decorates. And so on.

read more in this book 
Head First Design Patterns, 2nd Edition by Elisabeth Robson, Eric Freeman-O'Reilly
  ** PAGE 70 **
