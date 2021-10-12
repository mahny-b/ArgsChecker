# ArgsChecker
A tool that examines startup arguments.
起動引数をチェックするコンソールアプリです。間接的に起動するようなexeと差し替えて実行してみて下さい。

# 使い方
- 例）お気に入りのテキストエディタ（自分はmery.exe）に渡ってくる引数を知りたい場合
	- 対象の実行ファイルを退避する（mery.exe ⇒ mery.exe.orgにリネームする等）
	- ArgsChecker.exeをnotepad.exeにリネームして置き換えます
	- （適当なテキストファイルが関連付けされているとして、）テキストファイルをダブルクリックで開きます
	- DOS窓が出てきて、起動引数を表示するので確認します
	- 終わったら何かキーを押すとDOS窓が閉じて終了します

## 実行結果のサンプル

```console
[0]: "D:\home\mahny\local\mery\2.6.7\Mery.txt"
Press any key to exit.

```
