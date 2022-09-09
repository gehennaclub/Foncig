using System.Collections.Generic;

namespace Foncig.Core
{
    public class Core
    {
        private char separator = ':';
        private Dictionnary<string, object> configuration { get; set; }

        public void Load(string[] lines)
        {
            string[] splitted = null;

            Init();

            foreach (string line in lines)
            {
                if (line.Contains(separator) == true)
                {
                    splitted = line.Split(separator);
                    configuration.Add(splitted[0], splitted[1]);
                }
            }
        }

        public T Get(string id)
        {
            return ((T)configuration[id]);
        }

        private void Init()
        {
            if (configuration == null)
                configuration = new configuration();
            else
                configuration.Clear();
        }
    }
}
