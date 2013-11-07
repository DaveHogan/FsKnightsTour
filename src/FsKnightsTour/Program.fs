module FsKnightsTour

open System
open System.Windows

let boardSize = 5
let squareSize = 100,100
let squareSizeX, squareSizeY = squareSize
let squares = [0..boardSize * boardSize]


let canvas = System.Windows.Controls.Canvas()
let window = Window(Content=canvas)
window.Height <- (float)(squareSizeY * boardSize)
window.Width <- (float)(squareSizeX * boardSize)

let createButton e =
    let button = new System.Windows.Controls.Button()
    button.Content <- e
    button

let buttonsArray = 
    squares
    |> Seq.map(fun e -> createButton e)
    |> Seq.toArray
 
window.Content <- buttonsArray

[<STAThread>]
(new Application()).Run(window) 
    |> ignore

