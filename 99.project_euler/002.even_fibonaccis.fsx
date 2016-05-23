// my solution
let getNextFibNumber last secondToLast =
    last + secondToLast

getNextFibNumber 0 1
getNextFibNumber 1 1

let generateFibNumbersToN n =
    let rec nextFibNumber max sum x y =
        let newNum = getNextFibNumber x y
        if newNum > n
        then sum
        elif newNum % 2 = 0
        then
            let newSum = sum + newNum
            nextFibNumber max newSum y newNum
        else
            nextFibNumber max sum y newNum
    nextFibNumber n 0 0 1

generateFibNumbersToN 4000000

// other solution
Seq.unfold (fun state ->
    if (snd state > 4000000) then None
    else Some(fst state + snd state, (snd state, fst state + snd state))) (0, 1)
|> Seq.filter (fun number -> number % 2 = 0)
|> Seq.fold (+) 0




