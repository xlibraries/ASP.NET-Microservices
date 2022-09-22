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

Basic Notations & Common Practises
->"I" in front of a class indicates that it is an interface(An interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement).
->To configure multiple startup projects go to sln file -> set start-up project -> multiple projects -> those projects.

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
->With microservices you should never share the code even you have to some duplicate data that is the route you should take, all of the priojects should be self isolated.

Types of API:-
-> RestAPI: They say Stick to your domain because you have adapted that why so that you can scale your product.
		Anti patterns are discouraged by a rest principle. For .net there isouclate apigateway.
-> 

Q1.) What is a serveice?
Ans: Hosted by server at a physical address and a port. Which works on the principle of request(by consumer) and response(by server).
Q2.) Why Microservices?
Ans: It is an design patter, if you put here you will need to seperate everything you can reduce load via using load balancers won't be needing microservices for that.
Q3.) Difference between Design Pattern and Articture Pattern?
Ans. Articture will tell you how things will be done, and design will work on localized problems
Q4.) How Load balancers can be used for monolitic applications?
Ans. Creating load balanceer into four different particions for mololitic application can reduce load into the database.
	Types of load balancing: Horizontal and Vertical.
Q5.) Can Monolitic applications and microservies worktogether and what are it's limitations?
Ans. Mololethic application and microservies can work together to serve a product. 
	You can have multiple database in a single server with multiple connections until the number of connection in the pools gets exhausted.
Q6.) How can I check if a microservice is working properly or not?
Ans. API gateway can be used to check if a microserive is running or it is down.
Q7.) What is Application DBContext?
Ans: An instance of DbContext represents a session with database which can be used to query and save instances of your entities to a database.
Q8.) What is URI?
Ans: A Uniform Resource Identifier is a unique sequence of characters that identifies a logical or physical resource used by web technologies.