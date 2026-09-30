 ## screenshot One ##
2. Button Click Event
A Click event runs when the user clicks a button.
private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking!");
}
Meaning: When the button is clicked, a message box appears.
## screenshot two ##
3. Hello World Application
This screenshot demonstrates a simple Hello World Windows Forms application.
private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
## screenshot three ##
4. Blank Lines and Indentation
This explains how blank lines and indentation make code easier to read.
private void exitButton_Click(object sender, EventArgs e)
{
    // Close the form
    this.Close();
}
## screenshot four ##
5. Blank Lines and Indentation — Example
The code is organized using proper spacing and indentation.
namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
## screenshot five ##
6. Closing the Application Form
The screenshot explains how to close a form or application.
this.Close();
Another option is:
Application.Exit();
this.Close(); → closes the current form.
Application.Exit(); → exits the application.
## screenshot six ##
7. Syntax Errors
A syntax error happens when C# code does not follow the correct syntax. Visual Studio usually shows an error indicator.
Incorrect:
MessageBox.Show("Hello World")
The semicolon ; is missing.
Correct:
MessageBox.Show("Hello World");