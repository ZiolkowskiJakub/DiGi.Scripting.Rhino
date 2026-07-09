#### [DiGi\.Scripting\.CSharp\.Rhino](DiGi.Scripting.CSharp.Rhino.Overview.md 'DiGi\.Scripting\.CSharp\.Rhino\.Overview')

## DiGi\.Scripting\.CSharp\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript'></a>

## CSharpScript Class

Provides a Grasshopper component implementation for defining and configuring C\# scripts, allowing users to specify source code, references, imports, and variable types\.

```csharp
public class CSharpScript : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → CSharpScript
### Constructors

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.CSharpScript()'></a>

## CSharpScript\(\) Constructor

Initializes a new instance of object\.

```csharp
public CSharpScript();
```
### Properties

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.ComponentGuid'></a>

## CSharpScript\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.Exposure'></a>

## CSharpScript\.Exposure Property

Gets the exposure level of the component, indicating whether its output is primary or secondary\.

```csharp
public override Grasshopper.Kernel.GH_Exposure Exposure { get; }
```

Implements [Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.exposure 'Grasshopper\.Kernel\.IGH\_DocumentObject\.Exposure')

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.Inputs'></a>

## CSharpScript\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.Outputs'></a>

## CSharpScript\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.SolveInstance(Grasshopper.Kernel.IGH_DataAccess)'></a>

## CSharpScript\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(Grasshopper.Kernel.IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Scripting.CSharp.Rhino.Classes.CSharpScript.SolveInstance(Grasshopper.Kernel.IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi\.Scripting\.CSharp\.Rhino Grasshopper plugin\.

```csharp
public class RhinoInfo : Grasshopper.Kernel.GH_AssemblyInfo
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the preferred contact details for the author\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author or company\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short string describing the purpose of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets a 24x24 pixel bitmap to represent this GHA library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.CSharp.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')