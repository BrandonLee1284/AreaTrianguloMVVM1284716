using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaTrianguloMVVM1284716
{
    partial class Triangulo : ObservableObject
    {
        [ObservableProperty]
        public string lado1;

        [ObservableProperty]
        public string lado2;

        [ObservableProperty]
        public string lado3;

        [ObservableProperty]
        public string resultado;

        [RelayCommand]
        private void CalcularArea()
        {
            if (double.TryParse(lado1, out double a) &&
                double.TryParse(Lado2, out double b) &&
                double.TryParse(Lado3, out double c))
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Resultado = "Los lados tienen que ser mayores a cero";
                    return;
                }

                if (a + b > c && a + c > b && b + c > a)
                {
                    double s = (a + b + c) / 2;
                    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    Resultado = $"El Área del triángulo es: {area}";
                }
                else
                {
                    Resultado = "El Área que ha ingresado no forma un triángulo válido";
                }
            }
            else
            {
                Resultado = "Por favor ingresar lados válidos";
            }
        }
    }
}
