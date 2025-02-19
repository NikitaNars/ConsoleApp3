using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class laptop
    {
        private string model;
        private double freqencyCPU;
        private int RAM;
        private int HDD;
        private double mass;

        public laptop(string model, double freqencyCPU, int RAM, int HDD, double mass)
        {
            this.model = model;
            this.freqencyCPU = freqencyCPU;
            this.RAM = RAM;
            this.HDD = HDD;
            this.mass = mass;
        }
        public void Info()
        {
            Console.WriteLine($"Модель: {model}, Частота процессора: {freqencyCPU}, Объем оперативнй памяти: {RAM}, Объём жесткого диска: {HDD}, Масса: {mass}");
        }
    }
}
