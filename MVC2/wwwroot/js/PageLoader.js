let loader = document.querySelector(".Spinner-Wrapper");

window.addEventListener('DOMContentLoaded', () => {
  
    loader.style.opacity = '0';

    setTimeout(() => {
        loader.style.display = 'none';
    } );
    
});
