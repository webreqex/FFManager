using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFManager.Models;

namespace ModelTest
{
    using self = Entry;
    using Assembly = System.Reflection.Assembly;

    /// <summary>
    /// アプリケーションのメインエントリポイントを定義します。
    /// </summary>
    public static class Entry
    {
        // 非公開静的フィールド
        private static string AssemblyDir;

        
        // 静的コンストラクタ

        /// <summary>
        /// Entry クラスを初期化します。
        /// </summary>
        static Entry()
        {
            self.AssemblyDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }


        // 公開静的メソッド

        /// <summary>
        /// アプリケーションのメインエントリポイントです。
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

        }
    }
}
