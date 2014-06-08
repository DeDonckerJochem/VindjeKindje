
function addTable(aantal) {

    var myTableDiv = document.getElementById("myDynamicTable"+aantal);

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
            td.setAttribute('id', 'Naam'+aantal);
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
/*function adddiv(aantal) {

    var iDiv = document.createElement('div');
    iDiv.id = 'block'+aantal;
    iDiv.className = 'block'+aantal;

}*/


function addImage(aantal) {
    var img = document.createElement("IMG");
    img.style.border = "1px solid #000";
    img.style.width = "200px";
    img.style.height = "200px";
    img.style.margin = "15px";
    img.src = ("Profile-pictures-children/kind.jpg");
    img.setAttribute('id', 'image' + aantal);
    //document.getElementById('image').src = "~/images/handje.png";
    document.getElementById('image'+aantal).appendChild(img);
    


}

function addButton(aantal) {
 

    var buttonnode = document.createElement('input');
    buttonnode.setAttribute('type', 'button');
    buttonnode.setAttribute('name', 'Kind Details');
    buttonnode.setAttribute('value', 'Kind Details');
    
    buttonnode.setAttribute('id', 'Button'+aantal);
    
    
    buttonnode.setAttribute('href','../ouder/Kindprofiel.aspx');
    
    document.getElementById('button'+aantal).appendChild(buttonnode);


}
function load() {

    console.log("Page load finished");

}