
function addTable() {

    var myTableDiv = document.getElementById("myDynamicTable");

    var table = document.createElement('TABLE');
    table.border = '1';

    var tableBody = document.createElement('TBODY');
    table.appendChild(tableBody);

    for (var i = 0; i < 1; i++) {
        var tr = document.createElement('TR');
        tableBody.appendChild(tr);

        for (var j = 0; j < 1; j++) {
            var td = document.createElement('TD');
            td.width = '75';
            td.appendChild(document.createTextNode("Naam: "));

            tr.appendChild(td);
        }
        for (var j = 0; j < 1; j++) {
            var td = document.createElement('TD');
            td.width = '75';
            td.appendChild(document.createTextNode("Macharis "));

            tr.appendChild(td);
        }
    }
    for (var i = 0; i < 1; i++) {
        var tr = document.createElement('TR');
        tableBody.appendChild(tr);

        for (var j = 0; j < 1; j++) {
            var td = document.createElement('TD');
            td.width = '75';
            td.appendChild(document.createTextNode("Voornaam: "));

            tr.appendChild(td);
        }
        for (var j = 0; j < 1; j++) {
            var td = document.createElement('TD');
            td.width = '75';
            td.appendChild(document.createTextNode("Jos: "));

            tr.appendChild(td);
        }
    }
    for (var i = 0; i < 1; i++) {
        var tr = document.createElement('TR');
        tableBody.appendChild(tr);

        for (var j = 0; j < 1; j++) {
            var td = document.createElement('TD');
            td.width = '150';
            td.appendChild(document.createTextNode("Geboorte Datum: "));

            tr.appendChild(td);
        }
        for (var j = 0; j < 1; j++) {
            var td = document.createElement('TD');
            td.width = '150';
            td.appendChild(document.createTextNode("22/01/2005: "));

            tr.appendChild(td);
        }
    }
    myTableDiv.appendChild(table);

}



function addImage() {
    var img = document.createElement("IMG");
    img.src = "~/images/handje.png";
    document.getElementById('image').appendChild(img);


}

function addButton() {
 

    var buttonnode = document.createElement('input');
    buttonnode.setAttribute('type', 'button');
    buttonnode.setAttribute('name', 'Details');
    buttonnode.setAttribute('value', 'Details');

    buttonnode.href = "~/ouder/Kindprofiel.aspx";
    document.getElementById('button').appendChild(buttonnode);


}
function load() {

    console.log("Page load finished");

}