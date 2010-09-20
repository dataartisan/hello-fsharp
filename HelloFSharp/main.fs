module main

printfn "%s" "Hello World"
printfn "%s" (HelloFSharp.HelloWorld.hello "German")

open HelloFSharp.HelloWorld

try

    printfn "%s" (hello "English")
    printfn "%s" (hello "Spanish")
    printfn "%s" (hello "Russian")
    printfn "%s" (hello "German")

with
    | UnknownLanguage lang ->
        printfn "unknown language: %s" lang
