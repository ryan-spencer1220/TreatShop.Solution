# Dr. Sillystringz's Factory

#### C# application designed to demonstrate an understanding of many-to-many databse relationships, basic MVC structure, and CRUD operations.

#### By Ryan Spencer

## Technologies Used

- _C#_
- _Git_
- _Github_
- _SQL_
- _MySQL_
- _Markdown_
- _HTML_
- _CSS_
- _Bootstrap_
- _Entity Framework_

## Description

This application was designed for a fictional manufacturing company utilizing C# and MySQL. The goal of the project was to create an application that allows Dr. Sillystringz to create, read, update, and delete both engineers working for the company and machines that the business owns. This applicaiton demonstrates an understanding of a "many-to-many" relationship between engineers and machines, an engineer can be licensed to operate on multiple machines and a machine can have multiple engineers assigned for repairs.

## Setup/Installation Requirements

**Cloning**

1. In order to utilize this application on your local machine, you will need to clone a copy of this repository using the "$ git clone {url}" command in your coding terminal.

2. Navigate to your desired directory in your command terminal and run "$ git clone https://github.com/ryan-spencer1220/Factory.Solution.git"

3. Should you wish to edit the code you cloned, you will need coding software. VS Code is an example of a free code editor, which can be downloaded at https://code.visualstudio.com/_.

4. Once your coding software is installed, open the folder of the cloned repository, which will contain the project files.

**Downloading**

1. In your browser, navigate to https://github.com/ryan-spencer1220/Factory.Solution.git, and click the green "Code" button, which will provide a drop down menu. Click on "Download ZIP" at the bottom of the menu, and save it to your desired location.

2. Once downloaded, unzip and extract the files.

3. Follow the steps above to view, edit, and open the files as needed.

**Creating a .json File & Running Migrations**

1. Create a new file in the project directory (Factory) titled appsettings.json which should contain the following code with ID and password replaced with your actual MySQL Workbench login information

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=ryan_spencer;uid=MYSQLWORKBENCHID;pwd=MYSQLWORKBENCHPASSWORD;"
  }
}

```

2. Once the file has been created, run _dotnet ef add initial_ followed by _dotnet ef database update_

3. To run the application, run the command _dotnet watch run_ and follow the prompts.

**Running The Project**

1. While located in the root directory, navigate to the HairSalon directory.

2. In your terminal run the command _dotnet restore_ to add the required dependencies and tools for this project.

3. To build the application, run the command _dotnet build_.

4. Finally to run the application, run the command _dotnet watch run_ and select either localhost:5000 or localhost:5001 to launch the application on your local machine.

## Known Bugs

- _No Known Bugs._

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Ryan Spencer. All Rights Reserved.

```
MIT License

Copyright (c) 2022 Ryan Spencer.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
documentation files (the "Software"), to deal in the Software without restriction, including without
limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so
subject to the following conditions:

The above copyright notice and this permission notice shall be included
in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

---

<a href="#">Return to Top</a>
