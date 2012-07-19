using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace ConsoleApplication1.Backlog
{
    /// <summary>
    /// BacklogのAPIのプロクシを提供します。
    /// </summary>
    public static class Backlog
    {
        /// <summary>
        /// BacklogのAPIのプロクシを生成します。
        /// </summary>
        /// <param name="spaceUrl">スペースURL(https://[space-id].backlog.jp/XML-RPC)</param>
        /// <param name="userName">ログイン名</param>
        /// <param name="password">パスワード</param>
        /// <returns></returns>
        public static IBacklog Create(String spaceUrl, String userName, String password)
        {
            var backlogInstance = XmlRpcProxyGen.Create<IBacklog>();
            backlogInstance.Url = spaceUrl;
            backlogInstance.Credentials = new NetworkCredential(userName, password);

            return backlogInstance;
        }
    }

    /// <summary>
    /// BacklogのAPIのインターフェース
    /// </summary>
    public interface IBacklog : IXmlRpcProxy
    {
        /// <summary>
        /// 参加プロジェクトを配列で返します。
        /// </summary>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getProjects")]
        Project[] GetProjects();

        /// <summary>
        /// プロジェクトキーを指定して、プロジェクトを取得します。
        /// </summary>
        /// <param name="projectKey">プロジェクトキー</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getProject")]
        Project GetProject(String projectKey);

        /// <summary>
        /// プロジェクトIDを指定して、プロジェクトを取得します。
        /// </summary>
        /// <param name="projectId">プロジェクトID</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getProject")]
        Project GetProject(Int32 projectId);

        //backlog.getComponents
        //backlog.getVersions
        //backlog.getUsers
        //backlog.getIssueTypes
        /// <summary>
        /// 課題キーを指定して、課題を取得します。
        /// </summary>
        /// <param name="issueKey">課題キー</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getIssue")]
        Issue GetIssue(String issueKey);
        /// <summary>
        /// 課題キーを指定して、課題を取得します。
        /// </summary>
        /// <param name="issueKey">課題キー</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getIssue")]
        XmlRpcStruct GetIssueAsRaw(String issueKey);
        /// <summary>
        /// 課題IDを指定して、課題を取得します。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getIssue")]
        Issue GetIssue(Int32 issueId);
        /// <summary>
        /// 課題のコメントを返します。
        /// </summary>
        /// <param name="issueId">課題ID</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getComments")]
        Comment[] GetComments(Int32 issueId);
        //backlog.countIssue
        /// <summary>
        /// 指定した条件に該当する課題を返します。
        /// </summary>
        /// <param name="projectId">プロジェクトID</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.findIssue")]
        Issue[] FindIssue(Int32 projectId);
        /// <summary>
        /// 指定した条件に該当する課題を返します。
        /// </summary>
        /// <param name="projectId">プロジェクトID</param>
        /// <param name="findIssueParameter">検索するパラメータ</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.findIssue")]
        Issue[] FindIssue(FindIssueParameter findIssueParameter);
        //backlog.createIssue
        //backlog.updateIssue
        //backlog.switchStatus
        //backlog.addComment
        //backlog.addIssueType
        //backlog.updateIssueType
        //backlog.deleteIssueType
        //backlog.addVersion
        //backlog.updateVersion
        //backlog.deleteVersion
        //backlog.addComponent
        //backlog.updateComponent
        //backlog.deleteComponent
        //backlog.getTimeline
        //backlog.getProjectSummary
        //backlog.getProjectSummaries
        /// <summary>
        /// ユーザID(数値またはログインID)を指定して、ユーザを取得します。 
        /// </summary>
        /// <param name="id">ユーザIDまたはログインID</param>
        /// <returns></returns>
        [XmlRpcMethod("backlog.getUser")]
        User GetUser(String id);

        //backlog.getUserIcon
        //backlog.getActivityTypes
        //backlog.getStatuses
        //backlog.getResolutions
        //backlog.getPriorities
        //backlog.getCustomFields
        //backlog.admin.getUsers
        //backlog.admin.addUser
        //backlog.admin.updateUser
        //backlog.admin.deleteUser
        //backlog.admin.getProjects
        //backlog.admin.addProject
        //backlog.admin.updateProject
        //backlog.admin.deleteProject
        //backlog.admin.getProjectUsers
        //backlog.admin.addProjectUser
        //backlog.admin.updateProjectUsers
        //backlog.admin.deleteProjectUser
        //backlog.admin.addCustomField
        //backlog.admin.updateCustomField
        //backlog.admin.deleteCustomField

    }
}
