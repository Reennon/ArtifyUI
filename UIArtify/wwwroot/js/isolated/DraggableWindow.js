export async function dragElement(BaseId,id) {

    let element = document.getElementById(id);
    let BaseElement = document.getElementById(BaseId);
    let pos1 = 50, pos2 = 0, pos3 = 0, pos4 = 0;
    if (document.getElementById(element.id + "header")) {
        
        document.getElementById(element.id + "header").onmousedown = dragMouseDown;
    } else {
        /* otherwise, move the DIV from anywhere inside the DIV:*/
        element.onmousedown = dragMouseDown;
    }
    

    function dragMouseDown(e) {
        e = e || window.event;
        e.preventDefault();
        
        pos3 = e.clientX;
        pos4 = e.clientY;
        document.onmouseup = closeDragElement;
        
        document.onmousemove = elementDrag;
    }

    function elementDrag(e) {
        e = e || window.event;
        e.preventDefault();
        // calculate the new cursor position:
        element.style.zIndex = "12";
        pos1 = pos3 - e.clientX;
        pos2 = pos4 - e.clientY;
        pos3 = e.clientX;
        pos4 = e.clientY;
        // set the element's new position:
        
        if(( element.offsetTop >= BaseElement.offsetTop) && ( element.offsetTop + element.offsetHeight <= BaseElement.offsetTop + BaseElement.offsetHeight)) {
            element.style.top = (element.offsetTop - pos2) + "px";
        }
        else if( element.offsetTop + element.offsetHeight > BaseElement.offsetTop + BaseElement.offsetHeight){
            element.style.top = (BaseElement.offsetTop + BaseElement.offsetHeight - element.offsetHeight- 1 ) + "px";
        }
        else {
            element.style.top = (BaseElement.offsetTop + 1) + "px";
        }
        
        if(( element.offsetLeft >= BaseElement.offsetLeft) && ( element.offsetLeft + element.offsetWidth <= BaseElement.offsetLeft + BaseElement.offsetWidth)) {
            element.style.left = (element.offsetLeft - pos1) + "px";
        }
        else if( element.offsetLeft + element.offsetWidth > BaseElement.offsetLeft + BaseElement.offsetWidth){
            element.style.left = (BaseElement.offsetLeft + BaseElement.offsetWidth- 1 -element.offsetWidth) + "px";
        }
        else {
            element.style.left = (BaseElement.offsetLeft+ 1) + "px";
        }
        
    }

    function closeDragElement() {
        /* stop moving when mouse button is released:*/
        document.onmouseup = null;
        document.onmousemove = null;
        element.style.zIndex = "10";
    }
}