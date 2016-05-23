// my solution
let sum =
    [1..999]
    |> List.filter (fun number -> number % 3 = 0 || number % 5 = 0)
    |> List.sum


let sum =
    [1 .. 999]
    |> Seq.filter (fun num -> num % 3 = 0 || num % 5 = 0)
    |> Seq.fold (+) 0
