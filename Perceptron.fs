namespace Perceptron

type datos = {
    entradas :list<float>
    salida : float
}

type sumatoria = float list -> datos -> float -> float

type activacion = {
    fun_activacion : float -> float
}

type aprendizaje = {
    fun_aprendizaje : datos -> float list -> float -> float -> float list * float
}

type conjunto_datos = list<datos>

module PerceptronSimple =   

    let suma (x:float) (y:float) = x+y

    let sumatoria pesos datos (bias:float)= 
        List.map2(fun x w -> x*w) datos.entradas pesos 
        |> List.sum 
        |> suma bias

    let error t salida = t-salida

    let neurona (conjunto_datos:conjunto_datos) activacion aprendizaje =

        let rnd = System.Random()

        let pesos = List.map (fun x -> System.Math.Round(rnd.NextDouble(),1)) conjunto_datos.Head.entradas

        let bias = System.Math.Round(rnd.NextDouble(),1)

        printfn "Pesos iniciales: %A Bias inicial: %A" pesos bias
        
        let rec loop (conjunto_datos:conjunto_datos) (auxiliar:conjunto_datos) (pesos,bias) = 
            printfn "%A" auxiliar.Head.entradas
            match error auxiliar.Head.salida (activacion.fun_activacion (sumatoria pesos auxiliar.Head bias )),auxiliar with
                | 0.0, x::[] -> Some (pesos,bias)
                | 0.0, x::xs -> loop conjunto_datos xs (pesos,bias)
                | h,x::xs -> loop conjunto_datos conjunto_datos (aprendizaje.fun_aprendizaje x pesos bias h)
                | _, _ -> None
            
        loop conjunto_datos conjunto_datos (pesos,bias)