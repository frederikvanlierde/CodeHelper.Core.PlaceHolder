# CodeHelper.Core.PlaceHolder
Replace the placeholders in a text with the values of the object

NuGet Package: https://www.nuget.org/packages/CodeHelper.Core.PlaceHolder

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
        #endregion
    }
```
The value `{CONTACTNAME}` can be anything.  This value will be used in your text

### Code as Static Method
```C#
    using CodeHelper.Core.PlaceHolder;

    var _generalText = "{CONTACTNAME}, your account has been created with username {USERNAME}";
    var _location = new Location() {ContactName = "Frederik", UserName= "FrederikvanLierde"};    
    var updatedString = PlaceHolderHelper.Replace(_generalText, _location);
```

### Code as String Extension
```C#
    using CodeHelper.Core.PlaceHolder;

    var _generalText = "{CONTACTNAME}, your account has been created with username {USERNAME}";
    var _location = new Location() {ContactName = "Frederik", UserName= "FrederikvanLierde"};

    var _location.Replace(_location);
```

## Question?
Frederik van Lierde <https://twitter.com/@frederik_vl/>
