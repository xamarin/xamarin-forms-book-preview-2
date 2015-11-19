# xamarin-forms-book-preview-2
Sample code for the 2nd Preview Edition of *Creating Mobile Apps with Xamarin.Forms*.

Chapters of the book can be downloaded from http://developer.xamarin.com/guides/cross-platform/xamarin-forms/creating-mobile-apps-xamarin-forms/.

## Notes

### Loading the NuGet Packages

The Xamarin.Forms NuGet packages are not part of these projects. They must be downloaded for each project.

To avoid hassles, start by loading the NuGet packages for the two solutions in the **Libraries** directory, and building those two projects. 

First load the **Libraries/Xamarin.FormsBook.Toolkit** solution into Visual Studio. Right-click the solution name in the **Solution List** and select **Manage NuGet Packages for Solution**. A notice should appear at the top of the **Manage NuGet Packages** dialog that says "Some NuGet packages are missing from this solution. Click to restore from you online package sources." Click the **Restore** button and then the **Close** button. Build the library.

Do the same thing with the **Libraries/ElPasoHighSchool** solution.

You can then load any of the application projects. For each project, again right-click the solution name, select **Manage NuGet Packages for Solution** and go through the same process.

### Differences with Book

For some programs, there are some differences between the code listings in the PDF book chapters and those in this repository: In Chapter 7, **TextVariations** is different because beginning with version 1.3.3, there is no longer a distinction between text as the content of the `Label` tags and text as content of the `Label.Text` tags. In both cases, whitespace at the beginning and end of the text block is trimmed.  

When specifying a `local` namespace declaration in XAML, it is no longer necessary to include the assembly name. You can include it if you want, but it's been removed from the **ColorListView** program in Chapter 8, **SharedStatics** in Chapter 10, and **StackedBitmap** in Chapter 13.

The deprecated `Font` has been replaced with `FontSize` in **MonkeyTap** and **XamlKeypad**, both in Chapter 8.

### Chapter 13 and Platform-Specific Bitmaps (July 22, 2015)

The four programs in the section of Chapter 13 entitled "Platform-Specific Bitmaps" have all been enhanced to run on the two Windows Runtime platforms.

To accomplish this, a `ForPlatform` class has been added to the **Xamarin.FormsBook.Toolkit** library. This class is very similar to `OnPlatform` except that it has two additional properties named `WindowsStore` and `WindowsPhoneStore`. These properties allow a code or XAML file to access bitmaps from the two Windows Runtime projects.

### F# Versions (August 30, 2015)

All the non-SAP solutions in Chapter 2 through 6 now exist in F# versions. These can be found in the FS directory of each of those chapter directories. 

The two solutions in Chapter 2 were created manually and include F# versions of the iOS and Android startup projects (but C# versions of all the Windows Phone and Windows startup projects). 
The solutions in Chapter 3 through 6 were created from the normal Xamarin.Forms solution template for C#, and then an F# project was substituted for the PCL.

These should be considered "experimental" at this point. None of the F# projects run on Windows Phone 8, and others that use reflection have issues with the two Windows Runtime platforms.

### Upgrade to version 2.0.0.6482 (November 17, 2015)

All solutions have been upgraded to Xamarin.Forms 2.0.0.6482. 
`XAlign` and `YAlign` are now considered obsolete and have been replaced with `HorizontalContentAlignment` and `VerticalContentAlignment`.

### Additional Projects

The standard Xamarin.Forms template creates a solution with four projects: the common PCL, and application projects for iOS, Android, and Windows Phone 8.

Three more application projects have been added to every solution:

Two projects with the suffixes **WinApp** and **WinPhone81** target the Windows Runtime API in Windows 8.1 and Windows Phone 8.1, respectively.

All solutions also now have a project with the extension **UWP**. 
This project targets the Universal Windows Platform, which is implemented by Windows 10 and Windows Mobile 10. 
The UWP support in Xamarin.Forms should be considered "preview support" at this time. Some features might not be fully implemented.

You can deploy the **UWP** project to devices or emulators. 
However, you must select the correct platform for the deployment target. 
You generally do this by selecting a platform for the solution in the **Solution Platform** dropdown on the **Standard** toolbar.
Or, you can invoke the **Configuration Manager** dialog form the **Build | Configuration Manager** menu item, and select an item from the **Active solution platform** dropdown at the top right.

The six possible **Solution Platform** options are listed below. 
Each is associated with a particular platform for the **UWP** project. 
This platform refers to processor architectures:

- Any CPU: UWP platform is x86
- ARM: UWP platform is ARM
- iPhone: UWP platform is x86
- iPhone Simulator: UWP platform is x86
- x86: UWP platform is x86
- x64: UWP platform is x64

These reflect the only three possibilities for the **UWP** project. 
As you can see, x86 (32-bit Intel architecture) is considered to be the default.

Currently, you can deploy the **UWP** project in several different ways based on a selection in the dropdown on the **Standard** toolbar.

- Select **Local Machine** to deploy directly to the Windows 10 desktop. The **UWP** platform must be x86 or x64.

- Select **Simulator** to deploy to a Windows 10 simulator window. The **UWP** platform must be x86.

- Select one of the items beginning with the words **Mobile Emulator 10.0** to deploy to a Windows 10 Mobile emulator. The **UWP** platform must be x86.

- Select **Device** to deploy to a Windows 10 Mobile device. These devices are expected before the end of the year. The **UWP** platform must be ARM.



