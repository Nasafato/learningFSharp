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
