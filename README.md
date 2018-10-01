# MemberRegistry

This is a simple member registry created for the second workshop in the course 1DV607.

## Prerequisites

First of all you need to install **\.NET Core Runtime** in order to run the application. This is due to the large file-size when creating a self-contained application which can not be uploaded to CSQUIZ.

[Link to .NET Core Runtime](https://www.microsoft.com/net/download)

## Start the application

Open your terminal and run the following commands.

First of all make sure that you are in the *application* folder located in the root directory of the project by typing the following command:

`$ pwd`

Example output

`$ /Users/xxxx/Documents/workshop-2/application`

Then start the application

`$ dotnet MemberRegistry.dll`

## Storage

The application uses a JSON-file (data.json) to store the members. This file should already be included in the application folder, but if it's not make sure to add it before starting the application. If you create a new file it should look like this:

```
[]
```