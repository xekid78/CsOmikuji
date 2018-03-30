# CsOmikuji
おみくじ（.NET Core）

## 処理
`Random()`クラスを使用して1 ～ 6のランダムな数字を使って、おみくじの結果を出力します。

## コード
```
using System;

namespace Omikuji
{
    class Omikuji
    {
        static void Main(string[] args)
        {
            var rand = new Random();
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
        }
    }
}
```

## 出力例  
```
中吉
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
