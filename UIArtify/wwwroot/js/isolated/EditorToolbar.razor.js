
export function navSlide(){
    const burger = document.querySelector('.burger');
    const nav = document.querySelector('.nav-links');
    const navLinks = document.querySelectorAll('.nav-links li')
    console.log("start")
    nav.classList.toggle("nav-active");
    
    navLinks.forEach((link,index)=>{
        if (link.style.animation){
            link.style.animation = ``;
        }
        else {
       
            link.style.animation = `SideBarTextFadeIn 0.3s ease forwards ${index/22 }s`;
            
            console.log(index/22)
            
        }
    })
    console.log("end")

}

