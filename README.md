Motivation:
Object creation logic becomes too convoluted
Constructor is not descriptive
	Name mandated by name of the containing type.
	cannot overload with same sets of arguments with different names
Object creation(non-piecewise, unlike builder) can be outsourced to
	A separate function(Factory method)
	That may exist in separate class(Factory)
	
Factory Definitions:
A component responsible solely for the wholesale(not peicewise) creation of the object.
Allow programmers to request objects and have the correct type created behind the scene and returned.
