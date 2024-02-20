const fs = require("fs");
const path = require("path");
const os = require("os");
const {Person, Car} = require("./person.js");
const { ifError } = require("assert");
let person = new Person("Martin", "V", 1);

console.log(person);
console.log(os.userInfo());
console.log();
console.log();
fs.readFileSync(path.join(__dirname, "person.js"),"utf-8",
(error, data) => {
        if (error) {
            console.log(error);
        }else{
            console.log(data);
        }
    }
)


/*fs.promises.readFile(path.join(__dirname, "person.js"), "utf-8").then(
    (data) => {
        console.log(data);
    }
).catch(error) => {
    console.log(error);
}*/

