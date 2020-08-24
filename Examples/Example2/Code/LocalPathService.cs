using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Code
{
    public class LocalPathService : IPathService
    {
        public string UserPictureFolder { get; private set; }

        public LocalPathService(IConfiguration configuration)
        {
            UserPictureFolder = configuration.GetValue<string>("UserPictureFolder");
        }
    }
}
