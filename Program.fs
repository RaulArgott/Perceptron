// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Perceptron

[<EntryPoint>]
let main argv =
    match  PerceptronSimple.neurona OR.conjunto_datos Hardlim.activacion Unnamed.aprendizaje with
        | None -> printfn "Error"
        | Some n -> printfn "Resultado: %A " n


    0