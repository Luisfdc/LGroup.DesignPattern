using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS.JeitoCerto
{
    public class FileStore
    {
        //Paravitar que allgum usuario modifique essa propriedade iremos bloquear o set
        //Somente poderemos modificar-la via construtor
        public string WorkingDirectory { get; private set; }

        public FileStore(string workingDirectory)
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

        public string GetPath(int id)
        {
            return Path.Combine(this.WorkingDirectory, id + ".txt");
        }

        public string Read(int id)
        {
            var path = GetPath(id);
            //Caso não exista o caminho podemos fazer retornar vazio, para evir de lançar uma exeção
            if (File.Exists(path))
                return File.ReadAllText(path);

            return string.Empty;
        }

    }
    
}
