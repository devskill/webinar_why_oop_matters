using Example2.Code;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example2.Models
{
    public class HomeModel
    {
        public string UserPicture { get; set; }
        private readonly DataProvider _dataProvider;
        private readonly IConfiguration _configuration;

        public HomeModel(IConfiguration configuration)
        {
            _dataProvider = new DataProvider();
            _configuration = configuration;
        }

        public void LoadData()
        {
            UserPicture = _dataProvider.GetUserPicture(1);
        }
    }
}
