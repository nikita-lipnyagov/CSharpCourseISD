using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{


    class DocumentWorker {
        public virtual void OpenDocument() {
            Console.Write("Документ открыт");
        } 
        public virtual void EditDocument() {
            Console.Write("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument() {
            Console.Write("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker {
        public override void EditDocument() {
            Console.Write("Документ отредактирован");
        }
        public override void SaveDocument() {
            Console.Write("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker {
        public override void SaveDocument() {
            Console.Write("Документ сохранен в новом формате");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Введите ключ");
            s = Console.ReadLine();
            if(s!=null) {
                DocumentWorker obj = new ProDocumentWorker();
            }
        }
    }
}
