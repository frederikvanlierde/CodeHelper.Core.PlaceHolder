# CodeHelper.Core.PlaceHolder
Replace the placeholders in a text with the values of the object


## Questions?
* Frederik van Lierde <https://twitter.com/@frederik_vl/>
* LinkedIN <https://www.linkedin.com/company/codehelper-dotnet/>
* NuGet Package: https://www.nuget.org/packages/CodeHelper.Core.PlaceHolder

## Versions
* 6.1.0: Formatting can be added for numbers, dates, ... (backwards compatiable)
* 6.0.1: Clean up empty query parameters when text is an url
* 6.0.0: .net6
* 5.0.0: .net5
* 1.1.1: .net Core 3.1

## Use the plugin as follows:


```C#
    using CodeHelper.Core.PlaceHolder;

    public class Location
    {
        #region Properties
        [Placeholder("{CONTACTNAME}")]
        public string ContactName { get; set; }

        [Placeholder("{USERNAME}")]
        public string UserName { get; set; }

        [Placeholder("{DATECREATED}","MMM dd, yyyy")]
        public string CreationDate { get; set; }
        #endregion
    }
```
The value `{CONTACTNAME}` can be anything.  This value will be used in your text

### Code as Static Method
```C#
    using CodeHelper.Core.PlaceHolder;

    var _generalText = "{CONTACTNAME}, your account has been created on {DATECREATED} with username {USERNAME}";
    var _location = new Location() {ContactName = "Frederik", UserName= "FrederikvanLierde", CreationDate = "2022-04-01" };    
    var updatedString = PlaceHolderHelper.Replace(_generalText, _location);
```


### Code as String Extension
```C#
    using CodeHelper.Core.PlaceHolder;

    var _generalText = "{CONTACTNAME}, your account has been created on {DATECREATED} with username {USERNAME}";
    var _location = new Location() {ContactName = "Frederik", UserName= "FrederikvanLierde", CreationDate = "2022-04-01" };    

    var _location.Replace(_location);
```

## Result:
Frederik, your account has been created on April 1, 2022 with username FrederikvanLierde