#!/usr/bin/env bash

# Creates a new directory called '2-new_project'
mkdir 2-new_project

# Changes to the newly created directory
cd 2-new_project

# Initializes a new C# project
dotnet new console

# Builds a new C# project
dotnet build

# Runs a new C# project
dotnet run
