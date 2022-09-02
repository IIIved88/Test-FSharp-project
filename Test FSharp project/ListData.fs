module ListData

open System
//open FSharp.Interop.Excel.ExcelProvider
open FSharp.Interop.Excel
open Microsoft.FSharp.Collections


type Data = ExcelFile<"ExcelData\ListData.xlsx", ForceString=true>
let FindByRows Index = Data |> Seq.tryFind(fun x -> x.Index=Index)