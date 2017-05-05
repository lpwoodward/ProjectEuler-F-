module Program

open Problem4
open System.Diagnostics

let solveProblemWithTiming prob =
    let stopwatch = Stopwatch.StartNew()
    let solution = prob()
    stopwatch.Stop()
    solution, stopwatch.ElapsedMilliseconds

[<EntryPoint>]
let main argv = 
    printfn "Solving %s ..." "Problem 4"
    let solution, elapsedTime = solveProblemWithTiming problem4
    printfn "Solution: %s" solution
    printfn "Took %ims" elapsedTime
    System.Console.ReadKey() |> ignore
    0