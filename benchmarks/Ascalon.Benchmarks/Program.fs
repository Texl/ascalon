open BenchmarkDotNet.Running
open Ascalon.Benchmarks

[<EntryPoint>]
let main _argv =
    BenchmarkRunner.Run<Benchmarks>() |> ignore
    0 // return an integer exit code
