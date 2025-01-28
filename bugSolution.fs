let x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y //Output: 10 11

let x2 = addOne x

printfn "%d" x2 //Output: 11

//Alternative (more functional):

let addOne2 x = x + 1
let y2 = addOne2 10
let z2 = addOne2 y2
printfn "%d %d %d" 10 y2 z2