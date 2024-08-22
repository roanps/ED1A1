using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class TipoEnumerador
    {
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class TipoEnumerador
    {
        public enum Language{
            PT-BR, EN, RU
        }   

        public Language _language =  Language.PTBR;

        public Language GetLanguageEnum(string lang)
        {
            switch(lang.ToLower())
            {
                case "português" :
                    return Language.PTBR;
                case "inglês" : 
                    return Language.EN;
                case "russo" :
                    return Language.RU;
                default :
                    return Language.PTBR;
            }
        }
    }
}
    }
}