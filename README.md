*Check the wiki for more information*

Assignment: Implementing the Abstract Factory Design Pattern in a Console Application (C#)

Objective:
The objective of this assignment is to implement the Abstract Factory Design Pattern in a C# console application. You will create families of related or dependent objects (UI elements) and encapsulate their creation in concrete factories without exposing the client code to the specific classes.

Assignment Tasks

Task 1: Define Abstract Products

Create abstract product interfaces representing different types of products that your application will generate.

    Requirements:
        Define an interface for IButton with a method Render() to simulate drawing the button.
        Define an interface for ITextBox with a method Render() to simulate drawing the textbox.

Task 2: Implement Concrete Products

Implement concrete product classes for two distinct UI platforms, such as Windows and Mac.

    Requirements:
        Create concrete classes implementing the IButton interface for both Windows and Mac platforms.
        Create concrete classes implementing the ITextBox interface for both Windows and Mac platforms.
        Each concrete class should provide a unique implementation of the Render() method to simulate the rendering of the specific UI component for its platform.

Task 3: Define Abstract Factory

Create an abstract factory interface that declares methods for creating related products (button and textbox).

    Requirements:
        Define an interface IUIFactory that declares methods for creating both buttons and textboxes (CreateButton(), CreateTextBox()).

Task 4: Implement Concrete Factories

Implement concrete factory classes that create the respective UI components (button and textbox) for each platform.

    Requirements:
        Create concrete factory classes for Windows and Mac platforms that implement the IUIFactory interface.
        The concrete factory methods should return instances of the appropriate product classes (buttons and textboxes) for the specific platform.

Task 5: Create Client Code (Application)

Write the client code that uses the abstract factory to create the UI components without depending on the concrete classes.

    Requirements:
        Create a class Application that takes an IUIFactory object in its constructor.
        Implement a method in the Application class to create and render a button and a textbox using the provided factory.
        Ensure that the application can switch between different factories (e.g., WindowsFactory, MacFactory) dynamically.

Task 6: Implement the Main Method

Write a Main() method in a console application that demonstrates the use of the Abstract Factory pattern.

    Requirements:
        In the Main() method, instantiate different UI factories (e.g., WindowsFactory, MacFactory).
        Pass these factories to the Application class to render the UI components for each platform.
        Output the result to the console, showing which platform-specific UI components are being rendered.

Hints & Tips:

    Use abstract products and abstract factories to decouple the client code from concrete classes.
    Ensure flexibility by allowing the client to dynamically select the UI platform at runtime by choosing the appropriate factory.
    Console application: Focus on clear and simple console output that demonstrates the different UI elements (buttons, textboxes) being rendered for each platform.

This assignment will help you implement the Abstract Factory design pattern in a real-world scenario where you can create platform-specific UI components.
