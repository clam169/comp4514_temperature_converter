// See https://aka.ms/new-console-template for more information
using Temperature;

Conversion c = new Conversion();

double t;
double result;

// Celsius_to_Fahrenheit
t = 0d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, t);
Console.WriteLine($"{t} celcius is {result} fahrenheit");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, t);
Console.WriteLine($"{t} celcius is {result} fahrenheit");

//Kelvin_to_Fahrenheit
t = 0d;
result = c.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, t);
Console.WriteLine($"{t} kelvin is {result} fahrenheit");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, t);
Console.WriteLine($"{t} kelvin is {result} fahrenheit");

//Fahrenheit_to_Celcius
t = 32d;
result = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, t);
Console.WriteLine($"{t} fahrenheit is {result} celcius");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, t);
Console.WriteLine($"{t} fahrenheit is {result} celcius");

// Celsius_to_Kelvin
t = 0d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, t);
Console.WriteLine($"{t} celcius is {result} kelvin");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, t);
Console.WriteLine($"{t} celcius is {result} kelvin");

//Kelvin_to_Fahrenheit
t = 0d;
result = c.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, t);
Console.WriteLine($"{t} kelvin is {result} celcius");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, t);
Console.WriteLine($"{t} kelvin is {result} celcius");

//Fahrenheit_to_Kelvin
t = 0d;
result = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, t);
Console.WriteLine($"{t} fahrenheit is {result} kelvin");

t = 100d;
result = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, t);
Console.WriteLine($"{t} fahrenheit is {result} kelvin");