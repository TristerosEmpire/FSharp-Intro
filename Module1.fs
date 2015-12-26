open System

// Don't worry about the formula : it's not important.
// Defining the calculation of a cylinder
// Function name : vol
// Parameters :
// r -> radius
// h -> height
// both are floating numbers
let volume (r : float) (h : float) = (2.0 * 3.14 * Math.Pow(r, 2.0)) * h

// Entry point of the program
[<EntryPoint>]
let main argv =
  //Read values from the command line
  Console.WriteLine("Enter the height of the cylinder : ")
  let h = Console.ReadLine()
  Console.WriteLine("Enter the radius of the cylinder : ")
  let r = Console.ReadLine()
  
  //calculation and 'converting' radius and height values to float type
  let result = volume (float r) (float h)
  
  //display the result on the screen
  printfn "%f" result
  
  //wait an action from user to (turn off the terminal and) quit the program
  Console.ReadKey()
  //Exit the program
  0
