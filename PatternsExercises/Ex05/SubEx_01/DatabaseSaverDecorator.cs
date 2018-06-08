using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_01
{
    class DatabaseSaverDecorator : IDatabaseSaver
    {
        protected IDatabaseSaver saver;

        public DatabaseSaverDecorator(IDatabaseSaver saver)
        {
            this.saver = saver;
        }

        public void SaveData(object data)
        {
            this.saver.SaveData(data);
        }
    }
}
