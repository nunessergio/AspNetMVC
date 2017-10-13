


$("button[data-acao='criar']").click(CriarPessoa);

//$("button[data-acao='editar']").on("click", EditarPessoa);

$("#main table").on("click", "button[data-acao='editar']", function () { var id = $(this).data("id"); EditarPessoa(id); });
$("button[data-acao='excluir']").click(ExcluirPessoa);


function CriarPessoa() {
    $('#telas').load("/Pessoas/Criar");
            
}

function EditarPessoa(id) {
    
    //alert("oi");

    //var id = $(this).data("id");

    //alert("ID = " + $(this).data("id"));

    $("#telas").load("/Pessoas/Atualizar" + "?id=" + id);
}


function ExcluirPessoa() {

    // Pedir confirmação antes...

    var apagar = confirm('Deseja realmente excluir este registro?');
    if (apagar){
        $("#telas").load("/Pessoas/Excluir" + "?Id=" + $(this).data("id"));
    }else{
        event.preventDefault();
    }


}

