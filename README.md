Blade and Soul Effect Remover
==
> The software only supports Chinese language (zh-TW).

## 軟體概覽

![](https://i.imgur.com/6ha9IMu.png)

* 此軟體可以移除劍靈的職業技能特效，使得打副本時能夠更加順暢。
* 打比武、戰場、無限之塔前請把特效還原，否則自己怎麼死的可能都不知道。
* 移除特效後，人形NPC（如方舟小怪）的招式特效同時會被移除，請自行斟酌使用。
* 使用上若有遇到任何問題，請開一張[issue ticket](https://github.com/smilecatx3/Blade-and-Soul-Effect-Remover/issues)，並附上程式執行的log，作者有空時會協助處理。

## 系統需求
* 64位元Windows作業系統。
* [.NET Framework 4.6](https://www.microsoft.com/zh-tw/download/details.aspx?id=48137)。

## 軟體功能
* 一鍵移除/還原職業技能特效。
* 可以自訂要移除的職業。

## 使用方式
> 請先確定遊戲已完全關閉，否則可能導致無法移動檔案的錯誤。
1. 選擇遊戲資料夾。
2. 點選職業圖示：圖示為灰底代表要移除特效的職業，反之則為要保留特效的職業。
3. 按下「執行」按鈕。

## 軟體運作行為
* 移除特效的原理很單純，只是把該職業的技能upk檔案移動至另一個目錄：「NCSOFT\BNS_TW\contents\bns\EffectRemoverBackup」。
    > 此程式已通過完整測試，但若遊戲檔案(.upk)仍有毀損的情形時，請執行NC Launcher並點選「檢查檔案」以進行檔案復原的動作。
* 程式執行時會在程式目錄下產生「log」資料夾，最多保留30天份的記錄檔。
* 此軟體會讀寫Windows Registry：`HKEY_CURRENT_USER\SOFTWARE\GitHub\smilecatx3\BladeAndSoul\EffectRemover`。

## FAQ
### Q: 遊戲資料夾要選哪個?
參考下圖，請選擇「BNS_TW」資料夾。

![](https://i.imgur.com/sA3OBn2.png)

### Q: 按下「執行」按鈕後出現「刪除特效失敗」的錯誤訊息。
請確認遊戲是否已完全關閉。  
開啟工作管理員（Ctrl+Alt+Delete），切換至「詳細資料」頁面，檢查是否有劍靈「Client.exe」正在執行。

### Q: 按下「執行」按鈕後出現「建立備份目錄失敗」的錯誤訊息。
此軟體會在遊戲資料夾下建立一個備份目錄，若遊戲安裝在預設的「C:\Program Files (x86)」下，會因為Windows系統的安全性措施而導致無法順利建立備份目錄。  
請嘗試以系統管理員的方式執行該程式（對該程式按右鍵後選擇「以系統管理員身分執行」）。

### Q: 出現一些破圖問題，例如方舟二王的雷射光。
部分王的招式會使用到某些職業技能的特效，例如方舟二王會使用到咒術的技能特效。  
目前此軟體在移除職業招式特效時，無法細選到單個特效。若很在意破圖問題，請保留該職業的特效。

### Q: 把特效移除後還是一樣卡。
移除特效並不代表就能徹底解決劍靈卡頓的問題，會隨著每次更新以及當下伺服器狀況而有不同的情形。  
然而在大多時候，移除特效能稍微改善（尤其是12人本）卡頓的問題。

## Build Project
As image files are not committed to the repository, the project will be failed to build unless you manully put the image files into the project directory.

## Licensing
The project is distributed under the MIT license.
