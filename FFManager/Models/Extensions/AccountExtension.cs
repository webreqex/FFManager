using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FFManager.Models.Extensions
{
    using self = AccountExtension;

    /// <summary>
    /// IAccountに対する拡張メソッドを提供します。
    /// </summary>
    public static class AccountExtension
    {
        // 非公開静的フィールド


        // 静的メソッド

        /// <summary>
        /// AccountExtension クラスを初期化します。
        /// </summary>
        static AccountExtension()
        {
        }


        // 非公開静的メソッド

        
        // 公開静的メソッド

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="stream"></param>
        public static void SaveTo(this IAccount target, Stream stream)
        {
            NetDataContractSerializer serializer = new NetDataContractSerializer();
            serializer.Serialize(stream, target);
        }
    }
}
