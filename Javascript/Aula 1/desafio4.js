

const precoEtiqueta = 190;
const formaDePagamento = "DEBITO";//PIX, DINHEIRO, DEBITO, CREDITO
const quantasVezes = 1;

if (quantasVezes == 1) {
    if (formaDePagamento == "PIX" || formaDePagamento == "DINHEIRO") {
        console.log("Preço pago: " + (precoEtiqueta*0.85).toFixed(2))
    } else if (formaDePagamento == "DEBITO") {
        console.log("Preço pago: " + (precoEtiqueta*0.9).toFixed(2))
    }
} else if (quantasVezes == 2) {
    console.log("Preço pago em 2 vezes de: " + (precoEtiqueta/2).toFixed(2)+"\nTotal: "+precoEtiqueta.toFixed(2))
} else {
    console.log("Preço pago em "+quantasVezes+" vezes de: " + ((precoEtiqueta*(quantasVezes/10+1)).toFixed(2))/quantasVezes+"\nTotal: "+((precoEtiqueta*(quantasVezes/10+1)).toFixed(2)))
}

