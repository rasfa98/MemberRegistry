# Workshop 2 Instructions

This is a simple member registry created for the second workshop in the course 1DV607.

## Prerequisites

Each executable file is located in a separate folder for each operating system (osx-x64, win10-x64, ubuntu-x64)

If you don't find a version of the application that will work on your operating system you can install .NET Core SDK and run the project instead. [Here is a link to the framework](https://www.microsoft.com/net/download)

## Start the application

To start the application simply double-click on the file called *MemberRegistry.exe*, the application will then open in your default terminal. If this doesn't work for example in Ubuntu, just drag the *MemberRegistry.exe* file into the terminal window and press enter.

## Run the project

If you want to run the project instead of the executable file do the following:

1. Install .NET Core SDK

2. Navigate to the folder called *source-code*
`$ cd /xxx/xxx/xxx/source-code`

3. Install the dependencies
`$ dotnet restore`

4. Run the project
`$ dotnet run`

## Storage

The application uses a JSON-file (data.json) to store the members. This file should already be included in the same folder as the executable file, but if it's not make sure to add it before starting the application. If you create a new file it should look like this:

```
[]
```
