### Builder
> When object construction is complicated, provide consumers with an API for doing it succinctly.
#### Why?
- Some objects are simple and can be created via the constructor, but other require a lot more complex setup to construct it.
- When more than 3 or more constructor arguments, one should consider this pattern.
- Given an API for "building" or "constructing" an object.
- Hold control over creation and how a user can created an object.

### Example of builder pattern in .NET Framework
The `StringBuilder` is a good example of a class that builds or constructs an object via a given API.

**Code example:**
```
   var message = "Hello!";
   var stringBuilder = new StringBuilder();

   stringBuilder.Append("<p>");
   stringBuilder.Append(message);
   stringBuilder.Append("</p>");

   Console.WriteLine(stringBuilder);
```
**Ouput:**
```   
   <p>Hello!</p>
```

### Life without the Builder pattern
Say one wants to build an unordered list (`<ul>`) given an set of words using the `StringBuilder`.

**Code example:**
```
   var words = new [] { "Random", "words" };
   var stringBuilder = new StringBuilder();

   stringBuilder.Append("<ul>");
   foreach(var word in words)
      stringBuilder.Append($"<li>{word}</li>");
   stringBuilder.Append("</ul>");

   Console.WriteLine(stringBuilder);
```

**Ouput:**
```   
   <ul><li>Random</li><li>words</li></ul>
```

This looks ok, but in fact the foreach and the prepending/closing of the `<ul>` tag is in fact a lot of exposed code which can be encapsulated and made more user friendly.

### Life with the Builder pattern
First we make a class representing an html tag.
```
   public class HtmlElement {
      public string Name { get; }
	  public string Text { get; }
	  public List<HtmlElement> Elements { get; }

	  public HtmlElement(string name, string text) {
          Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
		  Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
	  	  Elements = new List<HmlElement>();
	  }
	  internal HtmlElement() { }

	  private string ToStringWithIndentation(int indentationSize, int indentationLevel) {
	      var stringBuilder = new StringBuilder();
		  var indenationString = new String(' ', indendationSize * indentationLevel);

		  stringBuilder.Append($"{indenationString}<{Name}>");

		  if(!stringIsNullOrWhiteSpace(Text))
			stringBuilder.Append(Text);

		  foreach(var element in Elements)
		    stringBuilder.Append(ToStringWithIndentation(indenationSize, indenationLevel++))

          stringBuilder.AppendLine($"</{Name}>");

		  return stringBuilder.ToString();
	  }

	  public override ToString()
         => ToStringWithIndentation(2, 0);
   }
```

Then make a sort of _"naive"_ `HtmlBuilder':
```
   public class HtmlBuilder {
   	   private HtmlElement _rootElement = new HtmlElement();

	   public HtmlBuilder(string rootName) {
	   	   _rootElement = new HtmlElement(rootName, "");
	   }

	   public AddChild(string childName, string ChildText) {
	   	   var childElement = new HtmlElement(childName, childText);
		   _rootElement.Elements.Add(childElement);
	   }

	   public override ToString()
	      => _rootElement.ToString();

	   public void Clear() {
	   	   _rootElement = new HtmlElement(_rootElement.Name);
	   }
   }
```

**One can use it then like this:**
```
   var htmlBuilder = new HtmlBuilder("ul");

   htmlBuilder.AddChild("li", "Random");
   htmlBuilder.AddChild("li", "text");

   Console.WriteLine(htmlBuilder);
```

**Output:**
```
   <ul>
      <li>Random</li>
	  <li>text</li>
   </ul>
```