export function tree(paths){
    paths = JSON.parse(paths)
    var html_code;
    html_code = `<div class="tree"> `;
    html_code = recution_file_window(paths, html_code);
    html_code += '</div>';
    return html_code;
}


function  recution_file_window(paths, html_code){
    
    for (var items in paths)
    {
        if( items.includes(".")) {
            html_code +=  `<label class="tree-item item"><input class="tree-cb" type="radio" name="item"><span class="tree-label">${items}</span></label>`;
        }
        else {
        html_code += `<label class="tree-item item"><input class="tree-cb" type="checkbox"><span class="tree-label">${items}</span><div class="tree-branches">`;
        html_code = recution_file_window(paths[items], html_code);
        html_code +=  `</div></label>`;
        }
    }
    return html_code;
}
