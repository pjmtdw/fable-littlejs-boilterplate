module MyAwesomeProgram

open littlejs
open Fable.Core
open Fable.Import

let gameInit () = ()

let gameUpdate () = ()

let gameUpdatePost () = ()

let gameRender () = ()

let gameRenderPost () =
    littlejs.drawTextScreen ("hello world", littlejs.mainCanvasSize.scale (0.5), 80)

littlejs.engineInit (
    (fun () -> gameInit ()),
    (fun () -> gameUpdate ()),
    (fun () -> gameUpdatePost ()),
    (fun () -> gameRender ()),
    (fun () -> gameRenderPost ()),
    "tiles.png"
)
