function MultiplyBy(value) {
    return function (y) {
        return function (z) {
            return value * y * z;
        };
    };
}