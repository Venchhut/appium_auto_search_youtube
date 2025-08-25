Selenium C# Test Project
This is a simple automated testing project that uses Selenium WebDriver with C# and the NUnit framework. The purpose of this project is to demonstrate a basic UI test.

The included test case will:

Open the Google Chrome browser.

Navigate to the DuckDuckGo search engine.

Search for the term "Selenium C#".

Verify that at least one search result is returned.

Prerequisites
Before you can run this project, you need to have the following software installed on your machine:

.NET SDK (The project is likely built on .NET 6, 7, or 8, but any recent version should work).

Visual Studio or another C# compatible IDE (like JetBrains Rider or VS Code with C# extensions).

Google Chrome browser.

How to Run the Tests
Follow these steps to get the project running on your local machine.

1. Clone the Repository
First, clone this repository to your local machine using Git:

git clone <your-repository-url>

Replace <your-repository-url> with the actual URL of your GitHub repository.

2. Open the Project in Visual Studio
Navigate to the cloned folder and open the .sln (Solution) or .csproj (Project) file in Visual Studio.

3. Build the Project
Once the project is open, you need to restore the necessary packages (like Selenium and NUnit) and build the project.

Go to Build > Build Solution in the top menu (or press Ctrl+Shift+B).

Visual Studio will automatically download all the required NuGet packages and compile the code.

4. Run the Tests
After the build is successful, you can run the tests using Visual Studio's Test Explorer.

Go to Test > Test Explorer in the top menu.

The Test Explorer window will open and should discover the Search_OnDuckDuckGo_ShouldReturnResults test.

Right-click on the test and select Run.

A new Chrome browser window will open and automatically perform the search steps. The test result (pass or fail) will be displayed in the Test Explorer.
