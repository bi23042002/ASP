using Demo_Session3_MVC.Models;

namespace Demo_Session3_MVC.Services
{
    public class LanguageServiceImpl : LanguageService
    {
        private List<Language> languages;

        public LanguageServiceImpl()
        {
            languages = new List<Language>
            {
                new Language{ Id = "lang1", Name = "Language 1" },
                new Language{ Id = "lang2", Name = "Language 2" },
                new Language{ Id = "lang3", Name = "Language 3" },
                new Language{ Id = "lang4", Name = "Language 4" },
                new Language{ Id = "lang5", Name = "Language 5" }
            };
        }

        public List<Language> findAll()
        {
            return languages;
        }
    }
}
