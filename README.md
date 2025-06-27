# MessageBoxLib
A shitty library for using MessageBox without using System.Windows.Forms.
# How To Install
Literally just download "MessageBoxLib.cs" and drag it into your project.
# How to Use
Button Types: Ok, OkCancel, YesNo
Icon Types: Information, Warning, Error, Question

To create a MessageBox, first import MessageBoxLib by entering "using MessageBoxLib;" at the top of your code, then to actually make a notification do:

Notifier.MessageBox("Text Here", "Title Here", "Button Type Here", "Icon Type Here");
