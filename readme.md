# dotnet-lifetime-demo-webapi-project

此專案為 .NET Core 生命週期範例專案。

本專案基於 [docker-dotnet-webapi](https://github.com/eastmoon/docker-dotnet-webapi) 設立：

+ [執行專案說明](https://github.com/eastmoon/docker-dotnet-webapi#%E5%9F%B7%E8%A1%8C%E5%B0%88%E6%A1%88)
+ [範例文獻參考](https://github.com/eastmoon/docker-dotnet-webapi/blob/master/doc/dotnet-mvc-application-lifecycle.md)

```
[2021/03/30 14:38:54] [Program] Start
[2021/03/30 14:38:54] [Program] Create HostBuilder
[2021/03/30 14:38:54] [Program] Build Host
[2021/03/30 14:38:54] [Program] hostBuilder.ConfigureServices - Called
[2021/03/30 14:38:54] [Program] webBuilder.ConfigureServices - Called
[2021/03/30 14:38:54] [Startup] Constructor - Called
[2021/03/30 14:38:54] [Startup] ConfigureServices - Called
[2021/03/30 14:38:54] [Program] Run Host
[2021/03/30 14:38:55] [CustomAppModels] Constructor - Called
[2021/03/30 14:38:55] [CustomAppModels] OnProvidersExecuting - Called
[2021/03/30 14:38:55] [CustomAppModels] OnProvidersExecuted - Called
[2021/03/30 14:38:55] [Startup] Configure - Called
[2021/03/30 14:38:55] [Middleware] Run custom middleware constructor - Called
[2021/03/30 14:38:55] [Startup] ApplicationLifetime - Started
---
[2021/03/30 14:38:55] [Middleware] Run custom middleware - request flow
[2021/03/30 14:38:55] [Middleware] Run async lambda middleware - request flow
[2021/03/30 14:38:55] [ApplicationModels] Appliction : Custom Application Description
[2021/03/30 14:38:55] [ApplicationModels] Controller : Custom Controller Description
[2021/03/30 14:38:55] [ApplicationModels] Action : Custom Action Description
[2021/03/30 14:38:55] [DemoController] Http Request : 51408035
[2021/03/30 14:38:55] [DemoController] Controller Singleton 	1, 29422698
[2021/03/30 14:38:55] [DemoController] Controller Scoped 	2, 23399238
[2021/03/30 14:38:55] [DemoController] Controller Transient 	3, 5826912
[2021/03/30 14:38:55] [DemoController] Action Singleton 	1, 29422698
[2021/03/30 14:38:55] [DemoController] Action Scoped  		2, 23399238
[2021/03/30 14:38:55] [DemoController] Action Transient 	4, 21621962
[2021/03/30 14:38:55] [DemoController] HttpContext Singleton 	1, 29422698
[2021/03/30 14:38:55] [DemoController] HttpContext Scoped  	2, 23399238
[2021/03/30 14:38:55] [DemoController] HttpContext Transient 	5, 55256301
[2021/03/30 14:38:55] [Middleware] Run async lambda middleware - response flow
[2021/03/30 14:38:55] [Middleware] Run custom middleware - response flow
[2021/03/30 14:38:56] [Middleware] Run custom middleware - request flow
[2021/03/30 14:38:56] [Middleware] Run async lambda middleware - request flow
[2021/03/30 14:38:56] [ApplicationModels] Appliction : Custom Application Description
[2021/03/30 14:38:56] [ApplicationModels] Controller : Custom Controller Description
[2021/03/30 14:38:56] [ApplicationModels] Action : Custom Action Description
[2021/03/30 14:38:56] [DemoController] Http Request : 29190913
[2021/03/30 14:38:56] [DemoController] Controller Singleton 	1, 29422698
[2021/03/30 14:38:56] [DemoController] Controller Scoped 	6, 44501086
[2021/03/30 14:38:56] [DemoController] Controller Transient 	7, 9029417
[2021/03/30 14:38:56] [DemoController] Action Singleton 	1, 29422698
[2021/03/30 14:38:56] [DemoController] Action Scoped  		6, 44501086
[2021/03/30 14:38:56] [DemoController] Action Transient 	8, 62107587
[2021/03/30 14:38:56] [DemoController] HttpContext Singleton 	1, 29422698
[2021/03/30 14:38:56] [DemoController] HttpContext Scoped  	6, 44501086
[2021/03/30 14:38:56] [DemoController] HttpContext Transient 	9, 55400036
[2021/03/30 14:38:56] [Middleware] Run async lambda middleware - response flow
[2021/03/30 14:38:56] [Middleware] Run custom middleware - response flow
[2021/03/30 14:39:00] [Startup] Trigger stop WebHost
[2021/03/30 14:39:00] [Startup] ApplicationLifetime - Stopping
---
[2021/03/30 14:39:05] [Startup] ApplicationLifetime - Stopped
[2021/03/30 14:39:05] [Program] End
```
