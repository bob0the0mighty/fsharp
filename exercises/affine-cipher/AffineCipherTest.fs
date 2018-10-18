// This file was auto-generated based on version 2.0.0 of the canonical data.

module AffineCipherTest

open FsUnit.Xunit
open Xunit

open AffineCipher

[<Fact>]
let ``Encode yes`` () =
    encode {
  "a": 5,
  "b": 7
} "yes" |> should equal "xbt"

[<Fact(Skip = "Remove to run test")>]
let ``Encode no`` () =
    encode {
  "a": 15,
  "b": 18
} "no" |> should equal "fu"

[<Fact(Skip = "Remove to run test")>]
let ``Encode OMG`` () =
    encode {
  "a": 21,
  "b": 3
} "OMG" |> should equal "lvz"

[<Fact(Skip = "Remove to run test")>]
let ``Encode O M G`` () =
    encode {
  "a": 25,
  "b": 47
} "O M G" |> should equal "hjp"

[<Fact(Skip = "Remove to run test")>]
let ``Encode mindblowingly`` () =
    encode {
  "a": 11,
  "b": 15
} "mindblowingly" |> should equal "rzcwa gnxzc dgt"

[<Fact(Skip = "Remove to run test")>]
let ``Encode numbers`` () =
    encode {
  "a": 3,
  "b": 4
} "Testing,1 2 3, testing." |> should equal "jqgjc rw123 jqgjc rw"

[<Fact(Skip = "Remove to run test")>]
let ``Encode deep thought`` () =
    encode {
  "a": 5,
  "b": 17
} "Truth is fiction." |> should equal "iynia fdqfb ifje"

[<Fact(Skip = "Remove to run test")>]
let ``Encode all the letters`` () =
    encode {
  "a": 17,
  "b": 33
} "The quick brown fox jumps over the lazy dog." |> should equal "swxtj npvyk lruol iejdc blaxk swxmh qzglf"

[<Fact(Skip = "Remove to run test")>]
let ``Encode with a not coprime to m`` () =
    encode {
  "a": 6,
  "b": 17
} "This is a test." |> should equal {
  "error": "a and m must be coprime."
}

[<Fact(Skip = "Remove to run test")>]
let ``Decode exercism`` () =
    decode {
  "a": 3,
  "b": 7
} "tytgn fjr" |> should equal "exercism"

[<Fact(Skip = "Remove to run test")>]
let ``Decode a sentence`` () =
    decode {
  "a": 19,
  "b": 16
} "qdwju nqcro muwhn odqun oppmd aunwd o" |> should equal "anobstacleisoftenasteppingstone"

[<Fact(Skip = "Remove to run test")>]
let ``Decode numbers`` () =
    decode {
  "a": 25,
  "b": 7
} "odpoz ub123 odpoz ub" |> should equal "testing123testing"

[<Fact(Skip = "Remove to run test")>]
let ``Decode all the letters`` () =
    decode {
  "a": 17,
  "b": 33
} "swxtj npvyk lruol iejdc blaxk swxmh qzglf" |> should equal "thequickbrownfoxjumpsoverthelazydog"

[<Fact(Skip = "Remove to run test")>]
let ``Decode with no spaces in input`` () =
    decode {
  "a": 17,
  "b": 33
} "swxtjnpvyklruoliejdcblaxkswxmhqzglf" |> should equal "thequickbrownfoxjumpsoverthelazydog"

[<Fact(Skip = "Remove to run test")>]
let ``Decode with too many spaces`` () =
    decode {
  "a": 15,
  "b": 16
} "vszzm    cly   yd cg    qdp" |> should equal "jollygreengiant"

[<Fact(Skip = "Remove to run test")>]
let ``Decode with a not coprime to m`` () =
    decode {
  "a": 13,
  "b": 5
} "Test" |> should equal {
  "error": "a and m must be coprime."
}

