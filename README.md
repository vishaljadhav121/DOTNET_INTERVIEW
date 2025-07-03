# DOTNET INTEVIEW QUESTIONS
**Question**

	What is API VERSIONING ?

_Releated Questions_

  How do you handle breaking changes?

  What are the pros and cons of different versioning strategies?

  How do you deprecate an old API version?

**ANSWER**

	API Versioning is a technique used to manage changes in your API over time without breaking existing clients. It allows you to expose multiple versions of your API so that older applications can continue working while new features or changes are made in newer versions.

**Question** 

	What are advantages of API VERSIONING

**ANSWER**

	To maintain backward compatibility.

	To introduce new features or changes without affecting existing clients.

	To deprecate old versions gradually.

	To support multiple clients that may depend on different versions.

 **Question** 

	What is middleware in ASP.NET Core?
 
 **ANSWER**

	Middleware is a component in the HTTP request pipeline that handles requests and responses. Each middleware can perform actions before and after the next one in the pipeline.

 **Question** 

	What is the order of middleware execution in ASP.NET Core?

**ANSWER**

	Middleware executes in the order they are registered in Startup.Configure. The response flows back in reverse order.


