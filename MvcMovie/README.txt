Name- Satyanarayana Murthy Polina
ID- 0848454
2024-01-17
1200


Step-1
1200
Create project
Created a new project named MvcMovie authorize all the permissions so it can connect to locahost
and Launching the app without debugging by selecting Ctrl+F5

Step-2
Add a controller
In Solution Explorer right-click Controllers Add Controller.
n the Add New Scaffolded Item dialog box, select MVC Controller Empty Add.
i entered HelloWorldController.cs and added it to the project.
Replaced the contents of Controllers HelloWorldController.cs with the given code
The Welcome method runs and returns the string This is the Welcome action method

Step-3
add a view
modified the HelloWorldController class to use Razor view file
the Index method returns a string with a message in the controller class.
In the HelloWorldController class, replaced the Index method with the give code
Select Razor View Empty Keept the Name box value Index.cshtml.
Replaced the content of the Views Shared Layout.cshtml so  the title on the browser tab which displays Privacy Policy. 

Step-4
2024-01-25
1030
Add a model
Updated the Models/Movie.cs file with the given code
added nuget package using scaffold i did this with the entity framework dialoge
i got no errors everything looks good
this process is known as scaffolding
first migration using the console i ran the command Add-Migration Intialcreate 
which created the migration file 
next i updated database few messAGES POPUP but those don't look worse 
so i ran the app works good
examined the genarated the database, scaffolding creates the data
Dependancy injection- makes crud operations easy

step-5
work with database
From the View menu i  open SQL Server Object Explorer
in dbo.movie i checked the database
Created a new class named SeedData in the Models folder. Replaced the generated code
Deleted all the records in the database
tested the app everything looks good
Replaced  the contents of Program.cs with the given code

step-6

The edit and details and delete was new task to get the urls on the bottom left.
We were able to bring them. also the data in not in correct spacing format.
he proper codes like
using System, using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
Have slight changes and made them work at the end.
Eveything is linked to the program.cs file so again made the changes there and got the
correct output

Step-7
1100
2024-02-01
Updated the Index method found inside Controllers/MoviesController.cs with the code
The query is only defined at this point, it has not been run against the database
query execution is deferred. That means that the evaluation of an expression is delayed
method is run on the database, not in the c# code shown above. The case sensitivity on the query depends on the database and the collation. On SQL Serve

step-8
adding a new field to the Movie class, you need to update the property binding list so this new property
added a rating property,now we need to update the property binding list so this property will be included
updated the view templates now the new options display
updated the remaining templetes
DataBase is updated to include the new field.
in the PowerShell i ran two commands to add migration and to update database
ran the app now i can perform the added tasks

Step-9
adding validation
The validation support provided by MVC and Entity Framework Core Code First is a good example
there are build in attributes that are applied declaratively to a class or property
Updated the movie class so we can use the built in validation attributes we can see every attribute has specif conditions and value types
validated error UI, the controller and views we created has autometically picket uo the validation rules.
after the methods check the has any validation errors, if there are no errors the method saves the new movies in the database. 
everething works

Step-10
Examine the Details and Delete methods
we can see that the mvc scaffolding engine created the action method
after examining delete and deleteconfirmed tje HTTP GET Delete method doen't delete the specified movie it returns to where we can submit the deletion
operations like edit,create, or any other operation that changes will open up a security hole.
so we need two delete methods one for get and another for post they both have same parameters