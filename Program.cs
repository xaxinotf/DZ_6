using DZ_6;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

Console.OutputEncoding = System.Text.Encoding.Unicode;





const string Path = "./DodatokJSON.json";

var readFile = File.ReadAllText(Path);

var data = JsonSerializer.Deserialize<List<InformationInTxt>> (readFile);


foreach (var item in data)
{
    Console.WriteLine(item.Title);    
}

