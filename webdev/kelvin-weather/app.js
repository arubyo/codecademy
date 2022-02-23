//step 1: create a variable kelvin equal to 293
const kelvin = 15;

//step 3: create a var for celsius
const celsius = kelvin - 273;

//step 5: create a var for fahrenheit
let fahrenheit = celsius * (9 / 5) + 32;

//step 7: round fahrenheit with math.floor
fahrenheit = Math.floor(fahrenheit);

//step 9 - console.log
console.log(`The temperature is ${fahrenheit} degrees fahrenheit`);

//step 12: convert to newton
let newton = celsius * (33/100);
//round down newton
newton = Math.floor(newton)
//consolelog
console.log(`The temperature is ${newton} degrees Newton`);
