using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    //public class DatabaseSaverClient
    //{
    //    public void Main(bool b)
    //    {
    //        var databaseSaver = new DatabaseSaver();
    //        DoSmth(databaseSaver);
    //    }

    //    private void DoSmth(IDatabaseSaver saver)
    //    {
    //        saver.SaveData(null);
    //    }
    //}

    //���������
    public class DatabaseSaverClient
    {
        public void Main(bool b)
        {
            IDatabaseSaver databaseSaver = new DatabaseSaver();

            var sender = new MailSender();
            databaseSaver = new MailSenderDecorator(databaseSaver, sender, "");
            databaseSaver = new CacheUpdaterDecorator(databaseSaver, new CacheUpdater());

            DoSmth(databaseSaver);
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}