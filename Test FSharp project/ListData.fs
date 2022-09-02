module ListData

open System
open FSharp.Interop.Excel.ExcelProvider
open FSharp.Interop.Excel


type Data = ExcelFile<"ExcelData\ListData.xlsx", ForceString=true>
//let file = new Data()
//let res = printfn file