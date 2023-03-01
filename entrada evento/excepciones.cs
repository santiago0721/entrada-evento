using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrada_evento
{
    class No_se_encuentra_archivo: Exception
    {
        public No_se_encuentra_archivo() : base() { }

    }
    class no_existe_tipo_de_archivo : Exception
    {
        public no_existe_tipo_de_archivo() : base() { }

    }
}
