// Task 1

// let num = 128;
// pow=0;
// while(num>=2){
//     num/=2;
//     pow++;
// }
// if(num == 1){
//     console.log("Eded "+pow+"-in quvvetidir");
// }else if(num <= 1.5){
//     console.log("Eded "+pow+"-in quvvetine yaxindir");
// }else{
//     pow++;
//     console.log("Eded "+pow+"-in quvvetine yaxindir");
// }



//TASK 2

// let num = 65487;
// let sum = 0;

// while (num) {
//     sum += num % 10;
//     num = (num-num%10)/10;
// }

// console.log(sum);

// Task 3

let num = 24;
let numOfDivider = 2;
for (let i = 2; i < num; i++) {
    if(num%i == 0){
        numOfDivider++;
        break;
    }
}
if(numOfDivider==3){
    console.log("Eded murekkebdir");
}else{
    console.log("Eded sadedir");
}
