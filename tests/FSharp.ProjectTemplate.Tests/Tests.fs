module FSKnightsTour.Tests

open NUnit.Framework

[<Test>]
let ``creating board of 5 by 5 yields 25 squares`` () =
  let result = FsKnightsTour.squares.Length
  printfn "%i" result
  Assert.AreEqual(25, result)