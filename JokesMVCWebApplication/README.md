#### ASP.NET Demo Application

A couple of helpful tutorial videos: 
- https://youtu.be/C5cnZ-gZy2I
- https://youtu.be/BfEjDD8mWYg

Initial Setup:	
 1) Install the following NuGet Packages (Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution)
	Note: these actually might already be installed, I was not sure if NuGet packages would come down with Github
	a) Microsoft.EntityFrameworkCore
	b) Microsoft.EntityFrameworkCore.SqlServer
	c) Microsoft.EntityFrameworkCore.Design
 2) Open Package Manager Console and run the following commands
	a) update-database
		i) open "SQL Server Object Explorer" in Visual Studio and Refresh
		ii) expand "(localdb)\MSSQLLocalDB ..." 
		iii) expand "Databases"
		iv) expand "JokeMVCWebApp"
		v) expand "Tables" and you can look at the added "dbo.Jokes"
	b) Database is now all set!	

Checklist of Items to Take Care of To Add a "Puns" Section
- [ ] Create a 'Pun' Model
- [ ] Add a DbSet in ApplicationDbContext
- [ ] Update DB: add-migration and update-database
- [ ] Create a PunsController
- [ ] Create an Index View for Puns (Note, it would be easy to just copy from the Joke Index page. Most of the HTML can stay the same)
- [ ] Similarly, create an Edit View and a Create View
- [ ] Update the PunsController by adding necessary Create and Edit methods
