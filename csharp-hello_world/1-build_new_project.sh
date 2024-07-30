#!/usr/bin/env bash

# Creates a new directory called '1-new_project'
mkdir 1-new_project

# Changes to the newly created directory
cd 1-new_project

# Initializes a new C# project
dotnet new console

# Builds a project
dotnet build