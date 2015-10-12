open System

//function checking ages
let checkAge name age =
    //Creation of a value concatening name and age
    let field = name.ToString() + "," + age.ToString()
    //The loop return always a string type
    if age < 13 then  field + ", is a child"
    elif  (age >= 13  && age < 20) then field + ", is a child"
    else field + ", is no longer a teenager."

        
[<EntryPoint>]
let main argv = 
    // loop : check if the user wants to continue or not 
    let mutable loop = true
    while loop  do
        Console.Write("Give a name, please : ")
        let name = Console.ReadLine()
        Console.Write("How old is this person ? ")
        //checking if the input is a number
        let check, age  = System.Int32.TryParse(Console.ReadLine())
        if check then 
            //if the convertion happened, now the program use the function checkAge
            printfn "%s" (checkAge name age)
        else
            // Print a message if the input cannot be converted to an Int32
            printfn "Error: you didn't give a number."
        // continue or not 
        Console.Write("Do you want to quit ? type 'q' to quit or any key to continue.")
        let again = Console.ReadLine()
        if again = "q" then loop <- false
            
    0 // retourne du code de sortie entier
