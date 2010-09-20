module HelloFSharp.Test

open System
open NUnit.Framework
open HelloWorld

[<TestFixture>]
type Test() =

    [<Test>]
    member this.English () =
        Assert.AreEqual("Hello World", hello "English",
            "hello must return \"Hello World\" in English")

    [<Test>] [<ExpectedException(typeof<HelloWorld.UnknownLanguage>)>]
    member this.Russian () =
        hello "Russian" |> ignore
