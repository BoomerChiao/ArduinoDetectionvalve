# ArduinoDetectionvalve
##  Summary　（概要）
ArduinoDetectionvalve 「Arduino檢測站」

我們可以從過去開發的小型專題中觀察到，許多單晶片都具備 Serial 回傳功能，透過 Serial 蒐集控制器運行過程中的回傳數據，以監測數值是否異常，進而分析專題的穩定性與控制器的運行狀態。

本軟體提供更便捷的方式來擷取回傳數據，並完全開源，允許自由修改與個人化應用，只需註明出處即可。

隨著科技日新月異，許多小型專題的設計從 Intel P8051 逐步轉向 Atmel AVR、Raspberry Pi 等系列產品。在成本與能源受限的情況下，低成本、低功耗且具備可擴展性的控制器成為重要考量，因此許多小型專題選擇使用 Atmel AVR 來實現。

![image](https://user-images.githubusercontent.com/107128781/177026205-3c58b095-8780-4d82-b1c3-d73d6881fcc1.png)

現有的 Arduino Software 雖然內建 Serial 視窗，並提供基本的數據監控與回傳功能，但其內建工具無法自動將數據記錄到設備的記事本或其他存儲位置，而是需要使用者手動複製、貼上或透過額外的方式進行記錄。這種設計在日常測試時或許足夠，但對於長時間運行、需要持續監測的應用來說，人工干預不僅不便，也可能導致數據遺失或記錄不完整的情況。

在某些國家或地區，由於能源供應不穩，可能會出現限電或饋線跳脫等問題，導致控制器或監測設備突然斷電，進而影響數據的即時記錄。如果在關鍵時刻未能完整保存回傳數據，可能會造成嚴重的風險，這些問題往往無法輕易復原，進一步增加了維護與監測的成本。

為了彌補這一缺陷，我們設計了一款具備即時回傳數據與自動紀錄功能的系統，能夠在數據產生時立即存儲，確保即使在意外斷電的情況下，也能最大程度地保留關鍵資訊，減少因電力問題導致的數據遺失風險，這正是本開發構想的起點。

![image](https://user-images.githubusercontent.com/107128781/177026175-f704649e-d78d-4fc8-8435-c3d7d3495a1e.png)

##  Installation/System requirements　（安裝/系統需求）
需安裝套件如下
- 作業系統: Windows Server 2016,Windows Server 2019,Windows Server 2022,Windows 10 , Windows 11 
- 必需支援.NET Framework 4.7.2
- (非必要) Visual Studio 2022 軟體下載：https://visualstudio.microsoft.com/zh-hant/vs/whatsnew/

![image](https://user-images.githubusercontent.com/107128781/177026380-bda1e074-94ec-4b2e-92e2-a76037dd6dae.png)

##  Function Description　（軟體功能解說）
![image](https://user-images.githubusercontent.com/107128781/177045486-311091fe-9695-4786-8224-003a6c30cea5.png)

⬆⬆⬆這是由 Visual Studio 2022 編譯而成的軟體，如果沒有要更改內部結構，可以單獨下載 ArduinoDetectionvalve.exe 即可。

　　
  

![image](https://user-images.githubusercontent.com/107128781/177045496-ee91198a-1231-4e12-987a-b70e56601eab.png)

⬆⬆⬆主程式打開後功能分為四大類。

- A：Com Port 用來選擇你想要讀取序列埠 (簡：串口)。
- B：Serial communication (Baud) 用來調整對應至有效數據訊號調變載波的速率。
- C：Log analysis 用來是否有需要紀錄 日誌檔案 ，可點選 Log setting 修改存儲資料夾。
- D：顯示目前 Com Port 讀取到的值。

　　

###  Com Port 
![image](https://user-images.githubusercontent.com/107128781/177045505-ccecf16e-9bfe-4b84-8f03-42e0bd301eeb.png)

⬆⬆⬆Com Port 功能主要用於探測可用串口，並且可執行連線。

ComboBox 功能主要用於自動探測設備中可用串口，並鎖定住 Com Port。

Connect Button 用來針對已鎖定住 Com Port，進行連線監測。

Reset Button 用於清除 ComboBox 鎖定住 Com Port 情除。

　　
　
###  Log box
![image](https://user-images.githubusercontent.com/107128781/216778315-6fc2dafc-cfa7-4100-8b13-c47ee606c10a.png)

⬆⬆⬆Log box 其功能主要閱讀已鎖定 Com Port ，監測到訊息加以顯示欄位。

　　
  
  

###  Log analysis
![image](https://user-images.githubusercontent.com/107128781/216630248-a1091552-3254-4a5a-8912-b3c6c79c77c8.png)

⬆⬆⬆Log analysis　功能主要進行存儲監控中　Com Port　，需透過 CheckBox 勾選是否要記錄，藉由 Log setting Button 可查閱資料儲存位置。   (預設 C:/Arduino_I2C_log)

CheckBox 功能主要針對是否存取 Log ，勾選代表存取；未勾選代表不存取。

Log setting Button 功能主要查閱資料儲存地點。

　　
  　
###  Log setting
![image](https://user-images.githubusercontent.com/107128781/216777389-27af7858-2ed7-4945-865b-bc49a59c499c.png)

⬆⬆⬆Log setting 透過點擊　Log setting Button 進入，其內部主要閱讀資料存取位置，也能透過勾選　Change file ，更改存取資料夾名稱。



