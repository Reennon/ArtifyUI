export function dragElement(BaseId,id) {
    
    var elmnt = document.getElementById(id);
    var BaseElement =  document.getElementById(BaseId);
    var pos1 = 50, pos2 = 0, pos3 = 0, pos4 = 0;
    if (document.getElementById(elmnt.id + "header")) {
        
        document.getElementById(elmnt.id + "header").onmousedown = dragMouseDown;
    } else {
        /* otherwise, move the DIV from anywhere inside the DIV:*/
        elmnt.onmousedown = dragMouseDown;
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
        
        pos1 = pos3 - e.clientX;
        pos2 = pos4 - e.clientY;
        pos3 = e.clientX;
        pos4 = e.clientY;
        // set the element's new position:
        
        if(( elmnt.offsetTop >= BaseElement.offsetTop) && ( elmnt.offsetTop + elmnt.offsetHeight <= BaseElement.offsetTop + BaseElement.offsetHeight)) {
            elmnt.style.top = (elmnt.offsetTop - pos2) + "px";
        }
        else if( elmnt.offsetTop + elmnt.offsetHeight > BaseElement.offsetTop + BaseElement.offsetHeight){
            elmnt.style.top = (BaseElement.offsetTop + BaseElement.offsetHeight - elmnt.offsetHeight- 1 ) + "px";
        }
        else {
            elmnt.style.top = (BaseElement.offsetTop + 1) + "px";
        }
        
        if(( elmnt.offsetLeft >= BaseElement.offsetLeft) && ( elmnt.offsetLeft + elmnt.offsetWidth <= BaseElement.offsetLeft + BaseElement.offsetWidth)) {
            elmnt.style.left = (elmnt.offsetLeft - pos1) + "px";
        }
        else if( elmnt.offsetLeft + elmnt.offsetWidth > BaseElement.offsetLeft + BaseElement.offsetWidth){
            elmnt.style.left = (BaseElement.offsetLeft + BaseElement.offsetWidth- 1 -elmnt.offsetWidth) + "px";
        }
        else {
            elmnt.style.left = (BaseElement.offsetLeft+ 1) + "px";
        }
        
    }

    function closeDragElement() {
        /* stop moving when mouse button is released:*/
        document.onmouseup = null;
        document.onmousemove = null;
    }
}