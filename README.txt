Date Created:2023-02-16
Author Name:Taranvir Singh Atwal
Product Name:Rulers 
0610EST

*****************************
product was assigned for Assignment on 2 Feb,2023
Then i Researched realted  properties of my product.These are:
1.RulerTypes

2.Colour

3. RulerShape

4. Material

5.MeasurementSystem

6.Price 

7.Rating


********************
Added Controller
Add HelloWorld Controller in the conrollers folder
0622EST


*********************
changes the method in public method in HelloWorldController.cs 
0630EST

0715EST
*********************
Start working on views folder
Add folder in Views folder called HelloWorld

Add index.cshtml view in the hello world file.

0720EST
*********************
Change the title, footer, and menu link in the layout file
Change the static date in the footer and it change to dynamically  @DateTime.Now.ToString("yyyy")


0812EST
*********************
Add a model to an ASP.NET Core MVC app

Added Ruler.cs file in Models Folder and set diffrent data types to diffrent properties.
1.Id=int
2.RulerTypes=String
3.Colour=String
4.RulerShape=String
5.Material =String
6.MeasurementSystem= decimal

7.price=decimal
8.Rating= int


*****************
0832EST
Add NuGet packages in the poweshell 

Install-Package Microsoft.EntityFrameworkCore.SqlServer

0945EST
******************
Create a Data folder.

Add a Data/RulerContext.cs

0950EST 
***************************

Updated
 Startup.cs file and set to default connection

Apply Migrations in powershell

Add-Migration InitialCreate -Context RulersContext
Update-Database -Context RulersContext








