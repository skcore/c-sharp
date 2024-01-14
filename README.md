# DESIGN PATTERNS
## Creational
### Factory method design pattern

In Factory pattern, we create the object without exposing the creation logic. In this pattern, an interface is used for creating an object,
but let subclass decide which class to instantiate

Product: This is the interface or abstract class defining the product the factory method will create.This is an interface for creating the objects.
ICar

ConcreteProduct: These are the specific implementations of the Product interface or abstract class.
Maruthi, Tata

Creator: This abstract class or interface declares the FactoryMethod().
which returns an object of type Product.
CarFactory

ConcreteCreator:  Subclasses of Creator that implement the FactoryMethod() to produce ConcreteProduct instances.
TataFactory,MaruthiFactory
