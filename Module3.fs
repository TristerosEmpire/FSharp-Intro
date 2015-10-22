open System
(* 
   function computeGR : compute for a single value, the golden ratio of this one.
   parameter : value (integer)
   return a float 
*)
let computeGR value:float = 
    value * (1.0+Math.Sqrt(5.0))/2.0

[<EntryPoint>]
let main argv =
    // Purpose : Create an application that uses the Golden Ratio 
    // to calculate a product for each value in a sequence or list.
    Console.Write("How many numbers do you want to compute ? ")
    let size = Console.ReadLine()

    (*
     loopAskNumbers is a special function using a unit as paramater 
     acting as a parameterless function and
     return a tuple
    *)
    let loopAskNumbers () = 
        Console.Write("Enter a number (integer or decimal) : ")
        // Read the input 
        let input = Console.ReadLine()
        let result = computeGR (float input)
        ((float input),result)

    // Final list with tuples of float :
    // [(input, result_computed)]
    let resultList = [
        for i=0 to (int)size-1 do
            yield loopAskNumbers ()
    ]

    printfn "Result : %A" resultList
    0