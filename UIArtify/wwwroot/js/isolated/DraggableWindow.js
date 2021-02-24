export async function dragElement(BaseId,id) {

    let element = document.getElementById(id);
    let BaseElement = document.getElementById(BaseId);
    let pos1 = 50, pos2 = 0, pos3 = 0, pos4 = 0;
    if (document.getElementById(element.id + "header")) {
        
        document.getElementById(element.id + "header").onmousedown = dragMouseDown;
    } else {
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
        element.style.zIndex = "12";
        pos1 = pos3 - e.clientX;
        pos2 = pos4 - e.clientY;
        pos3 = e.clientX;
        pos4 = e.clientY;
        
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
        document.onmouseup = null;
        document.onmousemove = null;
        element.style.zIndex = "10";
    }

}

export function resizeWatcher(id, dotNetObject){

    let item = document.getElementById(id);
    installResizeWatcher(item,1000);
    function installResizeWatcher(el, interval){
        let offset = {width: el.offsetWidth, height: el.offsetHeight}
        setInterval(()=>{
            let newOffset = {width: el.offsetWidth, height: el.offsetHeight}
            if(
                offset.height!==newOffset.height
                || offset.width!==newOffset.width)
            {
                offset = newOffset
                dotNetObject.invokeMethodAsync("BlazorWasmJSInteropEditor", "RefreshEditor");
            }
        }, interval)
    }
}
export function hideWindow(id){
    let item = document.getElementById(id);
    let height = item.offsetHeight;
    let diff = 1/20*(height - 35);
    setInterval(()=>{
        if(
            item.height !== '35px')
        {
            height -= diff
            item.style.height = `${height}px`;
        }
    }, 1)
}
