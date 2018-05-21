module Problem1

let isFactorOf3Or5 n =
    match n with
        | n when n % 3 = 0 -> true
        | n when n % 5 = 0 -> true
        | _ -> false

let problem1 () =
    [1..999]
        |> Seq.filter isFactorOf3Or5
        |> Seq.sum
        |> sprintf "%i"