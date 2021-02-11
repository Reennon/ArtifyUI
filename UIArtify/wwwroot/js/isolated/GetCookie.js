

export function b(){
    var headers = new Headers();
    alert(headers.get("Set-Cookie"));

    var req = new XMLHttpRequest();
    req.open('POST', "http://192.168.0.102:4000/artify/login", false);
    req.send("{\"preference_name\": \"roman\", \"email\": \"roman@roman.com\", \"password\": \"roman\"}");
    headers = req.getAllResponseHeaders().toLowerCase();
    alert(headers);
}