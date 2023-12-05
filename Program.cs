var items = new List<string>();
bool shallExit = false;
Console.WriteLine("Olá, Seja Bem-Vindo sua lista do que fazer");

while (!shallExit)
{
Console.WriteLine("");        
Console.WriteLine("Segue abaixo suas opções:");
Console.WriteLine("[V]eer toda a lista");
Console.WriteLine("[A]adicionar um novo item");
Console.WriteLine(("[R] remover um item"));
Console.WriteLine("[S]air");


var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "S":
    case "s":
        shallExit = true; break;
    case "v":
    case "V":
            SeeAllItems();
            break;
    case "a":
    case "A":
            AddItem();
            break;
        case "r":
            case "R":
            RemoveItem();
            break;
        default :
            Console.WriteLine("Opção inválida");
            break;
}
}


void AddItem()
{
    bool isValidChoice = false;
    while (!isValidChoice) { 
    Console.WriteLine("Entre com a descrição do novo item da lista:");
    var description = Console.ReadLine();

    if(description == "")
    {
        Console.WriteLine("a descrição não pode ser vazia");
    }
    else if (items.Contains(description))
    {
        Console.WriteLine("Esse item já existir");
    }
    else
    {
        isValidChoice = true;
        items.Add(description);
    }
    }
}


void SeeAllItems()
{
    if(items.Count == 0)
    {
        Console.WriteLine("Não há items");
    }
    else
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }
}

void RemoveItem()
{
    if (items.Count == 0)
    {
        Console.WriteLine("Não há items a ser removidos");
        return;
    }
    bool isValidIndex = false;
    while (!isValidIndex)
    {
        Console.WriteLine("Escolha o item que desejar remover:");
        SeeAllItems();
        var userChoice = Console.ReadLine();
      
        if (int.TryParse(userChoice, out int index) && index >= 1 && index <= items.Count)
        {
            var indexChoice = index - 1;
            Console.WriteLine("O item removido foi: " + items[indexChoice]);
            items.RemoveAt(indexChoice);
            isValidIndex = true;
        }
        else { Console.WriteLine("Opção Inválida"); }
    }  
  
}