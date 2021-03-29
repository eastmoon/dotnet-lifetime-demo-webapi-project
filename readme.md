# dotnet-lifetime-demo-webapi-project

此專案為 .NET Core 生命週期範例專案。

本專案基於 [docker-dotnet-webapi](https://github.com/eastmoon/docker-dotnet-webapi) 設立：

+ [執行專案說明](https://github.com/eastmoon/docker-dotnet-webapi#%E5%9F%B7%E8%A1%8C%E5%B0%88%E6%A1%88)
+ [範例文獻參考](https://github.com/eastmoon/docker-dotnet-webapi/blob/master/doc/dotnet-mvc-application-lifecycle.md)

```
[2021/03/29 15:38:33] [Program] Start
[2021/03/29 15:38:33] [Program] Create HostBuilder
[2021/03/29 15:38:33] [Program] Build Host
[2021/03/29 15:38:33] [Program] hostBuilder.ConfigureServices - Called
[2021/03/29 15:38:33] [Program] webBuilder.ConfigureServices - Called
[2021/03/29 15:38:33] [Startup] Constructor - Called
[2021/03/29 15:38:33] [Startup] ConfigureServices - Called
[2021/03/29 15:38:33] [Program] Run Host
[2021/03/29 15:38:34] [Startup] Configure - Called
[2021/03/29 15:38:34] [Startup] ApplicationLifetime - Started
---
[2021/03/29 15:38:34] [DemoController] Http Request : 5826912
[2021/03/29 15:38:34] [DemoController] Controller Singleton 	1, 13896890
[2021/03/29 15:38:34] [DemoController] Controller Scoped 	2, 21621962
[2021/03/29 15:38:34] [DemoController] Controller Transient 	3, 55256301
[2021/03/29 15:38:34] [DemoController] Action Singleton 	1, 13896890
[2021/03/29 15:38:34] [DemoController] Action Scoped  		2, 21621962
[2021/03/29 15:38:34] [DemoController] Action Transient 	4, 51408035
[2021/03/29 15:38:34] [DemoController] HttpContext Singleton 	1, 13896890
[2021/03/29 15:38:34] [DemoController] HttpContext Scoped  	2, 21621962
[2021/03/29 15:38:34] [DemoController] HttpContext Transient 	5, 19531649
[2021/03/29 15:38:35] [DemoController] Http Request : 9029417
[2021/03/29 15:38:35] [DemoController] Controller Singleton 	1, 13896890
[2021/03/29 15:38:35] [DemoController] Controller Scoped 	6, 62107587
[2021/03/29 15:38:35] [DemoController] Controller Transient 	7, 55400036
[2021/03/29 15:38:35] [DemoController] Action Singleton 	1, 13896890
[2021/03/29 15:38:35] [DemoController] Action Scoped  		6, 62107587
[2021/03/29 15:38:35] [DemoController] Action Transient 	8, 29190913
[2021/03/29 15:38:35] [DemoController] HttpContext Singleton 	1, 13896890
[2021/03/29 15:38:35] [DemoController] HttpContext Scoped  	6, 62107587
[2021/03/29 15:38:35] [DemoController] HttpContext Transient 	9, 22550079
[2021/03/29 15:38:39] [Startup] Trigger stop WebHost
[2021/03/29 15:38:39] [Startup] ApplicationLifetime - Stopping
---
[2021/03/29 15:38:44] [Startup] ApplicationLifetime - Stopped
[2021/03/29 15:38:44] [Program] End
```
