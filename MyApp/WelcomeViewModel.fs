namespace MyApp

open ReactiveUI
open MyApp.Library

type WelcomeViewModel () as this =
  inherit ReactiveObject ()

  let welcomeTextProvider = WelcomeTextProvider ()

  let mutable welcomeText = ""

  do
      welcomeTextProvider.Text
      |> Event.add (fun text -> this.WelcomeText <- text)

  member vm.WelcomeText
    with get() = welcomeText
    and set value = this.RaiseAndSetIfChanged (&welcomeText, value, "WelcomeText")
                    |> ignore