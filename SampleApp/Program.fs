open System

let printGreeting =
    // let now = DateTime.Now
    let now = DateTime.Now.ToString(
        Globalization.DateTimeFormatInfo().UniversalSortableDateTimePattern
        )

    printfn $"{now}"

printGreeting