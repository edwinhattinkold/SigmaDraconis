﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisData
{
    public class Forum : IEntity
    {

        public virtual IList<Topic> Topics
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public virtual Category Category
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }
        public int Hidden
        {
            get;
            set;
        }
    }
}