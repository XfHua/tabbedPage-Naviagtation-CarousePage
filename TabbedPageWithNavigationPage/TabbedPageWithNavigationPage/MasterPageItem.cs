﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TabbedPageWithNavigationPage
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
