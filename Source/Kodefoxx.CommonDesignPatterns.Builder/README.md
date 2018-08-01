### Builder
> When object construction is complicated, provide consumers with an API for doing it succinctly.
#### Why?
- Some objects are simple and can be created via the constructor, but other require a lot more complex setup to construct it.
- When more than 3 or more constructor arguments, one should consider this pattern.
- Given an API for "building" or "constructing" an object.
- Hold control over creation and how a user can created an object.

### Example of builder pattern in .NET Framework
The `StringBuilder` is a good example of a class that builds or constructs an object via a given API.

--> **Code example:**
```
   var message = "Hello!";
   var stringBuilder = new StringBuilder();

   stringBuilder.Append("<p>");
   stringBuilder.Append(message);
   stringBuilder.Append("</p>");

   Console.WriteLine(stringBuilder);
```
 --> **Ouput:**
```   
	<p>Hello!</p>
```