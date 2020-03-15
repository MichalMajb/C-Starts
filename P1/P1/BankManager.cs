// Bank manager, run all operation of administrate of bank


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class BankManager
    {
        private AccountMenager _accountMenager;
        private readonly IPrinter _printer;
        private ChengerMoney _changer;

        public BankManager()                                        //Constructor, build objects
        {
            _accountMenager = new AccountMenager();
            _printer = new Printer();
            _changer = new ChengerMoney();
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
                        ListOfAccount.PrintListOfAccount("Wybrano listę kont klienta");
                        Console.ReadKey();
                        break;
                    case 2:
                        AddBillingAccount.AdderBilingAccount("Wybrano dodanie nowego konta rozliczeniowego");
                        Console.ReadKey();
                        break;
                    case 3:
                        AddSavingsAccount.AdderSavingsAccount("Wybrano dodanie nowego konta oszczędnościowego");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        _changer.ChangeMoney("Wybrano wpłatę/wypłatę pieniędzy na konto");
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
