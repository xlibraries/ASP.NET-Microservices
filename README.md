# Mango-Returant

Why Microservices?
->They are indenpendently deployable as needed.
->Great when it comes to scaling.
->No Bulky Code.
->Reduce Downtime.
->They isolates everything within that environment.

Things I will be learning:
->.NET API
->Identity Server
->Service Bus
->Microservices Communication
->Gateway
->Best Practices

Prequisites
->Basic understanding of .NET Core
->EF Core(Entityframework core)
->API

Basic Notations
->"I" in front of a class indicates that it is an interface(An interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement).


Notes:-
->Whenever working with APIs then it is not recomnded to pass the direct data entity model it is always recomended to map that to some DTO and pass that DTO, for it you can use automapper.
->In .NET 6 Startup.cs file is merged with Program.cs.
->Good practise for CRUD operation is to create a repository which will do all the CRUD operations.
->Route helps to differentiate when an API request is made where should it be redirected to.
Things to Remember:-
->While adding migration on package manager console check these points:
	*The project is set as start-up project.
	*Check if right project is selected and package source includes nuget.org in the package manager console.
	*include System.Confriguation.
	*Under appsetting.json it won't give you error but check if there are everything is placed correctly as a small comma can cost mutiple hours to solve.


Q1.) What is Application DBContext?
Ans: An instance of DbContext represents a session with database which can be used to query and save instances of your entities to a database.
Q2.) What is URI?
Ans: A Uniform Resource Identifier is a unique sequence of characters that identifies a logical or physical resource used by web technologies.

