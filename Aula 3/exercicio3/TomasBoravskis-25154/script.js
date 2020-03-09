function getInfo(){
    var link = document.getElementById("link");

    var lista = document.getElementById("info");

    lista.innerHTML =
        'ID:' + link.id + '<br>'+
        'Target:' + link.target + '<br>'+
        'Type:' + link.type + '<br>' +
        'href:' + link.href + '<br>';

}

function changeColorToRed()
{
    var titles = document.getElementsByClassName("titulo")
    for(let title of titles)
    {
        title.style.color = "red";
    }
}

function onClickCell(elementOfArrayCells)
{
    elementOfArrayCells.innerText = prompt("LABAS");
    elementOfArrayCells.style.backgroundColor ="green";
}

function setClickCell()
{
    var cells = document.getElementsByTagName("td");

    for(let elementOfArrayCells of cells)
    {
        elementOfArrayCells.onclick = function ()
        {
            onClickCell(elementOfArrayCells);
        }
    }

}

setClickCell();