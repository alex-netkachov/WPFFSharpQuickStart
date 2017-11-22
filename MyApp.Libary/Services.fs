namespace MyApp.Library

type WelcomeTextProvider () =
  let event = new Event<string> ()

  do
    async {
        do! Async.Sleep 2000
        event.Trigger "OK"
    } |> Async.Start

  member x.GetWelcomeText() =
    "Hi there. I'm a new awesome app!"

  member x.Text with get() = event.Publish