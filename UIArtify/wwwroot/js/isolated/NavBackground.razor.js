console.log("NavBackgroun7d.razor.js is loaded!");
console.log("NavBackground.razor.js is loaded!");

export function empty(name) {
    console.log("Empty");
    console.log(name);
    document.getElementsByClassName("rose")[0].style = "background-color: red;\n" +
        "width: 100px;\n" +
        "height: 100px;\n" +
        "position: absolute;";
    document.getElementsByClassName("rose")[1].style = "background-color: red;\n" +
        "width: 100px;\n" +
        "height: 100px;\n" +
        "position: absolute;";
    console.log(document.documentElement.innerHTML)
}