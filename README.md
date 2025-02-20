Hello, Exadel team!

This is my test project. It is based on ASP.NET Core WebApi. I used .NET 8 and MSSQL local database. I have three layers here, as per the task requirement:
DataAccess
Models
Api 

This is the first time I've used such an architecture. Normally I would add another layer Application which would contain the application's commands. But I tried to do it as per the task.

For ease of testing the application, I seeded the database with test books. Before running the application, you need to run the "update-database" command in the Package Manager Console on the DataAccess layer.

I have only two models: User and Book. In all the models I create I usually add an ID field but since I only have four fields in the task I implemented and use Title as the key.

I implemented authentication using AspNetCore.Identity and JWT tokens. Only registered users have access to the commands. You will only need an email and password for registration and login.
Upon login you will receive a response with a token and a refresh token. In Swagger you need to click on Authorize and enter the received token. The token is valid for 10 minutes.
To get a new token you need to send the refresh token in the "refresh-token" request and then you will receive a new token and a refresh token.

I wrote all the operations as per the task and they work correctly. For command validation I used annotations. The book rating is calculated. 
According to the task I had to output all the book fields in the operation plus the rating which is not saved in the database. I did that too.

I tried to make the application intuitive and I think you will have no problems testing it.

I would very much like to join your Bootcamp and grow further in your company!

Have a great day!
