module HelloFSharp.HelloWorld

exception UnknownLanguage of string

let hello = function 
  | "English" -> "Hello World"
  | "Spanish" -> "Hola Mundo"
  | "German" -> "Hallo Welt"
  | lang -> raise (UnknownLanguage lang)
