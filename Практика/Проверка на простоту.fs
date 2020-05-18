//Число на простоту.
open System

let prime n =
    let rec prost n m = 
        if n = m then true
        else if n % m = 0 then false
             else prost n (m + 1)
    match n with
    |1->false
    |2->true
    |_-> prost n 2    

[<EntryPoint>]
let main argv =
    let value = System.Convert.ToInt32(System.Console.ReadLine()) 
    let ans = prime value
    System.Console.Write(ans)
    let z = System.Console.ReadKey()
    0
