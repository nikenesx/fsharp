open System

// Добавляет в массив spisok div столько раз, сколько раз на него делится delstepen
let rec delstepen tekushiyN div spisok =
    if (tekushiyN % div = 0) then
        delstepen (tekushiyN / div) div (div::spisok)
    else
        spisok

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

// Строит заданный список для некоторого числа N
let nschalo (Y:int) =
    // Перебирает делители и заносит простые и их повторения в список
    let rec nachalo2 tekushiyDiv (list:int list) =
        match tekushiyDiv with
        | 0 -> list
        | _ -> 
            if (etoProst tekushiyDiv) then
                nachalo2 (tekushiyDiv-1) (delstepen Y tekushiyDiv list)
            else
                nachalo2 (tekushiyDiv-1) list

    nachalo2 (Y-1) []


[<EntryPoint>]
let main argv =
    do printf "%A" (nschalo (Convert.ToInt32(Console.ReadLine())))
    let z = System.Console.ReadKey()
    0  
    
