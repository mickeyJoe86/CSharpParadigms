Dynamic Language Runtime (DLR) and C# Dynamics
========================================

###Key Features

1. Dynamic Keyword allows the C# compiler to ignore type checking.
Errors for missing or misspelled member will not throw a Compiler error, but will instead throw runtime errors

2. The DLR supports dynamic keyword and dynamic aspects of mainstream CLR languages.  DLR also supports languages like Ruby and Python running on CLR.  Call site caching happens on objects and can perform quickly.

3. Supports new types Expando- and Dynamic- Objects.

4. Expando Object (*in System.Dynamic*) implements IDictionary and IEnumerable\<KeyValuePair\<string,object\>\>.  
    This means you can dynamically turn data into objects at runtime.

5. Dynamic Object more powerful than Expando, because it contains more overrides inside that can be used to influence how it behaves at runtime.

6. DLR Allows for Interop with Languages like IronRuby, IronPython, Clojure

