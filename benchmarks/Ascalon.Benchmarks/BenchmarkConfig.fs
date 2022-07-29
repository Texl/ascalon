namespace Ascalon.Benchmarks

[<AutoOpen>]
module BenchmarkConfigTypes =
    open BenchmarkDotNet.Configs
    open BenchmarkDotNet.Diagnosers
    open BenchmarkDotNet.Exporters
    open BenchmarkDotNet.Validators

    type BenchmarkConfig() as self =
        inherit ManualConfig()

        do
            self
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddExporter(MarkdownExporter.GitHub)
                .AddValidator(ExecutionValidator.FailOnError)
            |> ignore
