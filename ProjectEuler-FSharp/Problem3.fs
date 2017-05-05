module Problem3

open Math

let ConvertToString (l: int list) =
    match l with
    | [] -> ""
    | h :: t -> List.fold (fun acc x -> acc + "," + x.ToString()) (h.ToString()) t

let problem3 () = 
    factors 600851475143L
        |> Seq.filter isPrime
        |> Seq.max
        |> sprintf "%i"
        
