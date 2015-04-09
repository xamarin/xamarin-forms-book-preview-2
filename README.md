# xamarin-forms-book-preview-2
Sample code for the 2nd Preview Edition of "Creating Mobile Apps with Xamarin.Forms"

Notes
-----

As of April 9, all projects in Chapters 1 to 9 have been upgraded to Xamarin.Forms 1.4.0, and those in Chapters 10 and above have been upgraded to version 1.4.1.

There's a little difference between the version of **TextVariations** here and the one in the PDF version of Chapter 7. Beginning with version 1.3.3, there is no longer a distinction between text as the content of the `Label` tags and text as content of the `Label.Text` tags. In both cases, whitespace at the beginning and end of the text block is trimmed.  

When specifying a `local` namespace declaration in XAML, it is no longer necessary to include the assembly name. You can include it if you want, but it's been removed from the **ColorListView** program in Chapter 8, **SharedStatics** in Chapter 10, and **StackedBitmap** in Chapter 13.

The deprecated `Font` has been replaced with `FontSize` in **MonkeyTap** and **XamlKeypad**, both in Chapter 8.


