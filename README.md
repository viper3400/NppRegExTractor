# NppRegExTractor
Plugin for Notpad++ which itegrates RegExTractor into Notepad++

[![Build status](https://ci.appveyor.com/api/projects/status/wey1eh49t7b6v5ko?svg=true)](https://ci.appveyor.com/project/viper3400/nppregextractor)

## (!) Notepad++ 7.5.8 and higher (!)

Plugin Manager and plugin system of Notepad++ has been redesigned and there are some breaking changes. You need to use NppRegExTractor V2.1.0 or higher. See https://github.com/viper3400/NppRegExTractor/issues/5.

 As the plugin is just a wrapper for https://github.com/viper3400/RegExTractor, please consider using the native windows app.

## Install plugin into Notepad++
* Download latest version of NppRegExTractor here: https://github.com/viper3400/NppRegExTractor/releases/latest
* Extract content of zip archive
* Browse to your Notepad++ program directory, mostly located unter "C:\Program Files (x86)\Notepad++"
* Find the subdirectory plugins, mostly "C:\Program Files (x86)\Notepad++\plugins"
* Create new folder in here, name it "NppRegExTractorPlugin"
* Place content from the downloaded zip archive in here
* Be aware to keep files in RegExTractor directory within this subdirectory
* Starting with version 2.0.0 there is also a x64 build available (for Notepad++ x64)
* Restart Notepad++ and find NppRegExTractor plugin in menu
* Usage: https://github.com/viper3400/RegExTractor/wiki

![](https://github.com/viper3400/NppRegExTractor/blob/master/src/doc/images/npp_plugins_dir.png)


## Content of zip archive
* ./NppRegExtratorPlugin.dll
* ./RegExTractor/Ninject.dll
* ./RegExTractor/RegExTractor.dll
* ./RegExTractor/RegExTractorModules.dll
* ./RegExTractor/RegExTractorShared.dll
* ./RegExTractor/RegExTractorWinForm.dll


## Remark to cloners
_As NppRegExTractor is a wrapper of RegExTractor libs, you have also to clone and build https://github.com/viper3400/RegExTractor!_

## Versioning
Starting with version 2.0.0 of NppRegExtractor the versioning of the Notepad++ plugin will be independent from https://github.com/viper3400/RegExTractor. 

|NppRegExtractor Version|Contained RegExTractor Version|
|-----------------------|------------------------------|
|1.3.4                  |1.3.4                         |
|2.0.0                  |1.3.4                         |
|2.1.0                  |1.4.0                         |
