module HelloFSharp.TestFsUnit

open FsUnit
open NUnit.Framework
open HelloWorld

[<TestFixture>] 
type ``Given the hello function`` ()=

    [<Test>] member test.
     ``when I invoke it with "English" it says "Hello World"`` ()=
            hello "English" |> should equal "Hello World"

    [<Test>] member test.
     ``when I invoke it with "German" it says "Hallo Welt"`` ()=
            hello "German" |> should equal "Hallo Welt"

    [<Test>][<ExpectedException(typeof<HelloWorld.UnknownLanguage>)>] member test.
     ``when I invoke it with "Russian" it throws an exception`` ()=
            (hello "Russian" |> ignore) (*|> should throw typeof<"HelloFSharp.HelloWorld+UnknownLanguage">*)
