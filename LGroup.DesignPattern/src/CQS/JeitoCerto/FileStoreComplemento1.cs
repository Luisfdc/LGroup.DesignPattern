using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS.JeitoCerto
{
    public class FileStoreComplemento1
    {
        //Paravitar que allgum usuario modifique essa propriedade iremos bloquear o set
        //Somente poderemos modificar-la via construtor
        public string WorkingDirectory { get; private set; }

        public FileStoreComplemento1(string workingDirectory)
        {
            //Fazendo Validaçoes para evitar erros
            if (string.IsNullOrWhiteSpace(workingDirectory))
                throw new ArgumentNullException("Diretório Não informado");

            if (!Directory.Exists(workingDirectory))
                throw new ArgumentNullException("Diretório Não Existe");

            WorkingDirectory = workingDirectory;
        }
        public void Save(int id, string message)
        {
            var path = GetPath(id);
            File.WriteAllText(path, message);

        }

        private string GetPath(int id)
        {
            return Path.Combine(this.WorkingDirectory, id + ".txt");
        }

        public string Read(int id)
        {
            var path = GetPath(id);
            return File.ReadAllText(path);
        }

        public bool CanRead(int id)
        {
            var path = GetPath(id);
            return File.Exists(path);
        }

    }
}
