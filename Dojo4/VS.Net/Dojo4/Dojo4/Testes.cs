using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo4
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestaProgramadorJunior()
        {
            string nome = "José";
            double horas = 176;

            ProgramadorJunior p = new ProgramadorJunior(nome, horas);

            Assert.AreEqual(horas * 30, p.CalculaSalario());
        }

        [TestMethod]
        public void TestaProgramadorJunior2()
        {
            string nome = "Josenivaldo";
            double horas = 100;

            ProgramadorJunior p = new ProgramadorJunior(nome, horas);

            Assert.AreEqual(3000, p.CalculaSalario());
            Assert.AreEqual(nome, p.GetNome());
        }

        [TestMethod]
        public void TestaProgramadorPleno()
        {
            string nome = "Augusto";
            double horas = 160;

            ProgramadorPleno p = new ProgramadorPleno(nome, horas);

            Assert.AreEqual(horas * 45, p.CalculaSalario());
            Assert.AreEqual(nome, p.GetNome());
        }

        [TestMethod]
        public void TestaProgramadorSenior()
        {
            string nome = "Alice";
            double horas = 128;

            ProgramadorSenior p = new ProgramadorSenior(nome, horas);

            Assert.AreEqual(horas * 80, p.CalculaSalario());
            Assert.AreEqual(nome, p.GetNome());
        }

        [TestMethod]
        public void TestaProgramadorNinja()
        {
            string nome = "Osmar";
            double horas = 128;

            ProgramadorNinja p = new ProgramadorNinja(nome, horas);

            Assert.AreEqual(horas * 1000, p.CalculaSalario());
            Assert.AreEqual(nome, p.GetNome());
        }

        [TestMethod]
        public void TestaGerente()
        {
            string nome = "Maria";
            double horas = 160;
            double bonus = 1000;

            Gerente p = new Gerente(nome, horas, bonus);

            Assert.AreEqual(horas * 100 + bonus, p.CalculaSalario());
            Assert.AreEqual(nome, p.GetNome());
        }

        [TestMethod]
        public void TestaVendedor()
        {
            string nome = "Tiago";
            double vendas = 10000;

            Vendedor p = new Vendedor(nome, vendas);

            Assert.AreEqual(0.2 * vendas + 2000, p.CalculaSalario());
            Assert.AreEqual(nome, p.GetNome());
        }

        [TestMethod]
        public void TestaFolha()
        {
            Funcionario f1 = new ProgramadorJunior("P1", 100);
            Funcionario f2 = new ProgramadorPleno("P2", 100);
            Funcionario f3 = new Gerente("G", 100, 1000);

            List<Funcionario> lista = new List<Funcionario>();
            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);

            Folha folha = new Folha(lista);

            Assert.AreEqual(30*100 + 45*100 + 100*100+1000, folha.GetTotal());
        }
    }
}
