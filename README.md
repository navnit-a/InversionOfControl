# Inversion Of Control

Dependency Inversion Principle (DIP)
- Principle used in architecting software
- Instead of lower level module defining an interface that higher level modules depend on, higher modules define an interface that lower level modules implement
- Bob's paper: High-level modules should not depend on low-level modules. Both should depend on abstractions.
- Abstractions should not depend upon details. Details should depend upon abstractions.
- By inverting controls, we are protecting the system against changes

Inversion of Control (IoC)
- Specific pattern used to invert interfaces, flow and dependencies

Dependency Injection (DI) 
- Implementation of IoC invert dependencies

Inversion of Control Container
- Framework to do  dependecy injection

Fitting it All Together
- Dependency Inversion (Principle)
- Inversion of Control (Pattern-ish)
- Interface Inversion, Flow Inversion, Dependency Creation/ Binding Inversion - Dependency Injection (Implementation)	

Types of Creation Inversion
- Factory Pattern - Button button = ButtonFactory.CreateButton();
- Service Locator (you ask for something, it goes and finds it for you) - Button button = ServiceLocator.Create(IButton.class)
- Dependency Injection - Button button = GetTheRightButton(); - OurScreen screen = new OurScreen(button); - passing it in the constructor (constructor injection in this case)

Types of Injections
- Constructor Injection
- Setter Injection
- Interface Injection (unpopular)

DI Caution! 
- Leaks the internal implementation details of a class. (Violates encapsulation | Injections "guts" into class)
- Prevents deferred creation (Dependencies created before needed | Watch out for large object graphs)
- Numbs you from the pain (Easier to unit test classes that should be broken up | watch out for too many dependencies)
