using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS.JeitoCerto
{
    class FileStoreComplemento4
    {
        //Paravitar que allgum usuario modifique essa propriedade iremos bloquear o set
        //Somente poderemos modificar-la via construtor
        public string WorkingDirectory { get; private set; }

        public FileStoreComplemento4(string workingDirectory)
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

        //Qual a vantagem de usar Lista?
        // Vantagem de que poderemos trabalharcom linq e expressões lambda
        public IEnumerable<string> Read(int id)
        {
            var path = GetPath(id);

            if (CanRead(id))
                return new Maybe<string>(File.ReadAllText(path));
            else
                return new Maybe<string>();

        }

        private bool CanRead(int id)
        {
            var path = GetPath(id);
            return File.Exists(path);
        }

    }

    public class Maybe<T> : IEnumerable<T>
    {
        private IEnumerable<T> values;
        public Maybe()
        {
            this.values = new T[0];
        }
        public Maybe(T value)
        {
            this.values = new[] { value };
        }
        public IEnumerator<T> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return values.GetEnumerator();
        }
    }
}
