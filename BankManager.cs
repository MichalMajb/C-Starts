// Bank manager, run all operation of administrate of bank


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class CustomerData
    {
        public string FirstName { get;}
        public string LasttName { get; }
        public long Pesel { get; }

        public CustomerData(string firstName, string lastName, string pesel)
        {
            FirstName = firstName;
            LasttName = lastName;
            Pesel = long.Parse(pesel);
        }

    }



    class BankManager
    {
        private AccountMenager _accountMenager;
        private IPrinter _printer;

        public BankManager()                                        //Constructor, build objects
        {
            _accountMenager = new AccountMenager();
            _printer = new Printer();
        }

        private void PrintMainMenu()                                //List of action
        {
            Console.Clear();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - Lista kont klienta");
            Console.WriteLine("2 - Dodaj konto rozliczeniowe");
            Console.WriteLine("3 - Dodaj konto oszczędnościowe");
            Console.WriteLine("4 - Wpłać/wypłać pieniądze na/z konto/a");
            Console.WriteLine("5 - Lista klientów");
            Console.WriteLine("6 - Wszystkie konta");
            Console.WriteLine("7 - Zakończ miesiąc");
            Console.WriteLine("0 - Zakończ");
        }



        private int SelectedAction()                    //Seclect Actions
        {
            Console.Write("Akcja: ");
            string action = Console.ReadLine();
            if (string.IsNullOrEmpty(action))
            {
                return -1;
            }
            return int.Parse(action);
        }

        public void Run()                   //Loop of Runtime program and selector of actions
        {
            int action;
            do
            {
                PrintMainMenu();
                action = SelectedAction();

                switch (action)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę kont klienta");
                        ListOfAccount();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Wybrano otwarcie konta rozliczeniowego");
                        AddBillingAccount();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Wybrano otwarcie konta oszczędnościowego");
                        AddSavingAccount();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Wybrano wpłatę/wypłatę pieniędzy na konto");
                        ChangeMoney();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę klientów");
                        ListOfConsumers();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę wszystkich kont");
                        ListOfAllAccount();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Wybrano zamknięcie miesiąca");
                        CloseMonth();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            while (action != 0);
        }
        private void ListOfAccount()                //Using object to get a List of Account
        {
            Console.Clear();
            CustomerData data = ReadCustomerData();

        }

        private CustomerData ReadCustomerData()                     //Read basic information about customer
        {
            string firstName;
            string lastName;
            string pesel;
            Console.WriteLine("Podaj dane klienta:");
            Console.Write("Imię:");
            firstName = Console.ReadLine();
            Console.Write("Nazwisko:");
            lastName = Console.ReadLine();
            Console.Write("PESEL:");
            pesel = Console.ReadLine();

            return new CustomerData(firstName, lastName, pesel);
        }

        private void AddBillingAccount()                        
        {
            Console.Clear();
            CustomerData data = ReadCustomerData();
            Account bilingAccount = _accountMenager.CreateBillingAccount(data.FirstName, data.LasttName, data.Pesel);

            Console.WriteLine("Utworzono konto rozliczeniowe:");
            _printer.Print(bilingAccount);
            Console.ReadKey();
        }
        private void AddSavingAccount()
        {
            Console.Clear();
            CustomerData data = ReadCustomerData();
            Account savingAccount = _accountMenager.CreateSavingsAccount(data.FirstName, data.LasttName, data.Pesel);

            Console.WriteLine("Utworzono konto oszczędnościowe:");
            _printer.Print(savingAccount);
            Console.ReadKey();
        }
        private void ChangeMoney()
        {
            ChengerMoney chenger = new ChengerMoney();
            chenger.ChangeMoney();
        }
        private void ListOfConsumers()
        {
            Console.Clear();
            Console.WriteLine("Lista klientów:");
            foreach (string customer in _accountMenager.ListOfCustomers())
            {
                Console.WriteLine(customer);
            }
            Console.ReadKey();
        }
        private void ListOfAllAccount()
        {
            Console.Clear();
            Console.WriteLine("Lista kont;");
            foreach (Account accounts in _accountMenager.GetAllAccounts())
            {
                Console.WriteLine(accounts);
            }
        }
        private void CloseMonth()
        {
            Console.Clear();
            _accountMenager.CloseMonth();
            Console.WriteLine("Miesiąc Zamknięty");
            Console.ReadKey();
        }

    }
}
