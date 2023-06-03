// Here we use dynamic to parse and execute Python code
using IronPython.Hosting;

var pythonAsText = """
class Calculator:
  def __init__(self):
      pass
  def add(self, x, y):
      return (x+y)
""";

// configure Python translator
var engine = Python.CreateEngine();
var scope = engine.CreateScope();

// make code available in your C# app
engine.Execute(pythonAsText, scope);

var calcType = scope.GetVariable("Calculator");

// Instance of Python Calculator class in C#
dynamic calculator = engine.Operations.CreateInstance(calcType);

// Make calculations
var result = calculator.add(6,7);
Console.WriteLine(result);