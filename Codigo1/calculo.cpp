#include "calculo.h"

namespace CalculoModule {
    void InverterVariaveis(int* a, int* b) {
        int aux = *a;
        *a = *b;
        *b = aux;
    }

    double SubtrairPorcentagem(double valor, double porcentagem) {
        return valor * ((100.0 - porcentagem) / 100.0);
    }
}