<br>
<h1 align = "center">
<b> Dr. Sillystringz's Factory </b>
</h1>

<p align = "center">
This application allows the user to keep track of Engineers and Machines in Dr. Sillystringz's Factory </p>
<p align = "center"> Created January 8, 2021 </p>

<p align = "center">
 By Kaila Sprague McRae
 </p>

--------------------

## 📖  Description

This application allows the user to keep track of Engineers and Machines in Dr. Sillystringz's Factory. The user can add Machines to an Engineer who is licensed to do so and add Engineers to a Machine. 

This is the Independent Project for Epicodus week 11 as part of the "Many-to-Many Relationships" coursework. 

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3.0
- .NET Core v2.2.0
- ASP .NET MVC
- ASP .NET Core Razor Pages
- MySQL
- MySQL Workbench
- Entity Framework Core

-------------------

## Specifications

![SQL Design](./ReadmeAssets/img "SQL Database Design")


<details>
<summary>User Stories</summary>

| Story # | User Story | Complete |
| :------------- | :------------- | :------------- |
| 01 | As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines. | true |
| 02 | As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it. | true |
| 03 | As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed. | true |
| 04 | As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed. | true |
| 05 | As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine. | false |
| 06 | I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it. | false |

</details>

-------------------

## 🐛 Known Bugs

| Date | Error | Handled | Solution |
| :------------- | :------------- | :------------- | :------------- |
| 01.08.2021 | unable to display engineers `"LastName", "FirstName"` in drop down list when creating a new Machine | true | added get perameters to `FullName` in Engineer Class |

-------------------

## 🔧 Setup & Requirements

### 📋 Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)
- **Prefered Code Editor**


### ⚙️ Open & Use

#### To Download:

Go to my GitHub repository here, [https://guthub.com/kaila.spraguemcrae/FINISH-URL](https://guthub.com/kaila.spraguemcrae/FINISH-URL), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### To clone (my prefered method):

1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/kaila-spraguemcrae/FINISH-URL`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.


#### AppSettings:

After you have the project on your computer you will need to create a file in the root directory of the project called "appsettings.json". Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=kaila_spraguemcrae_factory;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```
*Please note you will need to replace `YOUR-PASSWORD-HERE` with the password you created for your MySQL server.

#### Import Database using Entity Framework Core:

#### Import Database using MySQL Workbench:

#### Import Database using SQL Schema:

#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'PROJNAME' folder (`cd PROJNAME`) in the command line and run `dotnet run` or `dotnet watch run`.
2. At this point you should be able to click on the link to the local server's url path to view the compiled project. 

--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:kaila.sprague@icloud.com).

---------------------------

## 📘 License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2020 Kaila Sprague McRae