﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weibo.Entity
{
    /// <summary>
    /// 标签实体
    /// </summary>
    public class IdValueEntity
    {
        /// <summary>
        /// tagId
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// tag名
        /// </summary>
        public string value { get; set; }
    }
}
