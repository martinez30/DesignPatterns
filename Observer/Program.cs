using Observer;
using Observer.Entities;
using Observer.Interfaces;

Newsletters newsletters = new Newsletters();

IObserver funcionario = new Funcionario("Funcionário 1", "funcionar@gmail.com", newsletters);
IObserver funcionario2 = new Funcionario("Funcionário 2", "funcionar2@gmail.com", newsletters);

IObserver cliente = new Client("Client 1", "client@gmail.com", newsletters);

IObserver parceiro = new Parceiro("Parceiro 1", "parceiro@gmail.com", newsletters);

IObserver fornecedor1 = new Fornecedor("Fornecedor 1", "fornecedor1@gmail.com", newsletters);
IObserver fornecedor2 = new Fornecedor("Fornecedor 2", "fornecedor2@gmail.com", newsletters);

newsletters.addMessage("Primeira mensagem");
Console.WriteLine("#####################");
newsletters.removeObserver(cliente);
newsletters.addMessage("Segunda mensagem");
Console.WriteLine("#####################");
newsletters.removeObserver(parceiro);
newsletters.registerObserver(cliente);
newsletters.addMessage("Terceira mensagem");