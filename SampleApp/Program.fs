open System
open Microsoft.Extensions.Logging

let logger: ILogger = LoggerFactory.Create(fun builder -> builder.AddConsole().SetMinimumLevel(LogLevel.Debug) |> ignore).CreateLogger()
logger.LogDebug("HELLO!")
let printGreeting =
    let now = DateTime.Now.ToString(
        Globalization.DateTimeFormatInfo().UniversalSortableDateTimePattern
        )

    printfn $"{now}"

printGreeting