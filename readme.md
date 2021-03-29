# dotnet-lifetime-demo-webapi-project

此專案為 .NET Core 生命週期範例專案。

本專案基於 [docker-dotnet-webapi](https://github.com/eastmoon/docker-dotnet-webapi) 設立：

+ [執行專案說明](https://github.com/eastmoon/docker-dotnet-webapi#%E5%9F%B7%E8%A1%8C%E5%B0%88%E6%A1%88)
+ [範例文獻參考](https://github.com/eastmoon/docker-dotnet-webapi/blob/master/doc/dotnet-mvc-application-lifecycle.md)

```
[2021/03/29 15:34:20] [Program] Start
[2021/03/29 15:34:21] [Program] Create HostBuilder
[2021/03/29 15:34:21] [Program] Build Host
[2021/03/29 15:34:21] [Program] hostBuilder.ConfigureServices - Called
[2021/03/29 15:34:21] [Program] webBuilder.ConfigureServices - Called
[2021/03/29 15:34:21] [Startup] Constructor - Called
[2021/03/29 15:34:21] [Startup] ConfigureServices - Called
[2021/03/29 15:34:21] [Program] Run Host
[2021/03/29 15:34:22] [Startup] Configure - Called
[2021/03/29 15:34:22] [Startup] ApplicationLifetime - Started
---
[2021/03/29 15:34:22] [DemoController] Http Request : 51408035
[2021/03/29 15:34:22] [DemoController] Controller Singleton 	1, 29422698
[2021/03/29 15:34:22] [DemoController] Controller Scoped 		2, 23399238
[2021/03/29 15:34:22] [DemoController] Controller Transient 	3, 5826912
[2021/03/29 15:34:22] [DemoController] Action Singleton 		1, 29422698
[2021/03/29 15:34:22] [DemoController] Action Scoped  			2, 23399238
[2021/03/29 15:34:22] [DemoController] Action Transient 		4, 21621962
[2021/03/29 15:34:22] [DemoController] HttpContext Singleton 	1, 29422698
[2021/03/29 15:34:22] [DemoController] HttpContext Scoped  		2, 23399238
[2021/03/29 15:34:22] [DemoController] HttpContext Transient 	5, 55256301
[2021/03/29 15:34:23] [DemoController] Http Request : 28068188
[2021/03/29 15:34:23] [DemoController] Controller Singleton 	1, 29422698
[2021/03/29 15:34:23] [DemoController] Controller Scoped 		6, 39086322
[2021/03/29 15:34:23] [DemoController] Controller Transient 	7, 33163964
[2021/03/29 15:34:23] [DemoController] Action Singleton 		1, 29422698
[2021/03/29 15:34:23] [DemoController] Action Scoped  			6, 39086322
[2021/03/29 15:34:23] [DemoController] Action Transient 		8, 36181605
[2021/03/29 15:34:23] [DemoController] HttpContext Singleton 	1, 29422698
[2021/03/29 15:34:23] [DemoController] HttpContext Scoped  		6, 39086322
[2021/03/29 15:34:23] [DemoController] HttpContext Transient 	9, 14421545
[2021/03/29 15:34:27] [Startup] Trigger stop WebHost
[2021/03/29 15:34:27] [Startup] ApplicationLifetime - Stopping
---
[2021/03/29 15:34:32] [Startup] ApplicationLifetime - Stopped
[2021/03/29 15:34:32] [Program] End
```
