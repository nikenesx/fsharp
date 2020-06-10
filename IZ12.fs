open System

// Проверка числа на простоту
let etoProst Y =
    let rec prost d =
        if (Y % d = 0 && d < Y) then
            false
        else
            if (d > Y) then
                true
            else
                prost (d+1)

    if (Y = 1||Y=4)then
        false
    else
        if (Y = 2) then
            true
        else
            prost 3

let nschalo (Y:int) =
    let rec nachalo2 tekushiyDiv (list:int list) =
        match tekushiyDiv with
        | 0 -> list
        | _ -> 
            if (etoProst tekushiyDiv) then
                nachalo2 (tekushiyDiv-1) 
            else
                nachalo2 (tekushiyDiv-1) list

    nachalo2 (Y-1) []

[<EntryPoint>]
let main argv =
    
    let z = System.Console.ReadKey()
    0  
