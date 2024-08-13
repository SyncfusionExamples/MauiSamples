# Maui Samples
This repository contains samples for MAUI

**XAML**
```
<Grid>
    <button:MyButton Text="Custom Renderer Button from MAUI"
        VerticalOptions="Center"
        HorizontalOptions="Center"                 
        WidthRequest="300"
        HeightRequest="50"/>
</Grid>
```
**C#**

```
public Mainpage()
{            
    var grid = new Grid();        
    var customButton = new button.MyButton
    {
        Text = "Custom Renderer Button from MAUI",
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Center,
        WidthRequest = 300,
        HeightRequest = 50
    };
    grid.Children.Add(customButton);
    Content = grid;
}

```
## How to run this application?

To run this application, you need to first clone the Maui Samples repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
