namespace MyApp

open System.Reactive.Concurrency
open System.Windows
open ReactiveUI

type MainViewModel () =
  let welcome = WelcomeViewModel ()

  do
    RxApp.MainThreadScheduler <- DispatcherScheduler(Application.Current.Dispatcher)

  member vm.Welcome
    with get() = welcome