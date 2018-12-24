﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Folder
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public Folder Parent { get; set; }

        public IEnumerable<Folder> Children { get; set; }
    }
}
