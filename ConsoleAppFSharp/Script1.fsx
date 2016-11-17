// Storing integers and strings.
let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
let stringList = [ "one"; "two"; "three" ]

// You cannot mix types in a list. The following declaration causes a
// type-mismatch compiler error.
//let failedList = [ 5; "six" ]

// In F#, functions can be stored in a list, as long as the functions
// have the same signature.

// Function doubleIt has the same signature as squareIt, declared previously.
//let squareIt = fun n -> n * n
let doubleIt = fun n -> 2 * n

let number = 12
        
    // Lists.

// Storing integers and strings.
let integerList = [ 1; 2; 3; 4; 5; 6; 7 ]
let stringList = [ "one"; "two"; "three" ]

// You cannot mix types in a list. The following declaration causes a
// type-mismatch compiler error.
//let failedList = [ 5; "six" ]

// In F#, functions can be stored in a list, as long as the functions
// have the same signature.

// Function doubleIt has the same signature as squareIt, declared previously.
//let squareIt = fun n -> n * n
let doubleIt = fun n -> 2 * n

// Functions squareIt and doubleIt can be stored together in a list.
//let funList = [ squareIt; doubleIt ]

// Function squareIt cannot be stored in a list together with a function
// that has a different signature, such as the following body mass
// index (BMI) calculator.
// let BMICalculator = fun ht wt -> (float wt / float (squareIt ht)) * 703.0

// The following expression causes a type-mismatch compiler error.
//let failedFunList = [ squareIt; BMICalculator ]


// Tuples.

// Integers and strings.
let integerTuple = ( 1, -7 )
let stringTuple = ( "one", "two", "three" )

// A tuple does not require its elements to be of the same type.
let mixedTuple = ( 1, "two", 3.3 )

// Similarly, function elements in tuples can have different signatures.
let funTuple = ( squareIt, BMICalculator )

// Functions can be mixed with integers, strings, and other types in
// a tuple. Identifier num was declared previously.
//let num = 10
  let moreMixedTuple = ( num, "two", 3.3, squareIt )
    
    
    
    let isDone = false
printfn "Printing Boolean values: %b %b" isDone (not isDone)
let s1,s2 = "test1", @"C:\test2"
printfn "Printing strings (note literal printing of string with special character): %s%s" s1 s2
let i1, i2 = -123, 1891
printfn "Printing an integer in decimal form, with and without a width: %d %10d" i1 i2
printfn "Printing an integer in lowercase hexadecimal: %x or 0x%x" i1 i2
printfn "Printing as an unsigned integer: %u %u" i1 i2
printfn "Printing an integer as uppercase hexadecimal: %X or 0x%X" i1 i2
printfn "Printing as an octal integer: %o %o" i1 i2
printfn "Printing in columns." 
for i in 115 .. 59 .. 1000 do
    printfn "%10d%10d%10d%10d%10d" (10100015-i) (i-100) (115+i) (99992/i) (i-8388229)
let x1, x2 = 3.141592654, 6.022E23
printfn "Printing floating point numbers %e %e" x1 x2
printfn "Printing floating point numbers %E %E" x1 x2
printfn "Printing floating point numbers %f %f" x1 x2
printfn "Printing floating point numbers %F %F" x1 x2
printfn "Printing floating point numbers %g %G" x1 x2
printfn "Using the width and precision modifiers: %10.5e %10.3e" x1 x2

printfn "Using the flags:\nZero Pad:|%010d| Plus:|%+10d |LeftJustify:|%-10d| SpacePad:|% d|" 1001 1001 1001 1001 
printfn "zero pad   | |+- both   | |- and ' ' | |' ' and 0 | | normal " 
for i in -115 .. 17 .. 100 do
    printfn "|%010d| |%+-10d| |%- 10d| |% 010d| |%10d|" (80-i) (i+85) (100+i) (99992/i) (i-80)

let d = 0.124M
printfn "Decimal: %M" d

printfn "Print as object: %O %O %O %O" 12 1.1 "test" (fun x -> x + 1)

printfn "%A" [| 1; 2; 3 |]

printfn "Printing from a function (no args): %t" (fun writer -> writer.WriteLine("X"))

printfn "Printing from a function with arg: %a" (fun writer (value:int) -> writer.WriteLine("Printing {0}.", value)) 10

