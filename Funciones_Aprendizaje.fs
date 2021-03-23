namespace Perceptron 

module Unnamed =
    let unamed (datos:datos) pesos bias error = 
        (List.map2(fun x y -> (error*x)+y) datos.entradas pesos,error+bias)
    
    let aprendizaje = {
        fun_aprendizaje = unamed    
    }