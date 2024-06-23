using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Repositories
{
    public abstract class BaseRepository
    {
        protected string connectionString =
            "Server = localhost,1433; Database=energia;User ID = sa; Password=;trustservercertificate=true;";
    }
}
