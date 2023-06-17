using System.Globalization;
using OrientacaoObjeto;
using System;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre Com o valoro do lado xA:", CultureInfo.InvariantCulture);
x.A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre Com o valoro do lado xB:", CultureInfo.InvariantCulture);
x.B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre Com o valoro do lado xC:", CultureInfo.InvariantCulture);
x.C = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre Com o valor do lado yA:", CultureInfo.InvariantCulture);
y.A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre Com o valoro do lado yB:", CultureInfo.InvariantCulture);
y.B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre Com o valoro do lado yC:", CultureInfo.InvariantCulture);
y.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();


double areaY = y.Area();
Console.WriteLine("Area do triaglo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

Console.WriteLine("Area do triaglo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
if(areaX > areaY){
    System.Console.WriteLine("A maiora area de X");
}
else{
    System.Console.WriteLine("A maior area é Y");
}