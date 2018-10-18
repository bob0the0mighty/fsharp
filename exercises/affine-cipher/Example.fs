module AffineCipher

open System

let alphabet = [| 'a' .. 'z' |]

let m = alphabet |> Array.Length

let rec gcd = function
  | x, 0 -> x
  | x, y -> gcd (y, x % y)

let isCoprime = gcd >> (=) 1

let encode key:seq<int>, phrase:string = 
  let a,b = key |> Seq.toList
  match isCoprime a m with 
    | true -> 
    | false -> Error: a and m must be coprime.


let decode key:seq<int>, phrase:string = (encode str).Replace(" ", "")