# dotnet-lifetime-demo-webapi-project

此專案為 .NET Core 生命週期範例專案。

本專案基於 [docker-dotnet-webapi](https://github.com/eastmoon/docker-dotnet-webapi) 設立：

+ [執行專案說明](https://github.com/eastmoon/docker-dotnet-webapi#%E5%9F%B7%E8%A1%8C%E5%B0%88%E6%A1%88)
+ [範例文獻參考](https://github.com/eastmoon/docker-dotnet-webapi/blob/master/doc/dotnet-mvc-application-lifecycle.md)

```
[2021/03/29 19:03:02] [Program] Start
[2021/03/29 19:03:02] [Program] Create HostBuilder
[2021/03/29 19:03:02] [Program] Build Host
[2021/03/29 19:03:03] [Program] hostBuilder.ConfigureServices - Called
[2021/03/29 19:03:03] [Program] webBuilder.ConfigureServices - Called
[2021/03/29 19:03:03] [Startup] Constructor - Called
[2021/03/29 19:03:03] [Startup] ConfigureServices - Called
[2021/03/29 19:03:03] [Program] Run Host
[2021/03/29 19:03:03] [CustomAppModels] Constructor - Called
[2021/03/29 19:03:03] [CustomAppModels] OnProvidersExecuting - Called
[2021/03/29 19:03:03] [CustomAppModels] OnProvidersExecuted - Called
[2021/03/29 19:03:03] [Startup] Configure - Called
[2021/03/29 19:03:03] [Startup] ApplicationLifetime - Started
---
[2021/03/29 19:03:04] [ApplicationModels] Appliction : Custom Application Description
[2021/03/29 19:03:04] [ApplicationModels] Controller : Custom Controller Description
[2021/03/29 19:03:04] [ApplicationModels] Action : Custom Action Description
[2021/03/29 19:03:04] [DemoController] Http Request : 32747756
[2021/03/29 19:03:04] [DemoController] Controller Singleton 	1, 16145044
[2021/03/29 19:03:04] [DemoController] Controller Scoped 	2, 23749772
[2021/03/29 19:03:04] [DemoController] Controller Transient 	3, 3707448
[2021/03/29 19:03:04] [DemoController] Action Singleton 	1, 16145044
[2021/03/29 19:03:04] [DemoController] Action Scoped  		2, 23749772
[2021/03/29 19:03:04] [DemoController] Action Transient 	4, 6326333
[2021/03/29 19:03:04] [DemoController] HttpContext Singleton 	1, 16145044
[2021/03/29 19:03:04] [DemoController] HttpContext Scoped  	2, 23749772
[2021/03/29 19:03:04] [DemoController] HttpContext Transient 	5, 2957860
[2021/03/29 19:03:05] [ApplicationModels] Appliction : Custom Application Description
[2021/03/29 19:03:05] [ApplicationModels] Controller : Custom Controller Description
[2021/03/29 19:03:05] [ApplicationModels] Action : Custom Action Description
[2021/03/29 19:03:05] [DemoController] Http Request : 38414640
[2021/03/29 19:03:05] [DemoController] Controller Singleton 	1, 16145044
[2021/03/29 19:03:05] [DemoController] Controller Scoped 	6, 6630602
[2021/03/29 19:03:05] [DemoController] Controller Transient 	7, 1401080
[2021/03/29 19:03:05] [DemoController] Action Singleton 	1, 16145044
[2021/03/29 19:03:05] [DemoController] Action Scoped  		6, 6630602
[2021/03/29 19:03:05] [DemoController] Action Transient 	8, 5024928
[2021/03/29 19:03:05] [DemoController] HttpContext Singleton 	1, 16145044
[2021/03/29 19:03:05] [DemoController] HttpContext Scoped  	6, 6630602
[2021/03/29 19:03:05] [DemoController] HttpContext Transient 	9, 29422698
[2021/03/29 19:03:08] [Startup] Trigger stop WebHost
[2021/03/29 19:03:08] [Startup] ApplicationLifetime - Stopping
---
[2021/03/29 19:03:13] [Startup] ApplicationLifetime - Stopped
[2021/03/29 19:03:13] [Program] End
```
