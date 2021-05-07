For this project I have use Database First Approach of Entitiframework Core.

1) First create a database with name QuizGame
	Create Database QuizGame
2) Create a table with tablename QuizGameTable

	Create Table QuizGameTable(
	Qid int not null identity(1,1) primary key,
	Question nvarchar(150),
	Option1 nvarchar(150),
	Option2 nvarchar(150),
	Option3 nvarchar(150),
	Option4 nvarchar(150),
	CorrectAnswer nvarchar(150)
	);
3) Insert the values in table which is question and options along with correct answer

4) Add connection string in appsetting.json 
     "ConnectionStrings": {
           "QuizGame": "Data Source=DESKTOP-KBAPQC1;Initial Catalog=QuizGame;Integrated Security=True"
      },
5) Download necessary packages nuget offers which we need.
6) The model is create itself after scafolding command in packagemanager console
    The Scaffold Command: 
		-----------------------------------------
	Scaffold-DbContext {-Connection-string-in-quotations-} Microsoft.EntityFrameWorkCore.SqlServer 
	-outputdir Repository/Models -context {-databasename-}DbContext -contextdir Repository -DataAnnotations -Force
7)Create new controller and view to show the data pass by controller to view. However we can use and work on default homecontroller and view.cshtml.


