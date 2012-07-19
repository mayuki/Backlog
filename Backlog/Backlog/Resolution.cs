using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// 完了理由を表すクラスです。
    /// </summary>
    public class Resolution
    {
        /// <summary>
        /// 完了理由ID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// 完了理由
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }
    }
}
