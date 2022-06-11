
function mobileMenu(){
    if(document.getElementById('navbar3').style.display == 'block'){
      document.getElementById('navbar3').style.display = 'none';
    }
    else{
      document.getElementById('navbar3').style.display = 'block';
      document.getElementById('menuicon').style.margin = "-3% 0 30px 90%"
    }
  }
  document.getElementById('menuicon').addEventListener('click',mobileMenu);
  
  function resetMenu(){
    if(window.innerWidth < 768){
      document.getElementById('navbar3').style.display = 'none';
      document.getElementById('menuicon').style.display = 'block';
      document.getElementById('menuicon').style.margin = "-3% 0 30px 90%"
    }
    else{
      document.getElementById('menuicon').style.display = 'none';
      document.getElementById('navbar3').style.display = 'block';
    }
  }
  window.addEventListener('load',resetMenu);
  window.addEventListener('resize',resetMenu);