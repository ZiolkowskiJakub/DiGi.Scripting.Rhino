#### [DiGi\.Scripting\.Rhino](index.md 'index')

## DiGi\.Scripting\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript'></a>

## ExecuteScript Class

A Grasshopper component that executes a script using provided input parameters and returns the resulting output variables\.

```csharp
public class ExecuteScript : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ExecuteScript
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.ExecuteScript()'></a>

## ExecuteScript\(\) Constructor

Initializes a new instance of object\.

```csharp
public ExecuteScript();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.ComponentGuid'></a>

## ExecuteScript\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.Exposure'></a>

## ExecuteScript\.Exposure Property

Gets the exposure of the component, which defines how it is displayed in the Grasshopper canvas\.

```csharp
public override Grasshopper.Kernel.GH_Exposure Exposure { get; }
```

Implements [Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.exposure 'Grasshopper\.Kernel\.IGH\_DocumentObject\.Exposure')

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.Inputs'></a>

## ExecuteScript\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.Outputs'></a>

## ExecuteScript\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.SolveInstance(Grasshopper.Kernel.IGH_DataAccess)'></a>

## ExecuteScript\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(Grasshopper.Kernel.IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.ExecuteScript.SolveInstance(Grasshopper.Kernel.IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Scripting.Rhino.Classes.GooCode'></a>

## GooCode Class

Represents a Goo wrapper for the [DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code') class, enabling its use within Grasshopper's data pipeline and serialization\.

```csharp
public class GooCode : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Scripting.Classes.Code>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.Types\.GH\_Goo&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1')[DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooCode
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooCode.GooCode()'></a>

## GooCode\(\) Constructor

Initializes a new instance of the [GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode') class\.

```csharp
public GooCode();
```

<a name='DiGi.Scripting.Rhino.Classes.GooCode.GooCode(DiGi.Scripting.Classes.Code)'></a>

## GooCode\(Code\) Constructor

Initializes a new instance of the [GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode') class with the specified code object\.

```csharp
public GooCode(DiGi.Scripting.Classes.Code? code);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooCode.GooCode(DiGi.Scripting.Classes.Code).code'></a>

`code` [DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')

The [DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code') object to wrap\.
### Methods

<a name='DiGi.Scripting.Rhino.Classes.GooCode.CastFrom(object)'></a>

## GooCode\.CastFrom\(object\) Method

Attempts to cast the specified source object into a [GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode') value\.

```csharp
public override bool CastFrom(object? source);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooCode.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to cast from\.

Implements [CastFrom\(object\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.castfrom#grasshopper-kernel-types-igh_goo-castfrom(system-object) 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.CastFrom\(System\.Object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Scripting.Rhino.Classes.GooCode.CastTo_Y_(Y)'></a>

## GooCode\.CastTo\<Y\>\(Y\) Method

Attempts to cast the Goo object to the specified type\.

```csharp
public override bool CastTo<Y>(ref Y target);
```
#### Type parameters

<a name='DiGi.Scripting.Rhino.Classes.GooCode.CastTo_Y_(Y).Y'></a>

`Y`

The target type for casting\.
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooCode.CastTo_Y_(Y).target'></a>

`target` [Y](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode.CastTo_Y_(Y).Y 'DiGi\.Scripting\.Rhino\.Classes\.GooCode\.CastTo\<Y\>\(Y\)\.Y')

A reference to the target variable\.

Implements [CastTo&lt;T&gt;\(T\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.castto--1#grasshopper-kernel-types-igh_goo-castto--1(--0@) 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.CastTo\`\`1\(\`\`0@\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Scripting.Rhino.Classes.GooCode.Duplicate()'></a>

## GooCode\.Duplicate\(\) Method

Creates a duplicate of the current [GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode') instance\.

```csharp
public override Grasshopper.Kernel.Types.IGH_Goo Duplicate();
```

Implements [Duplicate\(\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.duplicate 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.Duplicate')

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the value\.

<a name='DiGi.Scripting.Rhino.Classes.GooCodeParam'></a>

## GooCodeParam Class

Represents a Grasshopper parameter for handling [GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode') objects and their underlying [DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code') values\.

```csharp
public class GooCodeParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.Scripting.Rhino.Classes.GooCode, DiGi.Scripting.Classes.Code>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Param&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1')[GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1') → [Grasshopper\.Kernel\.GH\_PersistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1')[GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooCode](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCode 'DiGi\.Scripting\.Rhino\.Classes\.GooCode')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → GooCodeParam
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooCodeParam.GooCodeParam()'></a>

## GooCodeParam\(\) Constructor

Initializes a new instance of the [GooCodeParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCodeParam 'DiGi\.Scripting\.Rhino\.Classes\.GooCodeParam') class\.

```csharp
public GooCodeParam();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.GooCodeParam.ComponentGuid'></a>

## GooCodeParam\.ComponentGuid Property

Gets the unique identifier for the [GooCodeParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooCodeParam 'DiGi\.Scripting\.Rhino\.Classes\.GooCodeParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.GooInput'></a>

## GooInput Class

A Goo wrapper for a serializable script input\.

```csharp
public class GooInput : DiGi.Rhino.Core.Classes.GooObject<DiGi.Scripting.Interfaces.ISerializableInput?>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.Types\.GH\_Goo&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1')[DiGi\.Scripting\.Interfaces\.ISerializableInput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableinput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Scripting\.Interfaces\.ISerializableInput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableinput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → GooInput
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooInput.GooInput()'></a>

## GooInput\(\) Constructor

Initializes a new instance of the [GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput') class\.

```csharp
public GooInput();
```

<a name='DiGi.Scripting.Rhino.Classes.GooInput.GooInput(DiGi.Scripting.Interfaces.ISerializableInput)'></a>

## GooInput\(ISerializableInput\) Constructor

Initializes a new instance of the [GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput') class with a specified serializable input\.

```csharp
public GooInput(DiGi.Scripting.Interfaces.ISerializableInput? serializableInput);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooInput.GooInput(DiGi.Scripting.Interfaces.ISerializableInput).serializableInput'></a>

`serializableInput` [DiGi\.Scripting\.Interfaces\.ISerializableInput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableinput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')

The serializable input to wrap\.
### Methods

<a name='DiGi.Scripting.Rhino.Classes.GooInput.Duplicate()'></a>

## GooInput\.Duplicate\(\) Method

Creates a duplicate of the current [GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput') object\.

```csharp
public override Grasshopper.Kernel.Types.IGH_Goo Duplicate();
```

Implements [Duplicate\(\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.duplicate 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.Duplicate')

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput') containing the same value\.

<a name='DiGi.Scripting.Rhino.Classes.GooInputParam'></a>

## GooInputParam Class

A persistent Grasshopper parameter for handling [GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput') objects\.

```csharp
public class GooInputParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Scripting.Rhino.Classes.GooInput, DiGi.Scripting.Interfaces.ISerializableInput>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Param&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1')[GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1') → [Grasshopper\.Kernel\.GH\_PersistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1')[GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooInput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInput 'DiGi\.Scripting\.Rhino\.Classes\.GooInput')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Scripting\.Interfaces\.ISerializableInput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableinput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooInputParam
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooInputParam.GooInputParam()'></a>

## GooInputParam\(\) Constructor

Initializes a new instance of the [GooInputParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInputParam 'DiGi\.Scripting\.Rhino\.Classes\.GooInputParam') class\.

```csharp
public GooInputParam();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.GooInputParam.ComponentGuid'></a>

## GooInputParam\.ComponentGuid Property

Gets the unique identifier for the [GooInputParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooInputParam 'DiGi\.Scripting\.Rhino\.Classes\.GooInputParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.GooOutput'></a>

## GooOutput Class

Represents a Goo object wrapper for a serializable output value\.

```csharp
public class GooOutput : DiGi.Rhino.Core.Classes.GooObject<DiGi.Scripting.Interfaces.ISerializableOutput?>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.Types\.GH\_Goo&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1')[DiGi\.Scripting\.Interfaces\.ISerializableOutput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableoutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Scripting\.Interfaces\.ISerializableOutput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableoutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → GooOutput
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooOutput.GooOutput()'></a>

## GooOutput\(\) Constructor

Initializes a new instance of the [GooOutput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutput 'DiGi\.Scripting\.Rhino\.Classes\.GooOutput') class\.

```csharp
public GooOutput();
```

<a name='DiGi.Scripting.Rhino.Classes.GooOutput.GooOutput(DiGi.Scripting.Interfaces.ISerializableOutput)'></a>

## GooOutput\(ISerializableOutput\) Constructor

Initializes a new instance of the [GooOutput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutput 'DiGi\.Scripting\.Rhino\.Classes\.GooOutput') class with a specified serializable output\.

```csharp
public GooOutput(DiGi.Scripting.Interfaces.ISerializableOutput? serializableOutput);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooOutput.GooOutput(DiGi.Scripting.Interfaces.ISerializableOutput).serializableOutput'></a>

`serializableOutput` [DiGi\.Scripting\.Interfaces\.ISerializableOutput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableoutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')

The serializable output value to wrap\.
### Methods

<a name='DiGi.Scripting.Rhino.Classes.GooOutput.Duplicate()'></a>

## GooOutput\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override Grasshopper.Kernel.Types.IGH_Goo Duplicate();
```

Implements [Duplicate\(\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.duplicate 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.Duplicate')

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooOutput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutput 'DiGi\.Scripting\.Rhino\.Classes\.GooOutput') containing the same value\.

<a name='DiGi.Scripting.Rhino.Classes.GooOutputParam'></a>

## GooOutputParam Class

Represents a persistent Grasshopper parameter for serializable output values\.

```csharp
public class GooOutputParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Scripting.Rhino.Classes.GooOutput, DiGi.Scripting.Interfaces.ISerializableOutput>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Param&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1')[GooOutput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutput 'DiGi\.Scripting\.Rhino\.Classes\.GooOutput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1') → [Grasshopper\.Kernel\.GH\_PersistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1')[GooOutput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutput 'DiGi\.Scripting\.Rhino\.Classes\.GooOutput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooOutput](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutput 'DiGi\.Scripting\.Rhino\.Classes\.GooOutput')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Scripting\.Interfaces\.ISerializableOutput](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iserializableoutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooOutputParam
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooOutputParam.GooOutputParam()'></a>

## GooOutputParam\(\) Constructor

Initializes a new instance of the [GooOutputParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooOutputParam 'DiGi\.Scripting\.Rhino\.Classes\.GooOutputParam') class\.

```csharp
public GooOutputParam();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.GooOutputParam.ComponentGuid'></a>

## GooOutputParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.GooScript'></a>

## GooScript Class

Represents a Goo wrapper for an [DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript') object\.

```csharp
public class GooScript : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Scripting.Interfaces.IScript>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.Types\.GH\_Goo&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1')[DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooScript
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooScript.GooScript()'></a>

## GooScript\(\) Constructor

Initializes a new instance of the [GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript') class\.

```csharp
public GooScript();
```

<a name='DiGi.Scripting.Rhino.Classes.GooScript.GooScript(DiGi.Scripting.Interfaces.IScript)'></a>

## GooScript\(IScript\) Constructor

Initializes a new instance of the [GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript') class with a specified script\.

```csharp
public GooScript(DiGi.Scripting.Interfaces.IScript? script);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooScript.GooScript(DiGi.Scripting.Interfaces.IScript).script'></a>

`script` [DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript')

The script object to wrap\.
### Methods

<a name='DiGi.Scripting.Rhino.Classes.GooScript.Duplicate()'></a>

## GooScript\.Duplicate\(\) Method

Creates a duplicate of the current Goo script object\.

```csharp
public override Grasshopper.Kernel.Types.IGH_Goo Duplicate();
```

Implements [Duplicate\(\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.duplicate 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.Duplicate')

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript') containing the same value\.

<a name='DiGi.Scripting.Rhino.Classes.GooScriptParam'></a>

## GooScriptParam Class

Represents a persistent parameter for [GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript') objects\.

```csharp
public class GooScriptParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.Scripting.Rhino.Classes.GooScript, DiGi.Scripting.Interfaces.IScript>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Param&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1')[GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1') → [Grasshopper\.Kernel\.GH\_PersistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1')[GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooScript](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScript 'DiGi\.Scripting\.Rhino\.Classes\.GooScript')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Scripting\.Interfaces\.IScript](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.interfaces.iscript 'DiGi\.Scripting\.Interfaces\.IScript')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → GooScriptParam
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooScriptParam.GooScriptParam()'></a>

## GooScriptParam\(\) Constructor

Initializes a new instance of the [GooScriptParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooScriptParam 'DiGi\.Scripting\.Rhino\.Classes\.GooScriptParam') class\.

```csharp
public GooScriptParam();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.GooScriptParam.ComponentGuid'></a>

## GooScriptParam\.ComponentGuid Property

Gets the unique identifier for the script component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType'></a>

## GooVariableType Class

Represents a Goo wrapper for a [DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')\.

```csharp
public class GooVariableType : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Scripting.Classes.VariableType>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.Types\.GH\_Goo&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo-1 'Grasshopper\.Kernel\.Types\.GH\_Goo\`1') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooVariableType
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.GooVariableType()'></a>

## GooVariableType\(\) Constructor

Initializes a new instance of the [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType') class\.

```csharp
public GooVariableType();
```

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.GooVariableType(DiGi.Scripting.Classes.VariableType)'></a>

## GooVariableType\(VariableType\) Constructor

Initializes a new instance of the [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType') class with the specified variable type\.

```csharp
public GooVariableType(DiGi.Scripting.Classes.VariableType? variableType);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.GooVariableType(DiGi.Scripting.Classes.VariableType).variableType'></a>

`variableType` [DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')

The variable type to wrap\.
### Methods

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.CastFrom(object)'></a>

## GooVariableType\.CastFrom\(object\) Method

Attempts to cast the specified source object to a [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')\.

```csharp
public override bool CastFrom(object? source);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The source object to cast from\.

Implements [CastFrom\(object\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.castfrom#grasshopper-kernel-types-igh_goo-castfrom(system-object) 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.CastFrom\(System\.Object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.CastTo_Y_(Y)'></a>

## GooVariableType\.CastTo\<Y\>\(Y\) Method

Attempts to cast the Goo object to the specified target type\.

```csharp
public override bool CastTo<Y>(ref Y target);
```
#### Type parameters

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.CastTo_Y_(Y).Y'></a>

`Y`

The target type\.
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.CastTo_Y_(Y).target'></a>

`target` [Y](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType.CastTo_Y_(Y).Y 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType\.CastTo\<Y\>\(Y\)\.Y')

A reference to the target variable\.

Implements [CastTo&lt;T&gt;\(T\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.castto--1#grasshopper-kernel-types-igh_goo-castto--1(--0@) 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.CastTo\`\`1\(\`\`0@\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the casting was successful; otherwise, false\.

<a name='DiGi.Scripting.Rhino.Classes.GooVariableType.Duplicate()'></a>

## GooVariableType\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override Grasshopper.Kernel.Types.IGH_Goo Duplicate();
```

Implements [Duplicate\(\)](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo.duplicate 'Grasshopper\.Kernel\.Types\.IGH\_Goo\.Duplicate')

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new instance of [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType') containing the same value\.

<a name='DiGi.Scripting.Rhino.Classes.GooVariableTypeParam'></a>

## GooVariableTypeParam Class

Represents a persistent parameter for [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')\.

```csharp
public class GooVariableTypeParam : DiGi.Rhino.Core.Classes.GooSerializablePresistentParam<DiGi.Scripting.Rhino.Classes.GooVariableType, DiGi.Scripting.Classes.VariableType>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Param&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1')[GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_param-1 'Grasshopper\.Kernel\.GH\_Param\`1') → [Grasshopper\.Kernel\.GH\_PersistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1')[GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam-1 'Grasshopper\.Kernel\.GH\_PersistentParam\`1') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → GooVariableTypeParam
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.GooVariableTypeParam.GooVariableTypeParam()'></a>

## GooVariableTypeParam\(\) Constructor

Initializes a new instance of the [GooVariableTypeParam](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableTypeParam 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableTypeParam') class\.

```csharp
public GooVariableTypeParam();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.GooVariableTypeParam.ComponentGuid'></a>

## GooVariableTypeParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.Input'></a>

## Input Class

A Grasshopper component that creates a script input variable\.

```csharp
public class Input : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Input
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.Input.Input()'></a>

## Input\(\) Constructor

Initializes a new instance of object\.

```csharp
public Input();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.Input.ComponentGuid'></a>

## Input\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.Input.Exposure'></a>

## Input\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override Grasshopper.Kernel.GH_Exposure Exposure { get; }
```

Implements [Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.exposure 'Grasshopper\.Kernel\.IGH\_DocumentObject\.Exposure')

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Scripting.Rhino.Classes.Input.Inputs'></a>

## Input\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Scripting.Rhino.Classes.Input.Outputs'></a>

## Input\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Scripting.Rhino.Classes.Input.SolveInstance(Grasshopper.Kernel.IGH_DataAccess)'></a>

## Input\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(Grasshopper.Kernel.IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.Input.SolveInstance(Grasshopper.Kernel.IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi\.Scripting\.Rhino Grasshopper plugin\.

```csharp
public class RhinoInfo : Grasshopper.Kernel.GH_AssemblyInfo
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the preferred contact details for the author\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author or company\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short string describing the purpose of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets a 24x24 pixel bitmap to represent this GHA library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Rhino.Classes.VariableType'></a>

## VariableType Class

A Grasshopper component that creates a variable type definition for scripting, specifying its name and system type\.

```csharp
public class VariableType : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Grasshopper\.Kernel\.GH\_InstanceDescription](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_instancedescription 'Grasshopper\.Kernel\.GH\_InstanceDescription') → [Grasshopper\.Kernel\.GH\_DocumentObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_documentobject 'Grasshopper\.Kernel\.GH\_DocumentObject') → [Grasshopper\.Kernel\.GH\_ActiveObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_activeobject 'Grasshopper\.Kernel\.GH\_ActiveObject') → [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → VariableType
### Constructors

<a name='DiGi.Scripting.Rhino.Classes.VariableType.VariableType()'></a>

## VariableType\(\) Constructor

Initializes a new instance of object\.

```csharp
public VariableType();
```
### Properties

<a name='DiGi.Scripting.Rhino.Classes.VariableType.ComponentGuid'></a>

## VariableType\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

Implements [ComponentGuid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.componentguid 'Grasshopper\.Kernel\.IGH\_DocumentObject\.ComponentGuid')

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Scripting.Rhino.Classes.VariableType.Exposure'></a>

## VariableType\.Exposure Property

Gets the exposure of the component, which determines its visual priority on the canvas\.

```csharp
public override Grasshopper.Kernel.GH_Exposure Exposure { get; }
```

Implements [Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_documentobject.exposure 'Grasshopper\.Kernel\.IGH\_DocumentObject\.Exposure')

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Scripting.Rhino.Classes.VariableType.Inputs'></a>

## VariableType\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Scripting.Rhino.Classes.VariableType.Outputs'></a>

## VariableType\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Scripting.Rhino.Classes.VariableType.SolveInstance(Grasshopper.Kernel.IGH_DataAccess)'></a>

## VariableType\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(Grasshopper.Kernel.IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Classes.VariableType.SolveInstance(Grasshopper.Kernel.IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.