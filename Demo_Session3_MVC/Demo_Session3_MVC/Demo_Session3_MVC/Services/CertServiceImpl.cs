using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public class CertServiceImpl : CertService
    {
        private List<Cert> certs;

        public CertServiceImpl()
        {
            certs = new List<Cert>
            {
                new Cert{ Id = "c1", Name = "Cert 1" },
                new Cert{ Id = "c2", Name = "Cert 2" },
                new Cert{ Id = "c3", Name = "Cert 3" },
                new Cert{ Id = "c4", Name = "Cert 4" },
                new Cert{ Id = "c5", Name = "Cert 5" }
            };
        }

        public List<Cert> findAll()
        {
            return certs;
        }
    }
}
