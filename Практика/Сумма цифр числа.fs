open System

let rec func a = 
    match a with
    |0-> 0
    |_-> (func (a / 10)) + (a % 10)

[<EntryPoint>]
let main argv =
    let a = System.Convert.ToInt32(System.Console.ReadLine())
    let A = func a
    System.Console.Write(A)
    let z = System.Console.ReadKey()
    0
