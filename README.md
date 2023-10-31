### 需要的 SDK

請由此處下載：https://dotnet.microsoft.com/en-us/download/dotnet/7.0
通常選擇最新版 SDK 7.x.xxx 的 Windows 版本 x64 installer 下載並安裝即可。

### 執行方式

1. 請開啟命令列 (如 Windows PowerShell)，並移動至此專案資料夾下。
2. 請輸入以下指令，以信任 HTTPS 開發憑證：
```
dotnet dev-certs https --trust
```
3. 請輸入以下指令啟動 API 服務：
```
dotnet run --launch-profile https
```
4. 執行後會顯示監聽的位址與埠號，如 `https://localhost:7203`。請在後方加入 `/swagger/index.html`，以查詢要執行的 API。完整的網址範例為：https://localhost:7203/swagger/index.html。

5. 請在命令列按下 Ctrl + C 結束 API 服務。