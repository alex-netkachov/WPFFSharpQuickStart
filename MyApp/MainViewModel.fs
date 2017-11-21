namespace MyApp

open MyApp.Library

type MainViewModel () =
  let welcomeTextProvider = WelcomeTextProvider ()

  member vm.WelcomeText
    with get() = welcomeTextProvider.GetWelcomeText ()