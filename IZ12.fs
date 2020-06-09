open System

// Проверка числа на простоту
let thisPrime N =
    let rec prime d =
        if (N % d = 0 && d < N) then
            false
        else
            if (d > N) then
                true
            else
                prime (d+1)

    if (N = 1) then
        false
    


[<EntryPoint>]
let main argv =
    
    let z = System.Console.ReadKey()
    0

