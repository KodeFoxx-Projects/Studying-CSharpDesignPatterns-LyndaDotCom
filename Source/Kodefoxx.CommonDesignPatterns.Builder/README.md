= BUILDER =
== Why? ==
- Some objects are simple and can be created via the constructor, but other require a lot more complex setup to construct it.
- When more than 3 or more constructor arguments, one should consider this pattern.
- Given an API for "building" or "constructing" an object.
- Hold control over creation and how a user can created an object.

> When object construction is complicated, provide consumers with an API for doing it succinctly.