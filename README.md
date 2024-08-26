# WPFBlazorMinimalAppTemplate
最小限の WPF Blazor アプリ を作成するためのテンプレート
## 使用法

### テンプレートの取得
[WPFBlazorMinApp.nupkg](https://github.com/kznagamori/WPFBlazorMinimalAppTemplate/releases/download/v1.0.0/kznagamori.WPFBlazorMinApp.1.0.0.nupkg)
をダウンロードします。

### テンプレートのインストール
ダウンロードしたnugetパッケージをインストールします。
```
dotnet new install kznagamori.WPFBlazorMinApp.1.0.0.nupkg
```

### 最小限の WPF Blazor アプリプロジェクトの作成
```
dotnet new wpf-blazor.min -n <プロジェクト名>
```
**例:** `dotnet new wpf-blazor.min -n MyWPFBlazorMin`

### テンプレートのアンインストール
```
dotnet new uninstall kznagamori.WPFBlazorMinApp
```

### ターゲット

net8.0のみをターゲットとしています。

### ビルド

```
dotnet build
```

### リリースビルド

```
dotnet publish -c Release
```

### 実行

`dotnet run` で実行すると以下の画面が表示されます。

![image-20240826174348317](assets/image-20240826174348317.png)



### kznagamori.WPFBlazorApp.X.X.X.nupkgの作成

```
nuget pack .\WPFBlazorMinimalAppTemplate.nuspec
```

