using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SmartPhone
    {
        private string model;
        private double freqencyCPU;
        private int RAM;
        private int HDD;
        private string typeOperSys;
        public SmartPhone(string model, double freqencyCPU, int RAM, int HDD, string typeOperSys) 
        {
            this.model = model;
            this.freqencyCPU = freqencyCPU;
            this.RAM = RAM;
            this.HDD = HDD;
            this.typeOperSys = typeOperSys;
        }
        public void Info()
        {
            Console.WriteLine($"Модель: {model}, Частота процессора: {freqencyCPU}, Объем оперативнй памяти: {RAM}, Объём жесткого диска: {HDD}, Тип операционной системы: {typeOperSys}");
        }
    }
}
