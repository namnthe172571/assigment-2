private Double calculate(SIGN sign, Double arg1, Double arg2) {
    switch (sign) {
        case DIVIDE:
            if (arg2 == 0) {
                throw new ArithmeticException("Cannot divide by zero");
            }
            return arg1 / arg2;
        case MULTIPLY:
            return arg1 * arg2;
        default:
            break;
    }
    return 0d;
}
