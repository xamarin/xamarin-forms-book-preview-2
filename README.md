# xamarin-forms-book-preview-2
Sample code for the 2nd Preview Edition of "Creating Mobile Apps with Xamarin.Forms"

Notes
-----

As of April 21, all solutions have been upgraded to Xamarin.Forms 1.4.2. Two additional projects have been added to every solution with the suffixes **WinApp** and **WinPhone81**. These projects target the Windows Runtime API in Windows 8.1 and Windows Phone 8.1, respectively.

Because Xamarin.Forms 1.4.2 is a stable release, there is no longer a **windows-runtime** branch.

The support of the Windows Runtime API is still in a early state and not working entirely well. In particular, the following problems will be experienced with the **WinApp** and **WinPhone81** projects:

- Font sizes are somewhat erratic
- The `Accent` color doesn't show up
- `Device.OnPlatform` and `OnPlatform` doesn't account for the two new platforms
- The SAP programs in Chapter 9 won't compile
- Most of the programs in Chapter 13 don't work.

For some programs, there are some differences between the code listings in the PDF book chapters and those in this repository: In Chapter 7, **TextVariations** is different because beginning with version 1.3.3, there is no longer a distinction between text as the content of the `Label` tags and text as content of the `Label.Text` tags. In both cases, whitespace at the beginning and end of the text block is trimmed.  

When specifying a `local` namespace declaration in XAML, it is no longer necessary to include the assembly name. You can include it if you want, but it's been removed from the **ColorListView** program in Chapter 8, **SharedStatics** in Chapter 10, and **StackedBitmap** in Chapter 13.

The deprecated `Font` has been replaced with `FontSize` in **MonkeyTap** and **XamlKeypad**, both in Chapter 8.

