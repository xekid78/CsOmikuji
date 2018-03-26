# CsOmikuji
おみくじ（.NET Core）

## 処理
コンソールアプリとして画面にHelloWorldと表示

## コード
```
using System;

namespace omikuji
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new System.Random();
            var omikuji = rand.Next(1, 6);

            if (omikuji == 1)
            {
                Console.WriteLine("大吉");
            }
            else if (omikuji == 2)
            {
                Console.WriteLine("中吉");
            }
            else if (omikuji == 3)
            {
                Console.WriteLine("小吉");
            }
            else if (omikuji == 4)
            {
                Console.WriteLine("吉");
            }
            else if (omikuji == 5)
            {
                Console.WriteLine("凶");
            }
            else
            {
                Console.WriteLine("大凶");
            }

            // 実行結果確認のための処理 ここから
            Console.WriteLine();
            Console.WriteLine("何かキーを押してください");
            Console.ReadKey();
            // ここまで
        }
    }
}
```

## 出力結果  
```
中吉

何かキーを押してください
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
