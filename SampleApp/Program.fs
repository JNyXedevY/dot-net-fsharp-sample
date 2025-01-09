open System

let printGreeting =
    // let now = DateTime.Now
    let now = DateTime.Now.ToString("o")
    printfn $"{now}"

printGreeting