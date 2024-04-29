ASP.NET CRUD Operation with MS SQL Server (Deployed Link is given)

Introduction
Explore the fundamentals of ASP.NET CRUD (Create, Retrieve, Update, Delete) operations with Microsoft SQL Server through this user-friendly project. Crafted in Visual Studio, the application features a straightforward interface employing TextBox and DropDownList controls for ease of use.

Features
 1. User-Friendly Interface
   - Designed a simple UI with TextBox and DropDownList controls.

 2. Database Setup
   - Established a SQL Server database to efficiently store project data.

 3. Code Implementation
   - Crafted straightforward C# code for essential CRUD operations.

Key Functionalities
 - Insert, Update, Delete, and Read Operations
   - Implemented straightforward CRUD operations to manage data in the database seamlessly.

 - Search Operation
   - Added a search functionality to find specific records within the entire database table.

 - Sorting Operation
   - Enabled sorting capabilities for the entire database table, allowing easy organization of data.

 - Event Handling
   - Implemented code for button click and page load events for smooth user interaction.

 - Data Presentation
   - Loaded project data into a GridView for a clean and intuitive display.

 - Pagination Feature
   - Implemented pagination to efficiently handle and display large sets of data in the GridView. Users can navigate               through different pages for improved data presentation and navigation.

Execution Guide: ASP.NET CRUD Operation with MS SQL Server

 Prerequisites
1. Visual Studio: Ensure you have Visual Studio installed on your machine.
2. SQL Server: Have SQL Server installed to create and manage the database.

 Setup Instructions
1. Clone the Repository:
   - Clone or download the project repository to your local machine.

2. Open in Visual Studio:
   - Launch Visual Studio.
   - Open the project solution file (`CRUDApplication.sln`).
Certainly! Here is a revised section for your README instructions:

3. Database Configuration:

1. Connect your SQL Server instance:
   - Utilize SQL Server Management Studio or your preferred tool to connect to your SQL Server instance.

2. Execute the script in DatabaseScript.sql:
   - Run the SQL script provided in `DatabaseScript.sql` to create the necessary database and table.

Connection String Configuration:

Update the connection string in Default.aspx.cs:
   - Open the `Default.aspx.cs` file in your project.
   - Locate the `SqlConnection` section.
   - Update the `SqlConnection` attribute with your SQL Server details.

    ```csharp
    SqlConnection con = new SqlConnection("Data Source=YourServer;Initial Catalog=YourDatabase;User   	Id=YourUsername;Password=YourPassword;" providerName="System.Data.SqlClient" />);
    ```

   - Replace `YourServer`, `YourDatabase`, `YourUsername`, and `YourPassword` with your specific SQL Server details.


Launch the Application
1. Build the Solution:
   - Build the solution to ensure all dependencies are resolved.

2. Run the Application:
   - Press `F5` or click on the "Start" button in Visual Studio to run the application.

3. Explore in Browser:
   - The application will open in your default browser.
   - Navigate through the simple UI to experience CRUD operations.

How to Explore?
1. Deployment
   - Click here(http://fatimashehzad-001-site1.btempurl.com/) to explore the deployed site.

   Deployed Link
     http://fatimashehzad-001-site1.btempurl.com/

Additional Notes
- The code-behind file (`Default.aspx.cs`) contains the implementation details of button functionalities.
- Explore the project, perform CRUD operations, and enjoy a seamless user experience. 🚀