#include<iostream>
#include<iomanip>
#include"calculo.h"

using namespace std;

int main() {
    using namespace CalculoModule;

    int a;
    int b;

    cout << "Digite dois numeros: ";
    cin >> a;
    cin >> b;

    if(b > a) {
        InverterVariaveis(&a, &b);
    }

    double resultado = SubtrairPorcentagem(static_cast<double>(a), static_cast<double>(b));

    cout << fixed << setprecision(2);
    cout << "Resultado: " << resultado << endl; 
}