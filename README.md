# BlairConsoleApp_BeforeRefactoring
This is demonstrating the first SOLID principle, the Single Responsibility Principle. This is a console app I have written to figure out how much change should be returned to a customer making a purchase.  This project is all in one file - the "before" picture.  

The Single Responsibilty Principle -

The concept is simple: A class or module should have one, and only one, reason to be changed.
This principle states that if we have 2 reasons to change for a class, we have to split the functionality in two classes. Each class will handle only one responsibility and if in the future we need to make one change we are going to make it in the class which handles it.

"Gather together the things that change for the same reasons. Separate those things that change for different reasons."

For instance, if you have a rectangle class that 1) Draws rectangles and 2) Calculates the area of rectangles, it needs to be refactored.

"Just because you can, doesn't mean you should."
https://www.linkedin.com/pulse/20140831133231-206881211-the-single-responsibility-principle
