module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz (n: int32) : int32 =
    // Convert input to uint64 to prevent overflow during calculations
    let unsignedN = uint64 n
    
    let mutable steps = 0
    let mutable current = unsignedN
    
    while current <> 1UL do
        // printfn "Current value: %u" current
        if current % 2UL = 0UL then
            current <- current / 2UL  // Even case
        else
            current <- 3UL * current + 1UL  // Odd case
        steps <- steps + 1
    steps
