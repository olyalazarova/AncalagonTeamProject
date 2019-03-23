Blog.Tests README File

Blog.Tests is a project within BlogBuild solution, 
whose aim is to automate the testing of the Blogs' UI.


Blog.Tests is built based on the POM pattern.

-------------------------------------------------------------------------------

Structure:
---------
1. Helper Files (FileReader class helps to read json files) 

2. Jsons (Json files containing different data used for the tests)

3. Models (The c# objects used to interact with the pages: user, article)

4. Pages (The c# objects of the blog pages)

5. Tests.cs (The main test project)

--------------------------------------------------------------------------------

Jsons Note!
-----------

In order for the helping class to locate the json file, the following setting must be done:
1. On each json file, go to "Properties"
2. Set the property "Copy to Output Directory" to "Copy always"

---------------------------------------------------------------------------------

Reading jsons and creating c# objects
-------------------------------------

Please check Sample test in Tests.cs

DISCLAIMER: for Registration tests a new approach needs to be created as the system does not allow
duplicate users
Options to consider:
1. Having big set of user data
2. Randomize user data
3. Clear the database

----------------------------------------------------------------------------------

Pages Objects Structure
-----------------------
Each page from the blog is represented by two partial classes:
1. Map containing the web elements
2. another class with the functional info and methods


There is a Sections Folder
It contains the Header and Footer, because they are repeated sections for each page.
Each page object call on the sections.

-------------------------------------------------------------------------------------



