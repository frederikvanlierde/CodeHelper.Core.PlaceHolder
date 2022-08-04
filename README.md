# CodeHelper.Core.PlaceHolder
Replace the placeholders in a text with the values of the object

## Use the plugin as follows:


```C# Class
    using CodeHelper.Core.PlaceHolder;

    public class Location
    {
        #region Properties
        [Placeholder("{LOCATIONNAME}")]
        public string LocationName { get; set; }
        #endregion
    }
```
The value `{LOCATIONNAME}` can be anything.  This value will be used in your text

```Code
    using CodeHelper.Core.PlaceHolder;

    var _generalText = "{LOCATIONAME}, your account has been created";
    var _location as new Location() {LocationName = "Frederik"};
    var updatedString = PlaceHolderHelper.Replace(_generalText. _location);
```


## Question?
Frederik van Lierde <https://twitter.com/@frederik_vl/>
