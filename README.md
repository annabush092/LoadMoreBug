# LoadMoreBug

To reproduce bug:
- Clone and run app on iphone simulator.
- Scroll down to the bottom of the list. Expected behavior: LoadMoreItems method in MainPage.xaml.cs should be triggered, and more items should appear in the list after 10 seconds. Actual behavior: method is never hit. Placing a breakpoint on the first line of LoadMoreItems() shows the method is never called.

I've noticed that this issue occurs when MainPage is inside a NavigationPage. If the MainPage is not within a NavigationPage, it also occurs if the MainPage has the iOS Page.UseSafeArea property set to True. 

Running the application on Android devices works as it should - They do not exhibit this bug. The bug seems to be isolated to iOS only, and only if the page is located within a NavigationPage or using the Safe Area. Please advise!
