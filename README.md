# .NET-Misc
Different small examples

## Throw vs ThrowEx
throw ex - shorter stack trace   
throw - full stack trace

## CovarianceAndContravariance
https://stackoverflow.com/questions/2662369/covariance-and-contravariance-real-world-example   
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/index   
For example since .net 4.0 IEnumerable is Covariant!!! Using out/in you can define own types
that are covariant (casting up) or contravariant (casting down).

## ??
?? reacts only on null value, string.Empty is treated as not null value

## Old csproj vs new csproj
https://natemcmaster.com/blog/2017/03/09/vs2015-to-vs2017-upgrade/   

### OldCSproj
This is just simple .NET Framework project in .NET 4.6.1.   

### NewCSproj
This is project converter from OldCSproj where csproj files have been refactored to new csproj format.  

Notes:
* in new csproj AssemblyInfo.cs file is automatically generated and it is stored only in memory. Because in old csproj AssemblyInfo.cs was stored on disk the compiler sees 2 duplicated files and returns 7 errors. There are 2 options to solve it: remove the AssemblyInfo.cs from the disk or use *<GenerateAssemblyInfo>false</GenerateAssemblyInfo>* in the csproj file. More can be found [here](https://stackoverflow.com/questions/42138418/equivalent-to-assemblyinfo-in-dotnet-core-csproj).
* it looks that at least in case of console app if new csproj file is used it has to be used in all referenced projects. If some projects use old csproj there are errors during compilation.

### CSProjDotNetStandardAndConsolAppCore
This is project created for .NET Core 2.0 and libs are in .NET Standard 2.0.

## NuGets
### NuGets for .NET Framework old csproj
Folders: NuGetNETFramework, NuGetNETFrameworkRun.   
For old csproj .nuspec file is required.   
https://www.codeproject.com/Articles/1214420/Creating-a-Nuget-Package-Step-by-Step   
https://dotnetcore.gaprogman.com/2018/04/26/how-to-create-nuget-packages/   
### NuGets for .NET Framework new csproj
Folder: NewCSproj.   
For new csproj .nuspec file is not supported because nuget related data are avialble in csproj files.   

#### Top-level dependencies
*In NuGet 2, you listed every single package to be included. In NuGet 4 (VS 2017), you only need to list top-level dependencies. Everything else is that those top-level dependencies require will be imported automatically.*   
**NOTE: the topic is about nuget dependencies and not dll references!!!**

https://docs.microsoft.com/en-us/dotnet/core/tools/csproj

#### PrivateAssets
By default all referenced csproj are treated as nuget dependency.
It means that nuget A will have dependency to nuget B. In presented case there is only one nuget that contains dlls A, B, C so to not create nuget dependency to not existing nuget B tag *PrivateAssets* has to be used.   
```
<ProjectReference PrivateAssets="All" Include="..\LibB\LibB.csproj" />
```   
#### TargetsForTfmSpecificBuildOutput
To include in the nuget additionall dlls element *TargetsForTfmSpecificBuildOutput* has to be used.   

NOTE: this tag is needed even *csproj* references are used! It means that if *csproj* A has reference to *csproj* B to have dll B for the nuget A it has to explicit added via *TargetsForTfmSpecificBuildOutput*.

```
<TargetsForTfmSpecificBuildOutput>PackageAdditionalBuildOutput</TargetsForTfmSpecificBuildOutput>
```

```
  <Target Name="PackageAdditionalBuildOutput">
    <ItemGroup>
      <BuildOutputInPackage Include="..\LibB\bin\debug\LibB.dll" />
      <BuildOutputInPackage Include="..\LibB\bin\debug\LibC.dll" />
    </ItemGroup>
  </Target>
```

#### TargetsForTfmSpecificContentInPackage
This element allows to add any other files that should be placed in the nuget. It can be used e.g. to include *dacpac* files.

### Use nuget that contains *dacpacs*
Because after adding dependency to a nuget that contains *dacpac* files the files are not automatically added to the current solution/project it has to be done manually or by some script. *Dacpac* files have to be uncpack from the nuget and copied to some folder in the current solution/project.   

In *UseNuGet.sln* was created folder *NugetContent* for stuff like *dacpac* files. In this case it was copied manually. Next this *dacpac* can be referenced by other *sqlproj* files from the current solution.   

NOTE: remember about handling an issue with not executing pre-deployment and pos-deployment scripts from the referenced *dacpac* files (also from the referenced *sqlproj* files). More info about it can be found in the [sql repo](https://github.com/kicaj29/sql#how-to-reference-between-sqlproj-files).
