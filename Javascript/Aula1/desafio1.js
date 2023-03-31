
const precoCombustivel = 5.79;
const gastoMedioCombustivelKM = 10;
const distanciaViagemKM = 140;

const valorGasto = precoCombustivel * (distanciaViagemKM / gastoMedioCombustivelKM);

console.log("Você gastou: " + valorGasto.toFixed(2) + " Reais")

