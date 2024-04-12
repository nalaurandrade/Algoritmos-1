/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld {
    static void Main() {
        Console.WriteLine("Digite a nota do aluno");
        double notaDoAluno = Convert.ToDouble(Console.ReadLine());

        if (notaDoAluno >= 90) {
            Console.WriteLine("A");
        }
        else if (notaDoAluno >= 80) {
            Console.WriteLine("B");
        }
        else if (notaDoAluno >= 70) {
            Console.WriteLine("C");
        }
        else if (notaDoAluno >= 60) {
            Console.WriteLine("D");
        }
        else {
            Console.WriteLine("F");
        }
    }
}
