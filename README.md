# C#ラッパージェネレータ

ACEのEngine側ラッパーをswig生成コードから生成するツール。

## 生成ルール

まだ準拠していないルールもあります。

* 列挙体はswigと同じ構造で生成する。
* クラスは以下のルールで生成する。
    * Coreで始まるクラスはCoreを取る。
    * "_Imp"がつくバージョンがあるクラスはImpが付く方のみ生成する。このときImpは取る。
    * 生成しないクラスをブラックリスト指定できる。
    * 生成しないメソッドをブラックリスト指定できる。
    * Getで始まるメソッドはプロパティのgetterに変換される。
    * Setで始まるメソッドはプロパティのsetterに変換される。
    * 同じ名前のgetterとsetterは１つのプロパティに統合される。
    * Get,Setのコメントが「～を取得する。」「～を設定する。」で終わる場合はそれを元にプロパティにコメントが生成される。そうでない場合はコメントは空になる。