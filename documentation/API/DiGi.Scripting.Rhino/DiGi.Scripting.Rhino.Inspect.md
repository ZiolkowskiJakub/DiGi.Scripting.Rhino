#### [DiGi\.Scripting\.Rhino](DiGi.Scripting.Rhino.Overview.md 'DiGi\.Scripting\.Rhino\.Overview')

## DiGi\.Scripting\.Rhino\.Inspect Namespace
### Classes

<a name='DiGi.Scripting.Rhino.Inspect.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Name(thisDiGi.Scripting.Classes.Input)'></a>

## Inspect\.Name\(this Input\) Method

Extracts the name from the specified script input and wraps it in a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static Grasshopper.Kernel.Types.GH_String? Name(this DiGi.Scripting.Classes.Input? input);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Name(thisDiGi.Scripting.Classes.Input).input'></a>

`input` [DiGi\.Scripting\.Classes\.Input](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.input 'DiGi\.Scripting\.Classes\.Input')

The script input variable to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') wrapping the name, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Name(thisDiGi.Scripting.Classes.Output)'></a>

## Inspect\.Name\(this Output\) Method

Extracts the name of the script output as a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')\.

```csharp
public static Grasshopper.Kernel.Types.GH_String? Name(this DiGi.Scripting.Classes.Output? output);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Name(thisDiGi.Scripting.Classes.Output).output'></a>

`output` [DiGi\.Scripting\.Classes\.Output](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.output 'DiGi\.Scripting\.Classes\.Output')

The script output to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the name, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the output is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Name(thisDiGi.Scripting.Classes.VariableType)'></a>

## Inspect\.Name\(this VariableType\) Method

Extracts the name from a [DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType') and wraps it in a [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') for Grasshopper inspection\.

```csharp
public static Grasshopper.Kernel.Types.GH_String? Name(this DiGi.Scripting.Classes.VariableType? variableType);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Name(thisDiGi.Scripting.Classes.VariableType).variableType'></a>

`variableType` [DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')

The variable type to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the name, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Type(thisDiGi.Scripting.Classes.VariableType)'></a>

## Inspect\.Type\(this VariableType\) Method

Extracts the system type from a [DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType') and wraps it in a [DiGi\.Rhino\.Core\.Classes\.GooType](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gootype 'DiGi\.Rhino\.Core\.Classes\.GooType') for Grasshopper inspection\.

```csharp
public static DiGi.Rhino.Core.Classes.GooType? Type(this DiGi.Scripting.Classes.VariableType? variableType);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Type(thisDiGi.Scripting.Classes.VariableType).variableType'></a>

`variableType` [DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')

The variable type to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooType](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gootype 'DiGi\.Rhino\.Core\.Classes\.GooType')  
A [DiGi\.Rhino\.Core\.Classes\.GooType](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gootype 'DiGi\.Rhino\.Core\.Classes\.GooType') containing the system type, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Value(thisDiGi.Scripting.Classes.Input)'></a>

## Inspect\.Value\(this Input\) Method

Extracts the value from the specified script input and wraps it in a [DiGi\.Rhino\.Core\.Classes\.GooObject](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject 'DiGi\.Rhino\.Core\.Classes\.GooObject')\.

```csharp
public static DiGi.Rhino.Core.Classes.GooObject? Value(this DiGi.Scripting.Classes.Input? input);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Value(thisDiGi.Scripting.Classes.Input).input'></a>

`input` [DiGi\.Scripting\.Classes\.Input](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.input 'DiGi\.Scripting\.Classes\.Input')

The script input variable to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooObject](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject 'DiGi\.Rhino\.Core\.Classes\.GooObject')  
A [DiGi\.Rhino\.Core\.Classes\.GooObject](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject 'DiGi\.Rhino\.Core\.Classes\.GooObject') wrapping the value, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Value(thisDiGi.Scripting.Classes.Output)'></a>

## Inspect\.Value\(this Output\) Method

Extracts the value of the script output as a [DiGi\.Rhino\.Core\.Classes\.GooObject](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject 'DiGi\.Rhino\.Core\.Classes\.GooObject')\.

```csharp
public static DiGi.Rhino.Core.Classes.GooObject? Value(this DiGi.Scripting.Classes.Output? output);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.Value(thisDiGi.Scripting.Classes.Output).output'></a>

`output` [DiGi\.Scripting\.Classes\.Output](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.output 'DiGi\.Scripting\.Classes\.Output')

The script output to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooObject](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject 'DiGi\.Rhino\.Core\.Classes\.GooObject')  
A [DiGi\.Rhino\.Core\.Classes\.GooObject](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject 'DiGi\.Rhino\.Core\.Classes\.GooObject') wrapping the value, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the output is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.VariableType(thisDiGi.Scripting.Classes.Input)'></a>

## Inspect\.VariableType\(this Input\) Method

Extracts the variable type from the specified script input and wraps it in a [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')\.

```csharp
public static DiGi.Scripting.Rhino.Classes.GooVariableType? VariableType(this DiGi.Scripting.Classes.Input? input);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.VariableType(thisDiGi.Scripting.Classes.Input).input'></a>

`input` [DiGi\.Scripting\.Classes\.Input](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.input 'DiGi\.Scripting\.Classes\.Input')

The script input variable to inspect\.

#### Returns
[GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')  
A [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType') wrapping the variable type, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.VariableType(thisDiGi.Scripting.Classes.Output)'></a>

## Inspect\.VariableType\(this Output\) Method

Extracts the variable type of the script output as a [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')\.

```csharp
public static DiGi.Scripting.Rhino.Classes.GooVariableType? VariableType(this DiGi.Scripting.Classes.Output? output);
```
#### Parameters

<a name='DiGi.Scripting.Rhino.Inspect.Inspect.VariableType(thisDiGi.Scripting.Classes.Output).output'></a>

`output` [DiGi\.Scripting\.Classes\.Output](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.output 'DiGi\.Scripting\.Classes\.Output')

The script output to inspect\.

#### Returns
[GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType')  
A [GooVariableType](DiGi.Scripting.Rhino.Classes.md#DiGi.Scripting.Rhino.Classes.GooVariableType 'DiGi\.Scripting\.Rhino\.Classes\.GooVariableType') wrapping the variable type, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the output is null\.