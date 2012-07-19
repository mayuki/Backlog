using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// コメントを表すクラスです。
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// コメントID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// コメント内容
        /// </summary>
        [XmlRpcMember("content")]
        public String Content { get; set; }

        /// <summary>
        /// コメント登録者
        /// </summary>
        [XmlRpcMember("created_user")]
        public User CreatedUser { get; set; }

        /// <summary>
        /// 登録日時(文字列)
        /// </summary>
        [XmlRpcMember("created_on")]
        public String CreatedOnString { get { return CreatedOn.ToString("yyyyMMddHHmmss"); } set { CreatedOn = DateTime.ParseExact(value, "yyyyMMddHHmmss", null); } }
        /// <summary>
        /// 登録日時
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 最終更新日時(文字列)
        /// </summary>
        [XmlRpcMember("updated_on")]
        public String UpdatedOnString { get { return UpdatedOn.ToString("yyyyMMddHHmmss"); } set { UpdatedOn = DateTime.ParseExact(value, "yyyyMMddHHmmss", null); } }
        /// <summary>
        /// 最終更新日時
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public DateTime UpdatedOn { get; set; }
    }
}
