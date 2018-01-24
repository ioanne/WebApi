values = [["Australia", "Germany", "United States of America"]]

function Longest_Country_Name(values) {
    var max = 0;
    var indice_max = 0;
    cantidad = values[0].length
    for (i = 0; i <= cantidad - 1; i++) {
        var value = values[i]
        if (value != undefined) {
            if (value.length > max) {
                max = value.length.length;
                indice_max = i
            }
        }
    }
    console.log(values[indice_max])
    return values[indice_max]
}