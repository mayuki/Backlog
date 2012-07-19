using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// カスタム属性を表すクラスです。
    /// </summary>
    public class CustomField
    {
        /// <summary>
        /// カスタム属性ID
        /// </summary>
        [XmlRpcMember("id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// カスタム属性名
        /// </summary>
        [XmlRpcMember("name")]
        public String Name { get; set; }

        /// <summary>
        /// カスタム属性形式
        /// </summary>
        [XmlRpcMember("type_id")]
        public Int32 TypeIdInt32 { get { return (Int32)TypeId; } set { TypeId = (CustomFieldType)value; } }

        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public CustomFieldType TypeId { get; set; }

        /// <summary>
        /// カスタム属性説明
        /// </summary>
        [XmlRpcMember("description")]
        public String Description { get; set; }

        /// <summary>
        /// 必須属性項目
        /// </summary>
        [XmlRpcMember("required")]
        public Boolean Required { get; set; }

        /// <summary>
        /// カスタム属性値
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("value")]
        public String Value { get; set; }

        /// <summary>
        /// 選択項目値
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("values")]
        public CustomFieldValue[] Values { get; set; }


        /// <summary>
        /// その他入力可能状態(チェックボックス、ラジオ時のみ, カスタム属性形式が上記以外の場合)
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("allow_input")]
        public Boolean? AllowInput { get; set; }

        /// <summary>
        /// その他項目で入力した値(カスタム属性形式が上記以外の場合)
        /// </summary>
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        [XmlRpcMember("other_text")]
        public String OtherText { get; set; }

        public class CustomFieldValue
        {
            /// <summary>
            /// ID
            /// </summary>
            [XmlRpcMember("id")]
            public Int32 Id { get; set; }

            /// <summary>
            /// 名前
            /// </summary>
            [XmlRpcMember("name")]
            public String Name { get; set; }
        }
    }


    /// <summary>
    /// カスタム属性の形式
    /// </summary>
    public enum CustomFieldType
    {
        /// <summary>
        /// 文字列
        /// </summary>
        String = 1,
        /// <summary>
        /// 文章
        /// </summary>
        Text = 2,
        /// <summary>
        /// 数値
        /// </summary>
        Number = 3,
        /// <summary>
        /// 日付
        /// </summary>
        Date = 4,
        /// <summary>
        /// 単一リスト
        /// </summary>
        SingleList = 5,
        /// <summary>
        /// 複数リスト
        /// </summary>
        MultipleList = 6,
        /// <summary>
        /// チェックボックス
        /// </summary>
        Checkbox = 7,
        /// <summary>
        /// ラジオ
        /// </summary>
        Radio = 8
    }
}
