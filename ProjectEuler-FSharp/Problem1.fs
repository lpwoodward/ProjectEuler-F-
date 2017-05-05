module Problem1

open Math

let problem1 () =
    [1..999]
        |> Seq.filter(fun n -> n % 5 = 0 || n % 3 = 0)
        |> Seq.sum
        |> sprintf "%i"