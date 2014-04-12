using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{

    public interface ICommand
    {
        string Key { get; }
        void Execute(string[] arguments );
    }

    public class SampeCommand:ICommand
    {
        public string Key { get { return "nop"; } }
        public void Execute(string[] arguments)
        {
            Console.WriteLine("Ничего сделано");
        }
    }

    class Program
    {
        static void Main()
        {
            var dispatcher = new Dictionary<string, ICommand>();
            dispatcher["nop"] = new SampeCommand();


            var commands = new Dictionary<string, Action<string[]>>(StringComparer.CurrentCultureIgnoreCase);
            
            var phoneBook = new Dictionary<string, string>(); 

            commands["добавить"] = delegate(string[] args)
                                       {
                                           phoneBook[args[1]] = args[2];
                                       };
            commands["выход"] = delegate(string[] args)
                                    {
                                        Environment.Exit(0);
                                    };
            commands["имя"] = delegate(string[] args)
                                  {
                                      var name = args[1];
                                      string phone;
                                      if (phoneBook.TryGetValue(name, out phone))
                                      {
                                          Console.WriteLine("Имя {0} телефон {1}",name,phone);
                                      }
                                      else
                                      {
                                          Console.WriteLine("Имя {0} в справочникуе не найдено",name);
                                      }
                                  };

            commands["печать"]=delegate(string[] strings)
                                   {
                                       foreach (var kvp in phoneBook)
                                       {
                                           Console.WriteLine("Имя {0} телефон {1}", kvp.Key, kvp.Value);
                                       }
                                   };
            commands["номер"] = delegate(string[] strings)
                                      {
                                          foreach (var kvp in phoneBook)
                                          {
                                              if (kvp.Value == strings[1])
                                              Console.WriteLine("Имя {0} телефон {1}", kvp.Key, kvp.Value);
                                          }
                                      };

            while (true)
            {
                var line = ReadCommand();
                var strings = line.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
                Action<string[]> commandHandler;
                if (commands.TryGetValue(strings[0], out commandHandler))
                {
                    commandHandler(strings);
                }
                else
                {
                    Console.WriteLine("Команда не найдена");
                }
            }
        }

        private static string ReadCommand()
        {
            Console.WriteLine("Введите команду");
            var line = Console.ReadLine();
            return line;
        }
    }
}
