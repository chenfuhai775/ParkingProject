using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Core.Model
{
    public class UserInfo
    {
        private string _id;
        private string _orgId;
        private string _userAccount;
        private string _userName;
        private string _pwd;
        private int _userType;
        private int _status;
        private string _mobile;
        private string _email;
        private string _addr;
        private string _userLogo;
        private string _remark;
        private string _createUserIds;
        private string _createBy;
        private string _createTime;
        private string _lastUpdateBy;
        private string _lastUpdateTime;
        private string _userRoleIds;
        private string _systemRoleUserList;

        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string orgId
        {
            set { _orgId = value; }
            get { return _orgId; }
        }
        public string userAccount
        {
            set { _userAccount = value; }
            get { return _userAccount; }
        }
        public string userName
        {
            set { _userName = value; }
            get { return _userName; }
        }
        public string pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
        }
        public int userType
        {
            set { _userType = value; }
            get { return _userType; }
        }
        public int status
        {
            set { _status = value; }
            get { return _status; }
        }
        public string mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        public string addr
        {
            set { _addr = value; }
            get { return _addr; }
        }
        public string userLogo
        {
            set { _userLogo = value; }
            get { return _userLogo; }
        }
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        public string createUserIds
        {
            set { _createUserIds = value; }
            get { return _createUserIds; }
        }
        public string createBy
        {
            set { _createBy = value; }
            get { return _createBy; }
        }
        public string createTime
        {
            set { _createTime = value; }
            get { return _createTime; }
        }
        public string lastUpdateBy
        {
            set { _lastUpdateBy = value; }
            get { return _lastUpdateBy; }
        }
        public string lastUpdateTime
        {
            set { _lastUpdateTime = value; }
            get { return _lastUpdateTime; }
        }

        public string userRoleIds
        {
            set { _userRoleIds = value; }
            get { return _userRoleIds; }
        }
        public string systemRoleUserList
        {
            set { _systemRoleUserList = value; }
            get { return _systemRoleUserList; }
        }
    }
}