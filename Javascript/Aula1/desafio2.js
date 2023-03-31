
const precoEtanol = 3.79;
const precoGasolina = 5.08;
const tipoDeCombustivel = "Etanol";
const gastoMedioCombustivelKM = 10;
const distanciaViagemKM = 140;

if(tipoDeCombustivel === "Etanol"){
    const valorGasto = precoEtanol * (distanciaViagemKM / gastoMedioCombustivelKM);
    console.log("Você gastou: " + valorGasto.toFixed(2) + " Reais")
} else if (tipoDeCombustivel === "Gasolina"){
    const valorGasto = precoGasolina * (distanciaViagemKM / gastoMedioCombustivelKM);
    console.log("Você gastou: " + valorGasto.toFixed(2) + " Reais")
} else{
    console.log("Tipo de combustivel inválido")
}




