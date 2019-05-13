# Entity Framework Core Tutorial for ASP.Net MVC Web Application 

### Author: Malachi Evans

#### file: EntityFrameWorkCoreASPNet.md

#### date: May 07, 2019

##### Adapted from https://www.entityframeworktutorial.net/ 

------------------------------




1. Install the **Microsoft.EntityFrameworkCore.SqlServer** package using the NuGet packet manager. Along with **Microsoft.EntityFrameworkCore.Relational** and **System.Data.Client** packages as well.  

2. Next Install the **Microsoft.EntityFrameworkCore.Tools** and 
**Microsoft.EntityFrameworkCore.Tools.DotNet**. These will allows you to execute EF Core commands from the Package Manager Command line. For the **Microsoft.EntityFrameworkCore.Tools.DotNet** locate the **<projectname>.csproj** file and in the ItemGroup block place the following reference. 
**<DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.2.4" />**
 Make sure the Version number matches the package version installed. If an error is given find the right version number by opening the command line and navigating to the command line where project's Startup.CS file is and run **dotnet ef** Then use the version number shown.

 3. Next Create models. For me my models will be a matchbox (a type of toy car) and a lunch box.  Use the **using System.ComponentModel.DataAnnotations;**
statement to specify a key. 

---
namespace EntityFrameWork.Models
{
    
    public class Matchbox
    {
        [Key]
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}

namespace EntityFrameWork.Models
{
    
    public class Lunchbox
    {
        [Key]
        public int LunchId { get; set; }
        public string Food { get; set; }
        public string Drinks { get; set; }
    }
}
---
---

4. Next Create a Context Class. This will be called the Box class. Make sure you use the 
**using Microsoft.EntityFrameworkCore statement**. 
---
namespace EntityFrameWork.Models
{
    
    public class Box : DbContext 
    {
       public BoxContext(DbContextOptions<BoxContext> options)
           : base(options) { }

        public DbSet<Matchbox> Matchboxes { get; set; }
        public DbSet<Lunchbox> Lunchboxes { get; set; }

        public BoxContext CreateDbContext(string[] args) =>
             Program.BuildWebHost(args).Services
                 .GetRequiredService<BoxContext>();
    }
}

----------------
6. In your **Startup.CS** file add to the configure services model the following

    **services.AddDbContext<BoxContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));**

Change your **Program.CS** file to add the following methods and interface to your 

---
namespace EntityFrameWork

{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options =>
                    options.ValidateScopes = false)
                .Build();
    }
}

------

7. Next add the connection string to the top of your **appsettings.json** file the connection string must be on the same line.

---
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BoxDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },

---

8. After I will create a migration. Open the NuGet package manager console and run the following command **add-migration CreateBoxDB**. This should create a migrations folder in your MVC application. Then use the **update-database –verbose** command to create the database. 

9. If you open the SQL Server Object explorer you should now be able to navigate to the instance of the DB just created. 

