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
        private readonly IPathService _pathService;

        public HomeModel(IConfiguration configuration, IPathService pathService)
        {
            _dataProvider = new DataProvider();
            _configuration = configuration;
            _pathService = pathService;
        }

        public void LoadData()
        {
            var prefix = _pathService.UserPictureFolder;
            UserPicture = $"{prefix}{_dataProvider.GetUserPicture(1)}";
        }
    }
}
