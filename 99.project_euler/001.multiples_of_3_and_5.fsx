let sum =
    [1..999]
    |> List.filter (fun number -> number % 3 = 0 || number % 5 = 0)
    |> List.sum
