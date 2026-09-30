 # C# progrming I
 ## courese information

 Course Title: Visual Programming (C#.NET)
 Prerequisites: Programming
 Instructor: Yahye Ali 
 
# C# Chapter 1  Slide-by-Slide Concepts

# Slide 1 Topics
.Concepts:
.Objects
.Program Development Process
.Visual Studio
.Forms & Controls
.C# Code
.Hello World
.Labels
.IntelliSense
.PictureBox
.Comments & Indentation
.Closing Forms
.Syntax Errors
# Slide 2  Objects
# Concept: Object
.Object = a program component that contains data and performs operations.
.Properties = data stored in an object.
.Methods = operations an object can perform.
# Example:
A Button is an object with properties and operations/events. 

# Slide 3  Wage Calculator / Objects
# Concept: Objects in a GUI
.Form = an object.
.Label = an object.
.TextBox = an object.
.Button = an object.
.Each object performs a specific task. 

# Slide 4 Controls
# Concept: Controls
.Controls are objects that are visible in a GUI.
.Common controls:
.Label
.Button
.TextBox
.Some GUI objects are invisible, such as Timer and OpenFileDialog.
.Class = code that describes a particular type of object. 

# Slide 5 .NET Framework
# Concept: .NET
.NET is a collection of classes and other code used to create Windows applications.
.C# is a language supported by .NET.
.Controls are defined by specialized classes provided by .NET.
.You can create your own classes. 

# Slide 6 Visual Studio
# Concept: IDE
.Visual Studio is a professional Integrated Development Environment (IDE).
.Important windows:
.Designer Window
.Solution Explorer
.Properties Window 

# Slide 7 Visual Studio Environment
# Concept: Visual Studio Interface
.Visual Studio contains different windows and tools used to create applications.
.The Designer is used to design the GUI.
.Other windows help manage the project and objects.

# Slide 8 — Solution Explorer
# Concept: Solution Explorer
.Displays the project as an expandable list.
.It can contain:
.Properties
.References
.Form1

# Slide 9 — Auto Hide
# Concept: Auto Hide
.Auto Hide allows a window to display only as a tab at the edge.
.It gives more space for the main workspace. 

# Slide 10  Menu Bar and Standard Toolbar
# Concepts:
Menu Bar
**Provides menus such as:**
.File
.Edit
.View
.Project
**Standard Toolbar**
.Contains buttons for frequently used commands. 

# Slide 11  Toolbar Buttons
# Concept: Common Commands
Important commands include:
.New Project
.Open
.Save
.Save All
.Undo
.Redo
.Start Debugging
.Find

# Slide 12  Toolbox
# Concept: Toolbox
.Toolbox is a window used for selecting controls.
.It is normally on the left side of Visual Studio.
.It can use Auto Hide.

# Slide 13  Toolbox Sections
# Concept: Control Categories
The Toolbox contains sections such as:
.All Windows Forms
.Common Controls
# Examples:
.Button
.CheckBox
.ComboBox
.Label
.ListBox
.ListView
.TextBox
.MonthCalendar  

# Slide 14   Tooltips
# Concept: Tooltip
.A Tooltip is a small box that appears when you hover the mouse pointer over an item.
.It provides information about that item.

# Slide 15  Docked and Floating Windows
# Concepts:
**Docked Window**
.Attached to an edge of the Visual Studio environment.
**Floating Window**
.Can be moved around the screen.
You can right-click the title bar and choose Float or Dock. 

# Slide 16  Projects and Solutions
# Concepts:
Project
.Represents the application you create.
.Contains several files.
**Solution**
.A container that can hold one or more projects.
**Remember:**
Solution → Project → Files 

# Slide 17  Specifying the Project Name
# Concept: Project Naming
When saving a project, you can specify:
.Project name
.Location
.Solution name 

# Slide 18 Displaying the Designer
# Concept: View Designer
If the Form does not appear:
.Right-click Form1.cs in Solution Explorer.
.Click View Designer. 

**FORMS AND CONTROLS**
# Slide 19  Windows Form
# Concept: Form
.A new Windows Forms App automatically creates an empty form named Form1.
.The form is the main window of the application.
.The slide gives the initial size as 300 × 300 pixels. 

# Slide 20  Form Bounding Box
# Concept: Bounding Box
.A Form in the Designer is enclosed by a dotted bounding box.
.Sizing handles allow you to resize the Form. 

# Slide 21  Properties Window
# Concept: Properties
.Properties determine how an object looks and behaves.
.The Properties Window lists the object's properties.
.Left column = property name.
.Right column = property value.

# Slide 22  Changing a Property
# Concept: Changing Property Values
**Steps:**
1.Select the object.
2.Open the Properties Window.
3.Find the property.
4.Change its value.
**Example:**
Text = Form1
**change to:**
Text = My First Program 

# Slide 23  Property Organization
# Concepts:
**Alphabetical**
.Properties are displayed in alphabetical order.
**Categorized**
.Properties are displayed in groups.
Categorized is the default setting. 

# Slide 24  Adding Controls to a Form
# Concept: Adding Controls
**You can add a control by:**
.Double-clicking the control in the Toolbox.
.Dragging the control onto the Form.
You can also:
.Resize it.
.Move it.
.Change its properties.
.Delete it. 

# Slide 25  Rules for Naming Controls
# Concept: Identifiers
Control names are called identifiers.
**Rules:**
.First character must be a letter or underscore _.
.Other characters can be letters, numbers, or underscores.
.Spaces are not allowed.

showDayButton
DisplayTotal
_ScoreLabel
``` 22

---

# Slide 26  camelCase
**Concept: camelCase**

- Start with lowercase letters.
- The first character of the second and following words is uppercase.

**Examples:**
```text
showDayButton
calculateTotal
studentName
``` 23

---

#  C# CODE

##  Slide 27  First Visual C# Application
**Concept: GUI Application**

The application contains:
- A Form
- A Button

When the Button is clicked, it displays:

`Hello World`

This introduces GUI design and coding. 24

---

# Slide 28  Introduction to C# Code
**Concepts: Code Organization**

C# code is mainly organized into:

1. **Namespace**
2. **Class**
3. **Method**

- Namespace → contains classes.
- Class → contains methods.
- Method → contains programming statements.
- Source code file → file containing program code. 25

---

# Slide 29  Source Code Files
**Concept: Program.cs and Form1.cs**

**Program.cs**
- Contains the application's startup code.

**Form1.cs**
- Contains code associated with Form1. 26

---

# Slide 30  View Code
**Concept: Opening Source Code**

You can open source code through Solution Explorer:

1. Right-click the Form.
2. Select **View Code**. 27

---

# Slide 31  Organization of Form1.cs
**Concepts:**

Form1.cs contains:
- User-defined namespace
- Class declaration
- Method

These organize the C# program. 28

---

# Slide 32  Adding Your Code
**Concept: Event-Driven Programming**

GUI applications are **event-driven**.

The program waits for an event such as:
- Mouse click
- Key press
- Mouse movement

Then the program responds.

**Event Handler**
- A method that executes when a specific event occurs. 29

---

# Slide 33  Message Boxes
**Concept: MessageBox**

- A MessageBox displays a message.
- .NET provides `MessageBox.Show`.

**Example:**
```csharp
MessageBox.Show("Thanks for clicking the button!");
It can be placed inside an event handler. 

# Slide 34  Hello World Application
#Concept: Button Click Event
When the button is clicked, the event handler can execute:
MessageBox.Show("Hello World");
**This demonstrates:**
.Event
.Event Handler
.MessageBox 

** LABELS **
# Slide 35  Label Controls
# Concept: Label
A Label control displays text on a Form.
**Important properties:**
.Text
.Name
.Font
.BorderStyle
.AutoSize
.TextAlign 

# Slide 36  Text Alignment
# Concept: TextAlign
**Text can be positioned in:**
.TopLeft
.TopCenter
.TopRight
.MiddleLeft
.MiddleCenter
.MiddleRight
.BottomLeft
.BottomCenter
.BottomRight 

# Slide 37  Displaying Output in a Label
# Concepts:
**Assignment Operator**
=
.The item receiving the value is on the left.
.Label's Text property accepts a string.
.An empty string clears the Label.

answerLabel.Text = ""

#  INTELLISENSE

# Slide 38  IntelliSense
**Concept: IntelliSense**

IntelliSense provides automatic code completion.

It can suggest:
- Keywords
- Variables
- Methods
- Classes
- Properties

It helps programmers write code and find language elements more easily. 

---

#  PICTUREBOX

# Slide 39  PictureBox Controls
**Concept: PictureBox**

A PictureBox displays a graphic image on a Form.

Important properties:
- `Image` → specifies the image.
- `SizeMode` → specifies how the image is displayed.
- `Visible` → determines whether the control is visible. 

---

##  Slide 40  Creating Clickable Images
**Concept: PictureBox Click Event**

- Double-click the PictureBox in Designer.
- Visual Studio creates a Click event handler.
- You can add code that executes when the image is clicked. 

---

# Slide 41  Sequential Execution
**Concept: Sequential Execution**

- Statements execute in the order they appear.
- The order of statements is important.
- Incorrect sequence can cause a **logic error**.

**Example:**
```csharp
cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;

The first statement makes the back visible, and the second hides the face. Chapter_01_Gaddis_CSharp_6e_accessible.pptx
**COMMENTS & INDENTATION*?*
#  Slide 42  Comments
Concept: Comments
Comments are notes in source code that explain how parts of the program work.
Single-line comment:
// Make image of the card back visible.
Block comment:
/*
   Line one
   Line two
*/


# Slide 43  Blank Lines and Indentation
**Concepts:**

- Blank lines make code easier to read.
- Indentation makes the structure of code easier to understand.
- They improve **readability** of the source code. 

---

**CLOSING FORMS**

# Slide 44  Closing an Application's Form
**Concept: Closing Forms**

To close the current Form:

```csharp
this.Close();
To close the whole application:
Application.Exit();
Remember:
this.Close() → current Form
Application.Exit() → whole application Chapter_01_Gaddis_CSharp_6e_accessible.pptx
**SYNTAX ERRORS**
# Slide 45  Dealing with Syntax Errors
Concept: Syntax Error
Visual Studio examines statements as you type.
Syntax errors are shown with a jagged/red underline.
If a syntax error exists, compilation/execution will show an error.
Example:
MessageBox.sho("Hello World");
Here sho is incorrect, so Visual Studio indicates an error. Chapter_01_Gaddis_CSharp_6e_accessible.pptx