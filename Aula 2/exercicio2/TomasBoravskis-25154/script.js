var numbers = [];
function addNumber()
{
    var value = document.getElementById("numberid").value;
    numbers.push(parseInt(value));
    document.getElementById("valueInput").innerText = numbers.toString();
    console.log(numbers);
}

function calculate()
{
    var Biggestnumber = Math.max.apply(Math, numbers);
    var value = document.getElementById("result").innertext=Biggestnumber;
    document.getElementById("result").innerText = numbers.toString();

}