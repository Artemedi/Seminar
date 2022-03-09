// Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным

Console.WriteLine("Print number (1-7)");
var b = Console.ReadLine();
if (b == "6" | b == "7") {
  Console.WriteLine("weekend");
}
if (b != "6" & b != "7") {
  Console.WriteLine("not a weeknd");
}
