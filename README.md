# ArduinoDetectionvalve
##  Summary　（概要）
ArduinoDetectionvalve 「Arduino檢測站」

在過去幾年開發小型專題中，許多單晶片都具有 Serial 回傳值，為了能更加便捷擷取傳回數據，因此開發此項軟體，並且完全公開透明化代碼，以便後來進行簡易修改。

隨著科技日新月異，許多小型專題導向 Atmel AVR 系列產品的設計，也有部分採用 Intel P8051 和 Raspberry Pi

但在成本和有限的能源計畫中，局多導向具有低成本又省電或者耗電量極低控制器，因此誕生需多用 Atmel AVR 完成小型專題

在測試專題穩定性的過程中，往往都必續借有電腦蒐集控制器過程中傳回數值是否出現異常現象問體，因此就會用到 Serial 回傳當下控制器發生甚麼事情。

現有的 Arduino Software 本身帶有 Serial 窗口，功能雖齊全，卻無法直接主動記錄到設備記事本裡面，必需藉由人為干涉才能完成此項功能

現今某些國家能源及豈不穩，導致出現限電或饋線跳脫，導致數據未即時記錄完成，造成嚴重數據損失風險

為了補齊紀錄功能缺失問題，設計具備即時回傳數值及具有紀載功能，因此誕生此開發念頭。

##  Installation/System requirements　（安裝/系統需求）
需安裝套件如下
- 作業系統: Windows Server 2016,Windows Server 2019,Windows Server 2022,Windows 10 , Windows 11 
- 支援.NET Framework 4.7.2
- Visual Studio 2022 軟體下載：https://visualstudio.microsoft.com/zh-hant/vs/whatsnew/

##  Function Description　（軟體功能解說）


