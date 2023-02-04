# ArduinoDetectionvalve
##  Summary　（概要）
ArduinoDetectionvalve 「Arduino檢測站」

我們可以從過去開發的小型專題看到許多單晶片都具有 Serial 回傳值，藉由 Serial 來蒐集控制器過程所傳回的數值是否出現異常，以便測試專題穩定性的過程中，控制器發生的狀態。
此軟體能更加便捷擷取傳回數據，並完全公開代碼供修改及個人化應用，只要註明出處即可。

隨著科技日新月異，許多小型專題從 Intel P8051 導向 Atmel AVR、Raspberry Pi 系列產品設計 。
在成本和能源有限狀況下，低成本、耗電量極低即擁有可擴展性的控制器是重要的考量，因此誕生需多用 Atmel AVR 完成小型專題。
![image](https://user-images.githubusercontent.com/107128781/177026205-3c58b095-8780-4d82-b1c3-d73d6881fcc1.png)

現有的 Arduino Software 本身帶有 Serial 窗口，功能雖齊全，卻無法直接主動記錄到設備記事本裡面，必需藉由人為干涉才能完成此項功能，
現今某些國家能源及豈不穩，導致出現限電或饋線跳脫，進而響應數據未即時記錄完成，造成嚴重損失風險，為了補齊紀錄功能缺失問題，
設計具備即時回傳數值及具有紀載功能，因此誕生此開發念頭。
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



