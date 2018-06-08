using Patterns.Ex00.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex00
{
    class FtpClientAdapter : LogImporter
    {
        private readonly FtpClient ftpClient;

        public FtpClientAdapter(ILogReader reader, FtpClient ftpClient) 
            : base(reader)
        {
            this.ftpClient = ftpClient;
        }

        public void ImportLogs(string login, string password, string filePath)
        {
            var file = ftpClient.ReadFile(login, password, filePath);
        }
    }
}
