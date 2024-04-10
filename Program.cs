#include <iostream>


using namespace std;

int main() {
  float alto, largo, precioM2, area, precioTotal;

  cout<<"Ingrese el alto del lote: ";
  cin>>alto;
  cout<<"Ingrese el largo del lote: ";
  cin>>largo;
  cout<<"Ingrese el precio por metro cuadrado: ";
  cin>>precioM2;

  area = alto * largo;
  precioTotal = area * precioM2;

  cout<<"El área del lote es: " << area << " metros cuadrados." << endl;
  cout<<"El precio total del lote es: $" << precioTotal << endl;

  return 0;
}
