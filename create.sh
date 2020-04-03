#!/bin/bash
for i in {1..200}
do
  rm bin/Debug/*.nupkg
  dotnet pack /p:Version=0.0.$i
  dotnet nuget push bin/Debug/*.nupkg -s github
done
