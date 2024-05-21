
//declaration and assignment of variables

import java.util.Locale; 

public class Main { 

    public static void main(String[] args) { 

        Locale.setDefault(Locale.US); 

        int idade; 
        double salario, altura; 
        char genero; 
        String nome; 

        idade = 20; 
        salario = 5800.5; 
        altura = 1.63; 
        genero = 'F'; 
        nome = "Maria Silva"; 

        System.out.println("IDADE = " + idade); 
        System.out.println("SALARIO = " + String.format("%.2f", salario)); 
        System.out.println("ALTURA = " + String.format("%.2f", altura)); 
        System.out.println("GENERO = " + genero); 
        System.out.println("NOME = " + nome); 
    } 
} 

//"while" structure:

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int x, soma;

        soma = 0;

        System.out.print("Digite o primeiro numero: ");
        x = sc.nextInt();

        while (x != 0) {

            soma = soma + x;
            System.out.print("Digite outro numero: ");
            x = sc.nextInt();
        }
        System.out.println("SOMA = " + soma);
        sc.close();
    }
}

//"for" structure:

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int N, i, x, soma;

        System.out.print("Quantos numeros serao digitados? ");
        N = sc.nextInt();
        soma = 0;

        for (i = 1; i <= N; i++) {

            System.out.print("Digite um numero: ");
            x = sc.nextInt();
            soma = soma + x;
        }

        System.out.println("SOMA = " + soma);
        sc.close();
    }
} 

//"do while" structure:

import java.util.Locale;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {

    Locale.setDefault(Locale.US);

    Scanner sc = new Scanner(System.in);
    double C, F;
    char resp;

    do {
        System.out.print("Digite a temperatura em Celsius: ");

        C = sc.nextDouble();

        F = 9.0 * C / 5.0 + 32.0;

        System.out.printf("Equivalente em Fahrenheit: %.1f%n", F);
        System.out.print("Deseja repetir (s/n)? ");

        resp = sc.next().charAt(0);

    } while (resp == 's');

    sc.close();
    }
} 

//"vectors" structure:

import java.util.Locale;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {

        Locale.setDefault(Locale.US);

        Scanner sc = new Scanner(System.in);
        int N, i;

        System.out.print("Quantos numeros voce vai digitar? ");
        N = sc.nextInt();

        double[] vet = new double[N];

        for (i = 0; i < N; i++) {
            System.out.print("Digite um numero: ");
            vet[i] = sc.nextDouble();
        }
        System.out.println("\nNUMEROS DIGITADOS:");
        
        for (i = 0; i < N; i++) {
            System.out.println(String.format("%.1f", vet[i]));
        }

        sc.close();
    }
}
 
//"matrices" structure:

import java.util.Scanner;
public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int M, N, i, j;

        System.out.print("Quantas linhas vai ter a matriz? ");
        M = sc.nextInt();

        System.out.print("Quantas colunas vai ter a matriz? ");
        N = sc.nextInt();

        int[][] mat = new int[M][N];

        for (i = 0; i < M; i++) {

            for (j = 0; j < N; j++) {
                System.out.print("Elemento [" + i + "," + j + "]: ");
                mat[i][j] = sc.nextInt();
            }
        }

        System.out.println("\nMATRIZ DIGITADA:");

        for (i = 0; i < M; i++) {
            for (j = 0; j < N; j++) {
                System.out.println(mat[i][j] + " ");
            }

        System.out.println();
        }
        
        sc.close();
    }
} 
