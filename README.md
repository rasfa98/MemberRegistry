# Workshop 2 Instructions

This is a simple member registry created for the second workshop in the course 1DV607.

## Prerequisites

You need to download one of the applications that will run on your operating system. [Here is a link to the available versions](https://drive.google.com/drive/folders/12NIhRDNUtfFcx1tmsSPuYMdQtHc2Uace?usp=sharing)

If you don't find a version that you can run you can install Dotnet Core SDK and run the project instead. [Here is a link to Dotnet Core SDK](https://www.microsoft.com/net/download)

## Start the application

To start the application simply double-click on the file called *MemberRegistry.exe*, the application will then open in your default terminal. If this doesn't work for example in Ubuntu, just drag the *MemberRegistry.exe* file into the terminal window and press enter.

## Run the project

If you want to run the project instead of the executable file do the following:

1. Install Dotnet Core SDK

2. Navigate to the folder called *source-code*
`$ cd /xxx/xxx/xxx/source-code`

3. Install the dependencies
`$ dotnet restore`

4. Run the project
`$ dotnet run`

## Storage

The application uses a JSON-file (data.json) to store the members. This file should already be included in the application folder, but if it's not make sure to add it before starting the application. If you create a new file it should look like this:

```
[]
```
