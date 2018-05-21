module Program

open Problem1
open System.Diagnostics

let solveProblemWithTiming prob =
    let stopwatch = Stopwatch.StartNew()
    let solution = prob()
    stopwatch.Stop()
    solution, stopwatch.ElapsedMilliseconds

[<EntryPoint>]
let main argv = 
    printfn "Solving %s ..." "Problem 1"
    let solution, elapsedTime = solveProblemWithTiming problem1
    printfn "Solution: %s" solution
    printfn "Took %ims" elapsedTime
    System.Console.ReadKey() |> ignore
    0