module ListData

open System
//open FSharp.Interop.Excel.ExcelProvider
open FSharp.Interop.Excel
open Types


type Data = ExcelFile<"ExcelData\ListData.xlsx", ForceString=true>
let Data = new Data()
let some = Data.Data |>Seq.head
//let getDefinitionByIndex index = some |> Seq.tryFind(fun  x -> string x.Index = index)
let Index a = a
let Number b = b

let ResIndex = Index "текст"
let ResNumber = Number 10.5


printfn $"Текстовый парметр Index = {ResIndex}"
printfn $"Числовой параметр Number = {ResNumber}"
//printfn $"Результат поиска ID = {ResFind}"

printfn $"{some}"

