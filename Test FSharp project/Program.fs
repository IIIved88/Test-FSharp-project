// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

open System //System это пространство имен, которое мы можем использовать в коде

// Для справки
//Спецификаторы формата printf ! нужны того, чтобы консоль понимала тип выводимых данных
//%c - Символ
//%s - Строка символов
//%d, i - Целое десятичное со знаком
//%o - Целое восьмеричное
//%u - Целое десятичное без знака
//%x, X - Целое шестнадцатеричное
//%f - Дробное число в фиксированном формате
//%e, E - Дробное число в научном формате
//%g, G - Дробное число в научном или фиксированном формате
//%p - Указатель (в шестнадцатеричном виде)

//Простые функции

let Name = "Daniil"
printfn "%s" Name

let Age = 28
printfn "Age:%d" Age



//Как работает иммутабельность

Name = "Kirill" //Хочу изменить аргумент, но он "immutable"
printfn "%s" Name

let mutable Name1 = "Daniil" //Для возможности изменения аргумента добавляем ключевое слово "mutable" и вместо "=" ставим оператор "<-"
printfn "%s" Name1
Name1 <- "Kirill"
printfn "%s" Name1



//Арифмитические операции

let x =10
let x1 = x+25
let x2 = x>x1
printfn $"{x2}" //Вместо того, чтобы использовать разные спецификаторы для консоли, можно делать так
                // и компилятор F# будет сам определять тип данных



//Функция со значением параметра типа "unit", который представляет пустые скобки

let ShowText() = printfn "Done" //Объявление функции с параметром (), т.е нам не важно что там за параметр
//let res = ShowText() //Вызываем функцию ShowText, через встроенную функцию "res" 

let ShowText1() = printfn "Done1"
ShowText1() //Вызываем функцию ShowText

let ShowMe = printfn "Primer" //Вывод простого значения
let ShowMe1() = printfn "Primer1"//Вывод функции
//let res = ShowMe1()



//Разница в отступах многострочных функций

let ShowUs()= 
  printfn "ShowUsResult"
  let ShowUs2 = "ShowUsResult2"
  printfn $"{ShowUs2}"
ShowUs()
ShowUs()

let ShowUs1()= 
  printfn "ShowUsResult1"
let ShowUs12 = "ShowUsResult12"
printfn $"{ShowUs12}"
ShowUs1()
ShowUs1()