let addingCalculator input = input + 1

let loggingCalculator innerCalculator input =
   printfn "input is %A" input
   let result = innerCalculator input
   printfn "result is %A" result
   result

let result = loggingCalculator addingCalculator 1

let add1 input = input + 1
let times2 input = input * 2

let genericLogger anyFunc input =
   printfn "input is %A" input   //log the input
   let result = anyFunc input    //evaluate the function
   printfn "result is %A" result //log the result
   result                        //return the result

let add1WithLogging = genericLogger add1
let times2WithLogging = genericLogger times2
