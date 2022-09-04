module ListData

open System
//open FSharp.Interop.Excel.ExcelProvider
open FSharp.Interop.Excel
open Types


type Data = ExcelFile<"ExcelData\ListData.xlsx", ForceString=true>
let Data = new Data()
let some = Data.Data
let getHead = some |>Seq.head
let getTryFind index = some |>Seq.tryFind (fun x -> x.Id=index  )
let Index a = a
let Number b = b

let ResIndex = Index "текст"
let ResNumber = Number 10.5


printfn $"Текстовый парметр Index = {ResIndex}"
printfn $"Числовой параметр Number = {ResNumber}"
//printfn $"Результат поиска ID = {ResFind}"

printfn $"Какие-то данные с head: {getHead}"
printfn $"Какие-то данные с tryFind: {getTryFind}"

