var qtd = 5;

function Sumir(){
    var btn = document.getElementById('Paragrafo')
    if(btn.innerHTML != ""){
        btn.innerHTML = "";
    }
    else{
        alert("O Paragrafo já está invisivel")
    }  
}

function Aparecer(){
    var btn = document.getElementById('Paragrafo')
    if(btn.innerHTML == ""){
        btn.innerHTML = "Paragrafo";
    }
    else{
        alert("O paragramo Já está aparecendo!")
    }
    
}

function diminuir()
{
    if( qtd > 1){
        var btn = document.getElementById('Diminuir')
        qtd --;
        btn.innerHTML= 'Diminuir ' + qtd;
    }
    else{
        var btn = document.getElementById('Diminuir')
        btn.innerHTML = 'As Vagas Acabaram!';
        alert("As Vagas Acabaram!!")
        btn.disabled = true;
    }
}