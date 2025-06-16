using System;
using System.IO;

// Method           Description
// AppendText()	    Appends text at the end of an existing file
// Copy()	        Copies a file
// Create()	        Creates or overwrites a file
// Delete()	        Deletes a file
// Exists()	        Tests whether the file exists
// ReadAllText()	Reads the contents of a file
// Replace()	    Replaces the contents of a file with the contents of another file
// WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

File.WriteAllText("example.txt", "Hello, World!");
Console.WriteLine("File created and text written successfully.");
// Read the contents of the file
Console.WriteLine(File.ReadAllText("example.txt")); 