module FizzBuzzer

type System.Int32 with 
    member x.is_multiply_of number = x % number = 0
    
let FizzBuzz (x:int) = 
    if x.is_multiply_of 3 && x.is_multiply_of 5 then "fizzbuzz"
    elif x.is_multiply_of 3 then "fizz"
    elif x.is_multiply_of 5 then "buzz"
    else x.ToString()
    
