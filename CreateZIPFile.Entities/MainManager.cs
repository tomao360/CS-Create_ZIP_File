using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateZIPFile.Entities
{
    public class MainManager
    {
        private MainManager()
        {
            Init();
        }

        private static readonly MainManager _instance = new MainManager();
        public static MainManager Instance { get { return _instance; } }

        public Items items;
        private void Init()
        {
            items = new Items();
            items.CreateAnItem();
        }
    }
}
