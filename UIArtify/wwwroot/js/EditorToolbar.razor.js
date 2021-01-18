

function sleep(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds){
            break;
        }
    }
}



function navSlide() {
    const burger = document.querySelector('.burger');
    const nav = document.querySelector('.nav-links');
    const navLinks = document.querySelectorAll('.nav-links li')

    burger.addEventListener('click',()=>{
        nav.classList.toggle("nav-active");

        navLinks.forEach((link,index)=>{
            if (link.style.animation){
                link.style.animation = '';
            }
            else {
                link.style.animation = `navLinkFade 0.2s ease forwards ${index/7 }s`;
                console.log(index)
            }
        })

    })
}


/*
const navSlide = () =>{
    const burger = document.querySelector('.burger');
    const nav = document.querySelector('.nav-links');
    const navLinks = document.querySelectorAll('.nav-links li')
    burger.addEventListener('click',()=>{
        nav.classList.toggle("nav-active");

        navLinks.forEach((link,index)=>{
            if (link.style.animation){
                link.style.animation = '';
            }
            else {
                link.style.animation = `navLinkFade 0.2s ease forwards ${index/7 }s`;
                console.log(index)
            }
        })

    })
}
navSlide();
*/