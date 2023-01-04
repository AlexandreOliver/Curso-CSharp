using Composicao.Entities;
using Composicao.Entities.Enums;


Console.Write("Enter department's name: ");
Department department = new Department(Console.ReadLine());

Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string nome = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double salario = double.Parse(Console.ReadLine());

Worker funcionario = new Worker(nome, level, salario);

Console.Write("How many contracts to this worker? ");
int controle = int.Parse(Console.ReadLine());


for (int i = 1; i <= controle; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    HourContract contrato = new HourContract();
    funcionario.addContract(contrato);
}

Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
string[] mesSalario = Console.ReadLine().Split("/");
    int month = int.Parse(mesSalario[0]);
    int year = int.Parse(mesSalario[1]);

Console.WriteLine($"Name: {funcionario.name}");
Console.WriteLine($"Department: {department.name}");
Console.WriteLine($"Income for {month}/{year}: " + funcionario.income(year, month).ToString("F2"));
