using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// 優先度を表すクラスです。
    /// </summary>
    public class Priority
    {
        /// <summary>
        /// 優先度ID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// 優先度
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }
    }
}
