﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class SkillBar : IEntity
    {

        public int Id
        {
            get;
            set;
        }
        public virtual Skill[] Skills
        {
            get;
            set;
        }
    }
}