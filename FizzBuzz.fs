module FizzBuzzer

type System.Int32 with 
    member x.is_multiple_of number = x % number = 0
    
let FizzBuzz (x:int) = 
    match x.is_multiple_of 3, x.is_multiple_of 5 with
    true, true -> "fizzbuzz"
    |true, _ -> "fizz"
    |_, true -> "buzz"
    |_, _ -> string x
