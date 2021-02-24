export function projects(paths){
    console.log("in")
    paths = JSON.parse(paths);
    var prefs= paths["preferences"];
    var html_code= "";
    prefs.forEach(function(item) {
        
        html_code +=  `<li>${item}</li>`;
    });
    return html_code;
}