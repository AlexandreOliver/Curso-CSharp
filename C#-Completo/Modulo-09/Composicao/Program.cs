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

Worker funcionario = new Worker(nome, level, salario, department);

Console.Write("\nHow many contracts to this worker? ");
int controle = int.Parse(Console.ReadLine());


for (int i = 1; i <= controle; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    HourContract contrato = new HourContract(); 

    Console.Write("Date (DD/MM/YYYY): ");    
    contrato.setDate(DateTime.Parse(Console.ReadLine()));
    
    Console.Write("Value per Hour: ");
    contrato.setValuePerHour(Double.Parse(Console.ReadLine()));
    
    Console.Write("Duration: ");
    contrato.setHours(int.Parse(Console.ReadLine()));
    
    funcionario.addContract(contrato);
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
string mesSalario = Console.ReadLine();
    int month = int.Parse(mesSalario.Substring(0, 2));
    int year = int.Parse(mesSalario.Substring(3));

Console.WriteLine($"Name: {funcionario.name}");
Console.WriteLine($"Department: {funcionario.department.name}");
Console.WriteLine($"Income for {mesSalario}: " + funcionario.income(year, month).ToString("F2"));
