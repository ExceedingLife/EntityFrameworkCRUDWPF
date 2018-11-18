# EntityFrameworkCRUDWPF
C# WPF project using entity framework.

Includes 2 WPF windows (MainWindow.xaml and CreateUpdateWindow.xaml) 
MainWindow has a data grid populated from a .mdf database using data-binding. 
This window also has 3 buttons (Create, Update, and Delete) 
Create and Update opens a new window when clicked. 
If data grid item selected and update clicked new window opens loading selected user. 
MainWindow will be closed if update is clicked. 
When create clicked new window opened to create a new user. 
MainWindow will be closed. 
Delete works if data grid item selected and messagebox "Yes" to confirm is clicked. 
CreateUpdateWindow consists of a form created from textboxes and labels with 1 button. 
Save button on bottom will save if all textboxes have valid data. 
First name - string 
Last name - string 
Age - Number only 
Programming Language - string 
When user is created user will also have current date connected with user. 
Once user clicks save on CreateUpdateWindow then MainWindow is opened. 
CreateUpdateWindow will be closed and data grid refreshed on MainWindow.

CREATE 
READ 
UPDATE 
DELETE

C# 
WPF 
Data-Binding 
Entity Framework 
Visual Studio 2017

~ Andrew Harkins
