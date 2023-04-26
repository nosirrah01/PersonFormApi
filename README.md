# Person Form Data Web App

A simple web app that saves user-provided name, age, and sex to a Microsoft SQL Server database via a C# REST web service. Built using ASP.NET Web API and JavaScript. Implements form validation. Designed for learning RESTful web service development and Microsoft SQL Server interaction with C#.

## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Microsoft SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

## Setup

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio.
3. Update the connection string in the `appsettings.json` file to match your SQL Server instance.
4. Create the `PersonFormData` database and required tables in your SQL Server instance using the provided SQL script.
5. Run the project in Visual Studio.

## Usage

1. Open the web app in your browser.
2. Fill out the form with the required information (name, age, sex) and click 'Submit'.
3. The form data will be sent to the C# REST web service, which will save the information to the SQL Server database.