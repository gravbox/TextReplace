# TextReplace
Template based string builder

This small application allows you to create many strings based on a template and a list of replacements. For example, you can create a set of SQL scripts with a list of values.

Template Text
```
INSERT INTO [TABLE1] (Name) VALUES ('{0}')
```

Replacement Text
```
John
Sally
Fred
```

Output
```
INSERT INTO [TABLE1] (Name) VaLUES ('John')
INSERT INTO [TABLE1] (Name) VaLUES ('Sally')
INSERT INTO [TABLE1] (Name) VaLUES ('Fred')
```
