namespace Perceptron

module OR =
    let p1 =
        {
            entradas = [0.0;0.0]
            salida = 0.0
        }
    let p2 = 
        {
            entradas = [0.0;1.0]
            salida = 1.0
        }
    let p3 = 
        {
            entradas = [1.0;0.0]
            salida = 1.0
        }
    let p4 = 
        {
            entradas = [1.0;1.0]
            salida = 1.0
        }

    let conjunto_datos:conjunto_datos = [p1;p2;p3;p4]