open FizzBuzzer
open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``When to Fizz`` ()=
    [<Test>] 
    member test.``One should not fizzbuzz``() = 
        FizzBuzz 1 |> should equal "1"

    [<Test>] 
    member test.``3 should fizz``() = 
        FizzBuzz 3 |> should equal "fizz"

    [<Test>] 
    member test.``5 should buzz``() = 
        FizzBuzz 5 |> should equal "buzz"

    [<TestCaseAttribute 3>]
    [<TestCaseAttribute 6>]
    [<TestCaseAttribute 9>]
    [<TestCaseAttribute 12>]  
    member test.``multiplies of 3 should fizz``(x) = 
        FizzBuzz x |> should equal "fizz"

    [<TestCaseAttribute 5>]
    [<TestCaseAttribute 10>]
    [<TestCaseAttribute 20>]  
    member test.``multiplies of 5 should buzz``(x) = 
        FizzBuzz x |> should equal "buzz"

    [<TestCaseAttribute 15>]
    [<TestCaseAttribute 30>]
    member test.``multiplies of 3 and 5 should fizzbuzz``(x) = 
        FizzBuzz x |> should equal "fizzbuzz"


