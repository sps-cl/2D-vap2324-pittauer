let platno = document.getElementById("platno");
let kontext = platno.getContext("2d");

let stredKruhuX = 100;
let stredKruhuY = 100;

platno.onmousemove = move;

function move(event) {
    let rect = platno.getBoundingClientRect();
    stredKruhuX = event.clientX;
    stredKruhuY = event.clientY;
}

function nakresli() {
    kontext.clearRect(0, 0, platno.clientWidth, platno.clientHeight);
    kontext.beginPath();
    kontext.arc(stredKruhuX, stredKruhuY, 50, 0, 2 * Math.PI);
    kontext.fill();
    kontext.fillStyle = "red";
    kontext.fillRect(100, 100, 100, 100);
    kontext.fillStyle = "purple";
    requestAnimationFrame(nakresli);
}

 nakresli();