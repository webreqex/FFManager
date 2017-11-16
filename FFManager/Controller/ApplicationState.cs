using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Controller
{
    public enum ApplicationState
    {
        /// <summary>
        /// ログイン画面を表示し，ログインするアカウントを選択します．
        /// </summary>
        ChoiceLoginAccount,

        /// <summary>
        /// すべての関連アカウントのリストを表示します．
        /// </summary>
        ShowAllAccountsList,

        /// <summary>
        /// 現在のユーザーがフォローしているアカウントのリストを表示します．
        /// </summary>
        ShowAccountsListYouFollowing,

        /// <summary>
        /// 現在のユーザーをフォローしているアカウントのリストを表示します．
        /// </summary>
        AccountsYourFollowerList,

        /// <summary>
        /// 保護されたアカウントのリストを表示します．
        /// </summary>
        ProtectedAccountsList,
    }
}
