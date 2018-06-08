using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_01
{
    class MailSenderDecorator : DatabaseSaverDecorator
    {
        private MailSender mailSender;
        private string email;

        public MailSenderDecorator(IDatabaseSaver saver, MailSender mailSender, string email) : base(saver)
        {
            this.mailSender = mailSender;
            this.email = email;
        }

        public new void SaveData(object data)
        {
            base.SaveData(data);
            this.mailSender.Send(email);
        }
    }
}
