let text = "random string";

let text2 = "another random string";

let finalText = text + " " + text2 + " " + 5;

console.log(finalText);


let rezult = "2" + 5;
console.log(rezult);


let phone = 30;
let price = 119.95;
let tax = 0.05;
let phoneprice = price * phone
let taxfor = phoneprice * tax;

let result = phoneprice + taxfor
console.log("Price of the " + phone +" phones with tax is: " + result + " and without the tax is:" + phoneprice)



let bo = "80";
let ob = "08";
let s = 135;
let resultt = bo + ob + s;
console.log(resultt);
// 
let resulttt = 50;

if(resulttt > 100) {
    console.log("resulttt is bigger than 100")
} else{
    console.log("You Failed")
}


let input = parseInt(prompt("enter $"));

if(input >= 50){
    alert("PARTYYYYYYYYYYY")
} else if (input >= 40) {
    alert("dinner and movie") 
} else if (input >= 30) {
    alert("dinner")
} else if (input >= 20) {
    alert("broke bitch")
} else {
    alert("strip for money") 
} 

console.log(input)