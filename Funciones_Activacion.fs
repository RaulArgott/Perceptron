namespace Perceptron

module Hardlim = 
    let hardlim sum = 
            match sum with 
                | s when s<0.0 -> 0.0
                | s -> 1.0

    let activacion = {
        fun_activacion = hardlim            
    } 
    