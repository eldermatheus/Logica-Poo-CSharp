using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaBancaria
    {
        public string titular;
        public int numeroConta;
        public double saldo;

        public ContaBancaria()
        {
        }
        public ContaBancaria(string nome, int numero, double saldo)
        {
            this.titular = nome;
            this.numeroConta = numero;
            this.saldo = saldo;
        }

        public void sacar(double valor)
        {
            saldo -= valor;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public void teste()
        {
        }

        override
        public string ToString()
        {
            return
                "Titular: "
                + titular
                + "\r\n"
                + "Conta:  "
                + numeroConta
                + "\r\n"
                + "Saldo atual: " + saldo;
        }
    }
}