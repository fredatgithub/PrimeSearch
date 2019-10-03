// En savoir plus sur F# sur le site http://fsharp.org
// Voir le projet 'Didacticiel F#' pour obtenir de l'aide.
//open System
//namespace open System
//[<EntryPoint>]
//let main (argv : string[]) = 
//  printfn "my first program"      
//  0 // retourne du code de sortie entier

//open System

//[<EntryPoint>]
//let main argv =
//    printfn "Hello World from F#!"
//    0 // return an integer exit code

//open System

// Define a new function to print a name.
// It is defined above the main function.
let printGreeting name =
    printfn "Hello %s from F#!" name

[<EntryPoint>]
let main argv =
    // Call your new function!
    printGreeting "Ana"
    0 // return an integer exit code