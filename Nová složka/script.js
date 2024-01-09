let tlacitko = document.getElementById("tlacitko");
let cislo1 = document.getElementById("cislo1");

let cislo2 = document.createElement("input"); 
cislo2.type = "number";
cislo2.step = 0.1;
cislo2.value = 1;
document.body.appendChild(cislo2);

let tabulka = document.createElement("table")
let radek = tabulka.insertRow();
let bunka = radek.insertCell();
bunka.innerText = "1";
radek.insertCell();
bunka.innerText = "2";
radek.insertCell();
bunka.innerText = "3";
radek.insertCell();
bunka.innerText = "4";

document.appendChild(tabulka)

tlacitko.addEventListener("click", kliknuti);

function kliknuti(event){
    console.log(Number(cislo1.value) + Number(cislo2.value));
}


