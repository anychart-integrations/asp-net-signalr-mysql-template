[<img src="https://cdn.anychart.com/images/logo-transparent-segoe.png?2" width="234px" alt="AnyChart - Robust JavaScript/HTML5 Chart library for any project">](https://anychart.com)
ASP.NET SignalR C# basic template
=========================

This example shows how to use Anychart library with the C# programming language using ASP.NET, SignalR library and MySQL database.

## Running
This example uses .NET framework 4.6.1, ASP.NET 4.0.30319, ASP.NET MVC 5.2, SignalR 2.2.1, Visual Studio 2015 Community, MySQL 5.6 and MySQL Connector/NET 6.9.9.0 - ADO.NET driver for MySQL. 
To check your installations, please, use Windows Control Panel -> Programs and features.
If you miss some installations, please, visit:<br />
[MySQL download page](https://dev.mysql.com/downloads/installer/) and [installation instructions](http://dev.mysql.com/doc/refman/5.7/en/installing.html) to setup MySQL;<br />
[Visual Studio download page](https://www.visualstudio.com/downloads/) to install Visual Studio, .NET framework and ASP.NET;<br />
[Connector/Net download page](https://dev.mysql.com/downloads/connector/net/6.9.html) to install MySQL Connector/NET.<br />

To start this example run commands listed below.

Clone the repository from github.com to your working directory:
```
$ git clone git@github.com:anychart-integrations/asp-net-signalr-mysql-template.git
```

Open cmd console in 'asp-net-signalr-mysql-template' folder and set up MySQL database, use -u -p flags to provide username and password:
```
$  "[YOUR_PATH_TO_MYSQL]\bin\mysql.exe" < database_backup.sql
e.g:  
$  "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe" -uroot -ppassword < database_backup.sql
```

Open project in Visual Studio using AspNetSignalRMysqlTemplate.sln solution file

Run application using Run button or press F5

If you have some problems with MySQL connection, ensure that MySql.Data.Entity.EF6 in References has correct path to MySql.Data.Entity.EF6.dll

Now you can update MySQL database data, run:
```
$  "[YOUR_PATH_TO_MYSQL]\bin\mysql.exe" -u[USER_NAME] -p < database_update.sql
e.g:  
$  "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe" -uroot -p < database_update.sql
```

The chart on web page will update automatically

## Workspace
Your workspace should look like:
```
AspNetSignalRMysqlTemplate/
	App_Data/
    App_Start/
		RouteConfig.cs			# app routes
	Controllers/
		ChartController.cs		# main controller
    Css/
		style.css				# main css file
	Hubs/
		ChartHub.cs				# SignalR chart hub
    Models/
		fruit.cs				# Entity framework model for MySQL
		FruitDBContext.cs		# DB data provider
	Scripts/
		jquery-1.12.4.intellisense.js
		jquery-1.12.4.js
		jquery-1.12.4.min.js
		jquery-1.12.4.min.map
		jquery.signalR-2.2.1.js
		jquery.signalR-2.2.1.min.js
	Views/
		Chart/
			Index.cshtml		# html template
		web.config
	Global.asax
	packages.config
	Startup.cs					# Owin app startup
	Web.config					# main ASP.NET project settings
```

## Technologies
Language - [C#](https://msdn.microsoft.com/en-us/library/ms228593.aspx)<br />
Web framework - [ASP.NET](https://www.asp.net)<br />
HTML tepmlate - [Razor](https://www.asp.net/web-pages/overview/getting-started/introducing-razor-syntax-c)<br />
Real-time library - [SignalR](https://www.asp.net/signalr)<br />
Database mapping - [Entity Framework](https://www.asp.net/entity-framework)<br />
Database - [MySQL](https://www.mysql.com/)<br />

## Further Learning
* [Documentation](https://docs.anychart.com)
* [JavaScript API Reference](https://api.anychart.com)
* [Code Playground](https://playground.anychart.com)
* [Technical Support](https://anychart.com/support)

## License
[© AnyChart.com - JavaScript charts](http://www.anychart.com). Released under the [Apache 2.0 License](https://github.com/anychart-integrations/asp-net-signalr-mysql-template/blob/master/LICENSE).
