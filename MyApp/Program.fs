open System
open System.Windows
open System.Windows.Controls
open System.Windows.Markup

[<STAThread>]
[<EntryPoint>]
let main(_) =
  let appUri = Uri ("App.xaml", UriKind.Relative)
  let application = appUri
                    |> Application.LoadComponent
                    :?> Application
  application.Run() |> ignore
  0