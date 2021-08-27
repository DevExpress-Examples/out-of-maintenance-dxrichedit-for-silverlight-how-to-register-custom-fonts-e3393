<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128606201/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3393)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/MainPage.xaml.vb))
<!-- default file list end -->
# DXRichEdit for Silverlight: How to register custom fonts


<p>By default, the list of available fonts for the RichEditControl is limited. It contains local Silverlight fonts and some most recent fonts that are preloaded by the internal RichEdit code. If necessary, you can extend this list. Please follow these steps to accomplish this task:</p><p>1) Right click on your Silverlight application project folder in the Solution Explorer, choose "Add->New Item...".<br />
2) Browse to your font, select it (only *.TTF font format is supported) and click the OK button.<br />
3) Select the font, in the property grid set the" Build Action" = "Embedded Resource".<br />
3) Now, in the code behind, in order to register the font, load it via the <strong>Assembly.GetManifestResourceStream()</strong> method and call the <strong>FontManager.RegisterFontFamily()</strong> method. Pass the loaded stream and exact font name to this method. To get the exact name of the font just double click on the font in the solution explorer to open the built-in MS Windows font viewer.<br />
4) In addition, you can programmatically force this font to be a default RichEditControl font. Please use the approach from the <a href="https://www.devexpress.com/Support/Center/p/E2757">Default font and paragraph formatting - an example of use</a> example for this purpose.</p>

<br/>


