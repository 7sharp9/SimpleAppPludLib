Repo steps

### From terminal  
```
git clone https://github.com/7sharp9/SimpleAppPlusLib.git
cd SimpleAppPlusLib
dotnet restore netstandardLib
```
open vs4mac

### In VS4Mac  
build netstandardLib

This results in a failure finding references:
```
/Users/dave.thomas/Projects/simpleAppPlusLib/netstandardLib/Library.fs(18,18): Error FS0039: The value, namespace, type or module 'Newtonsoft' is not defined. (FS0039) (netstandardlib)
```

### From Terminal
```
dotnet restore
```
### From VS4Mac  
build netstandardLib

build works
