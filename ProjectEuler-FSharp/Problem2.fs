module Problem2

open Math

let problem2 () =
    fibonacci()
        |> Seq.takeWhile(fun x -> x <= 4000000L)
        |> Seq.filter isEven
        |> Seq.sum
        |> sprintf "%A"
 