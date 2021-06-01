using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    //To Comment press ctrl+k, ctrl+c

    //Created using Object Orientated Programming...

    //Right clicked models folder and add class. Created this Joke.cs class

    //A class or an object has properties

    //To create a class or a property type prop + tab x2 

    // Create Class Joke


    public class Joke
    {
    //public assessability, integer is the datatype
    //In C# , getter and setter you put in get; set; - default type of project property
        public int Id { get; set; }
        public String JokeQuestion { get; set; }
        public String JokeAnswer { get; set; }


        // Create Constructor. ctor + tab x2

        public Joke()
        {
            //Needs to be empty to be used with other pieces of the code
            //We are going to dynamically create pages by having the: Data, ApplicationDbContext.cs file
            //Click controllers, Add, Controller - MVC Controller with Views using Entity Framework (heart of application). This will create hours worth of functionality such as edit, delete etc.
            //Just need to create a database now that goes behind it using "Migrations". Data, Migrations. 
            //Now open the Package Manager Console : Tools, NuGet Package Manager, Package Manager Console. Input  add-migration "initialsetup"
            //new file is now set up, you can see that the Joke is supposed to have a Joke Question and a Joke Answer. This is an Object Relation Mapper. Mapping between a Class and a Table.
            //The Class is Person - int ID, String Name, String Phone, Int Age. The ORM is creating a table which matches exactly to that Class.

            //Choices for database with an application like this are
            //1) DAO Data Access Object. This allow you to create your tables manually, and is the traditional method of database access. Enables you to write your own SQL Statements. DBA's usually prefer DAO's as it allows more visibility on finding problems.
            //2) ORM - Object Relational Mapper. Preferred by programmers who are looking to ssave time. Allows the computer to generate database tables based on classes defined in the application. Database is updated using migrations.
            //Entity Framework is Microsoft's ORM. Simple for Basic Applications.

            //Type into the Package Manager Console: update-database. ORM now creates all the tables! Creates 2 tables. 1) For user accounts. 2) For Jokes
            //Open the SQL Server Object Explorer window and see the newly created DB and the tables. 
            //Run the application and go to the jokes controller, simply type /jokes. You can now create a Joke!

            //Functionality to add now..
            // 1) Show Joke Owner
            // 2) Hide the Joke Answer
            // 3) Limit "Create" to logged in users. Restrict create access to logged in users.
            // 4) Search Jokes Functionality.

            //Next stage,
            // 1) Add items to the Nav Bar.
            //Click Views, Shared, _Layout.cshtml

        }
    }



}
