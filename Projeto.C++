#include <iostream>

//"for" structure:

using namespace std;

int main() {

    int N, i, x, soma;

    cout << "Quantos numeros serao digitados? ";
    cin >> N;
    soma = 0;

    for (i = 1; i <= N; i++) {
        cout << "Digite um numero: ";
        cin >> x;
        soma = soma + x;

    }

    cout << "SOMA = " << soma << endl;

    return 0;
} 


//"while" structure:

int main() {
        
    int x, soma;

    soma = 0;
    cout << "Digite o primeiro numero: ";
    cin >> x;

    while (x != 0) {

        soma = soma + x;
        cout << "Digite outro numero: ";
        cin >> x;
    }

 cout << "SOMA = " << soma;

 return 0;
} 

//"do while" structure:

int main()
{
    double C, F;
    char resp;

    do {
        cout << "Digite a temperatura em Celsius: ";
        cin >> C;
        F = 9.0 * C / 5.0 + 32.0;
        cout << "Equivalente em Fahrenheit: " << F << endl;
        cout << "Deseja repetir (s/n)? ";
        cin >> resp;

    } while (resp == 's');
    
    return 0;
}

//"vectors" structure:

#include <iostream>
#include <iomanip>
using namespace std;
int main() {

    int N, i;

    cout << "Quantos numeros voce vai digitar? ";
    cin >> N;

    double vet[N];

    for (i = 0; i < N; i++) {

        cout << "Digite um numero: ";
        cin >> vet[i];
        }

    cout << endl << "NUMEROS DIGITADOS:" << endl;

    cout << fixed << setprecision(1);

    for (i = 0; i < N; i++) {

        cout << vet[i] << endl;
    }

    return 0;
} 

//"matrices" structure

#include <iostream>
using namespace std;

int main() {

    int M, N, i, j;

    cout << "Quantas linhas vai ter a matriz? ";
    cin >> M;

    cout << "Quantas colunas vai ter a matriz? ";
    cin >> N;

    int mat[M][N];
    for (i = 0; i < M; i++) {

        for (j = 0; j < N; j++) {

            cout << "Elemento [" << i << "," << j << "]: ";

            cin >> mat[i][j];
    }
    }
    cout << endl << "MATRIZ DIGITADA:" << endl;

    for (i = 0; i < M; i++) {

        for (j = 0; j < N; j++) {

            cout << mat[i][j] << " ";
        }
        cout << endl;
    }
    return 0;
} 
