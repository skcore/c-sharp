# DESIGN PATTERNS
## Creational
### Factory method design pattern

🔗 **Blog / Details:** https://gtcore.in/category/interview-questions/c-sharp/



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

### Builder design pattern

It separates the construction of a complex object from its representation so that you can use the same 
construction process to create different representations of an object.

Builder:
This is an interface or abstract class that defines the steps for building the Product. 
The Builder interface has a set of methods for setting each property of the product.
Abtract Class - CarBuilder

Concretebuilder:
This is a concrete class that implements the IBuilder interface or abstract class 
The ConcreteBuilder class has specific implementations for each of the methods.
Class - TataCarBuilder


Director:
This is an optional class that controls the order in which the builder’s methods are called to build the Product. 
The Director class may also have additional logic for constructing the Product
Class - CarShop


Product:
This is a class of complex objects with multiple parts.
Class - Car
