module Problem4

open Math

let problem4() = 
    let numbers = [100..999]
    numbers
        |> Seq.collect(fun x -> numbers |> Seq.map(fun y -> x * y))
        |> Seq.filter isNumberPalindromic
        |> Seq.max
        |> sprintf "%i"