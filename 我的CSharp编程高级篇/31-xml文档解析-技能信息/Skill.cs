﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_xml文档解析_技能信息
{
    class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public int TriggerType { get; set; }
        public string ImageFile { get; set; }
        public int AvailableRace { get; set; }
        public override string ToString()
        {
            return string.Format("Id:{0},Name:{1},EngName:{2},TriggerType:{3},ImageFile:{4},AvailableRace:{5}", Id, Name, EngName, TriggerType, ImageFile,
                AvailableRace);
        }
    }
}
