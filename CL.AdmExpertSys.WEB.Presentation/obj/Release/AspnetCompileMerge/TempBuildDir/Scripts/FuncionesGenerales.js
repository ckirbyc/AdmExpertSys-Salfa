function lpad(cadena, largo, caracter) {
    for (var i = cadena.length + 1; i <= largo; i++)
        cadena = caracter + cadena;
    return cadena;
}

function digitoVerificador(t) {
    var m = 0,
                s = 1;
    for (; t; t = Math.floor(t / 10)) {
        s = (s + t % 10 * (9 - m++ % 6)) % 11;
    }
    return s ? s - 1 : 'K';
}

function rutValido(rut) {
    rut = rut.split('.').join('').split('-').join('');
    rut = lpad(rut, 9, '0');
    var rutSdv = rut.substring(0, 8);
    var dv = digitoVerificador(rutSdv);
    rutSdv = rutSdv + dv;
    if (rut.toLowerCase() === rutSdv.toLowerCase())
        return true;
    else
        return false;
}

function formateaRut(pvarInput, pvarFormato) {
    if (pvarInput.value == '') {
        return;
    }

    var wvarValor = pvarInput.value;

    wvarValor = wvarValor.toUpperCase();
    var wvarValorFormateado = "";
    var wvarIndex = 0;

    while (wvarValor.indexOf(".") > -1) {
        wvarValor = wvarValor.replace(".", "");
    }

    while (wvarValor.indexOf("-") > -1) {
        wvarValor = wvarValor.replace("-", "");
    }

    while (wvarValor.charAt(0) == '0' && wvarValor.length > 1) {
        wvarValor = wvarValor.replace("0", "");
    }

    wvarIndex = wvarValor.length - 1;
    for (var i = pvarFormato.length - 1; i >= 0; i--) {
        if (pvarFormato.charAt(i) == "X") {
            if (wvarIndex < 0) {
                wvarValorFormateado = "0" + wvarValorFormateado;
            }
            else {
                wvarValorFormateado = wvarValor.charAt(wvarIndex) + wvarValorFormateado;
                wvarIndex--;
            }
        }
        else {
            wvarValorFormateado = pvarFormato.charAt(i) + wvarValorFormateado;
        }
    }

    if (wvarIndex >= 0) {
        wvarValorFormateado = wvarValor.substring(0, wvarIndex + 1) + wvarValorFormateado;
    }

    while ((wvarValorFormateado.charAt(0) == '0' || wvarValorFormateado.charAt(0) == '.') && wvarValorFormateado.length > 1) {
        if (wvarValorFormateado.charAt(0) == '0') {
            wvarValorFormateado = wvarValorFormateado.replace("0", "");
        }
        else {
            wvarValorFormateado = wvarValorFormateado.replace(".", "");
        }
    }
    if (wvarValorFormateado == "-") wvarValorFormateado = "";
    pvarInput.value = wvarValorFormateado;

}