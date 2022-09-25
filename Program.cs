//визначення співробітника
Employee employee = new Employee();
employee.Name = "Vitalina";
employee.Surname = "Boyko";
Console.WriteLine($"Ім'я та прізвище співробітника: {employee.Name} {employee.Surname}");
string profession = "";
Console.WriteLine("Посада: " + profession);

//податок
double tax = 0.18;

//ставка
Console.Write("Вкажіть ставку: ");
double rate = Convert.ToDouble(Console.ReadLine());

//години
Console.Write("Вкажіть відпрацьовані години: ");
double hours = Convert.ToDouble(Console.ReadLine());

//посада
Console.Write("Вкажіть посаду, використовуючи код (1 - «перші» керівники; 2 - заступники керівників; 3 - інші посади): ");
string? code = Console.ReadLine();
double additive;
#region Position
        if (code == "1")
        {
            additive = 10000;
        }
        else if (code == "2")
        {
            additive = 5000;
        }
        else if (code == "3")
        {
            additive = 0;
        }
        else
        {
            Console.WriteLine("Такого коду не існує.");
            return;
        }
        #endregion 

//стаж
Console.Write("Вкажіть стаж роботи (заокруглено в роках): ");
int years = Convert.ToInt32(Console.ReadLine());

double salary;
double tax_from_salary;

//розрахунок заробітної плати
void Salary()
    {
        //розрахунок зарплати
        if (years>0 && years <3)
        {
            salary = (rate*hours) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else if (years >=3 && years < 5)
        {
            salary = (rate*hours*0.1) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else if (years >=5 && years < 10)
        {
            salary = (rate*hours*0.15) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else if (years >=10 && years < 15)
        {
            salary = (rate*hours*0.2) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else if (years >=15 && years < 20)
        {
            salary = (rate*hours*0.25) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else if (years >=20 && years < 25)
        {
            salary = (rate*hours*0.3) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else if (years >=25)
        {
            salary = (rate*hours*0.4) - (rate*hours*tax) + additive;
            Console.WriteLine("Заробітна плата співробітника з вирахуванням податків: " + salary);
        }
        else
        {
            Console.WriteLine("Стаж від'ємним бути не може.");
            return;
        }

        tax_from_salary = salary*tax;
        Console.WriteLine("Податковий збір: " + tax_from_salary);
    }
    
//вивід заробітної плати
Salary();