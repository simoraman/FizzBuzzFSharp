module FizzBuzz.Tests
open FizzBuzzer
open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``When to Fizz`` ()=
    
    [<TestCaseAttribute 1>]
    [<TestCaseAttribute 2>]
    [<TestCaseAttribute 4>]
    [<TestCaseAttribute 7>]
    member test.``numbers not divisible by 3 or 5 print themselves``(number) = 
        FizzBuzz number |> should equal (number.ToString()) 

    [<TestCaseAttribute 3>]
    [<TestCaseAttribute 6>]
    [<TestCaseAttribute 9>]
    [<TestCaseAttribute 12>]  
    member test.``multiples of 3 should fizz``(x) = 
        FizzBuzz x |> should equal "fizz"

    [<TestCaseAttribute 5>]
    [<TestCaseAttribute 10>]
    [<TestCaseAttribute 20>]  
    member test.``multiples of 5 should buzz``(x) = 
        FizzBuzz x |> should equal "buzz"

    [<TestCaseAttribute 15>]
    [<TestCaseAttribute 30>]
    member test.``multiples of 3 and 5 should fizzbuzz``(x) = 
        FizzBuzz x |> should equal "fizzbuzz"


