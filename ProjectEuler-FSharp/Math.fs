module Math

let isEven x = x % 2L = 0L

let fibonacci () = Seq.unfold(fun(a,b) -> Some(a+b, (b, a+b))) (0L,1L)

let isFactorOf factor n = n % factor = 0L;

let isNumberPalindromic n = 
    let numberAsString = n |> sprintf "%i"
    let reversedNumberAsString = new string(Array.rev (numberAsString.ToCharArray()))
    numberAsString = reversedNumberAsString

let factors n =
    let sqrt_n = n |> float |> sqrt |> int64
    [1L..sqrt_n]
        |> Seq.filter (fun x -> isFactorOf x n)
        |> Seq.collect (fun x ->
            if x = sqrt_n then [x]
            else [ x; n/x ])
        |> Seq.sort

let isPrime n =
    if n <= 1L then false
    else if n = 2L then true
    else if n % 2L = 0L then false 
    else factors n |> Seq.length = 2

let getNextPrime (n:int64) =
    Seq.initInfinite (fun x -> (x |> int64) + n)
        |> Seq.find (fun x -> isPrime x = false)

let rec primeFactorisationRec n primeFactorToTry accumulator =
    if n = 1L then
        accumulator
    else if isFactorOf primeFactorToTry n then
        primeFactorisationRec (n / primeFactorToTry) primeFactorToTry (primeFactorToTry :: accumulator)
    else
        primeFactorisationRec n (getNextPrime primeFactorToTry) accumulator

let primeFactorisation n = 
    primeFactorisationRec n 2L []