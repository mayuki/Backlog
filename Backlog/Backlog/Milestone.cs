using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// マイルストーンを表すクラスです。
    /// </summary>
    public class Milestone
    {
        /// <summary>
        /// マイルストーンID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// マイルストーン名
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }

        /// <summary>
        /// リリース予定日
        /// </summary>
        [XmlRpcMember("date")]
        public String DateString { get { return (Date != null) ? Date.Value.ToString("yyyyMMdd") : String.Empty; } set { Date = String.IsNullOrWhiteSpace(value) ? null : (DateTime?)DateTime.ParseExact(value, "yyyyMMdd", null); } }
        /// <summary>
        /// リリース予定日
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime? Date { get; set; }
    }
}
