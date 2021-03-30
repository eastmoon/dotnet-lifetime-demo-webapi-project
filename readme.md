# dotnet-lifetime-demo-webapi-project

此專案為 .NET Core 生命週期範例專案。

本專案基於 [docker-dotnet-webapi](https://github.com/eastmoon/docker-dotnet-webapi) 設立：

+ [執行專案說明](https://github.com/eastmoon/docker-dotnet-webapi#%E5%9F%B7%E8%A1%8C%E5%B0%88%E6%A1%88)
+ [範例文獻參考](https://github.com/eastmoon/docker-dotnet-webapi/blob/master/doc/dotnet-mvc-application-lifecycle.md)
IIS Express is running.
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\Document\Github\dotnet-lifetime-demo-webapi-project\app\WebService
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
Stopping IIS Express ...
IIS Express stopped.
```
[2021/03/30 14:06:35] [Program] Start
[2021/03/30 14:06:35] [Program] Create HostBuilder
[2021/03/30 14:06:35] [Program] Build Host
[2021/03/30 14:06:36] [Program] hostBuilder.ConfigureServices - Called
[2021/03/30 14:06:36] [Program] webBuilder.ConfigureServices - Called
[2021/03/30 14:06:36] [Startup] Constructor - Called
[2021/03/30 14:06:36] [Startup] ConfigureServices - Called
[2021/03/30 14:06:36] [Program] Run Host
[2021/03/30 14:06:36] [CustomAppModels] Constructor - Called
[2021/03/30 14:06:36] [CustomAppModels] OnProvidersExecuting - Called
[2021/03/30 14:06:36] [CustomAppModels] OnProvidersExecuted - Called
[2021/03/30 14:06:36] [Startup] Configure - Called
[2021/03/30 14:06:36] [Startup] ApplicationLifetime - Started
---
[2021/03/30 14:06:36] [Middleware] Run custom middleware - request flow
[2021/03/30 14:06:36] [Middleware] Run async lambda middleware - request flow
[2021/03/30 14:06:36] [ApplicationModels] Appliction : Custom Application Description
[2021/03/30 14:06:36] [ApplicationModels] Controller : Custom Controller Description
[2021/03/30 14:06:36] [ApplicationModels] Action : Custom Action Description
[2021/03/30 14:06:36] [DemoController] Http Request : 5826912
[2021/03/30 14:06:36] [DemoController] Controller Singleton 	1, 13896890
[2021/03/30 14:06:36] [DemoController] Controller Scoped 	2, 21621962
[2021/03/30 14:06:36] [DemoController] Controller Transient 	3, 55256301
[2021/03/30 14:06:36] [DemoController] Action Singleton 	1, 13896890
[2021/03/30 14:06:36] [DemoController] Action Scoped  		2, 21621962
[2021/03/30 14:06:36] [DemoController] Action Transient 	4, 51408035
[2021/03/30 14:06:36] [DemoController] HttpContext Singleton 	1, 13896890
[2021/03/30 14:06:36] [DemoController] HttpContext Scoped  	2, 21621962
[2021/03/30 14:06:36] [DemoController] HttpContext Transient 	5, 19531649
[2021/03/30 14:06:36] [Middleware] Run async lambda middleware - response flow
[2021/03/30 14:06:36] [Middleware] Run custom middleware - response flow
[2021/03/30 14:06:38] [Middleware] Run custom middleware - request flow
[2021/03/30 14:06:38] [Middleware] Run async lambda middleware - request flow
[2021/03/30 14:06:38] [ApplicationModels] Appliction : Custom Application Description
[2021/03/30 14:06:38] [ApplicationModels] Controller : Custom Controller Description
[2021/03/30 14:06:38] [ApplicationModels] Action : Custom Action Description
[2021/03/30 14:06:38] [DemoController] Http Request : 36963566
[2021/03/30 14:06:38] [DemoController] Controller Singleton 	1, 13896890
[2021/03/30 14:06:38] [DemoController] Controller Scoped 	6, 12036987
[2021/03/30 14:06:38] [DemoController] Controller Transient 	7, 25474675
[2021/03/30 14:06:38] [DemoController] Action Singleton 	1, 13896890
[2021/03/30 14:06:38] [DemoController] Action Scoped  		6, 12036987
[2021/03/30 14:06:38] [DemoController] Action Transient 	8, 42715336
[2021/03/30 14:06:38] [DemoController] HttpContext Singleton 	1, 13896890
[2021/03/30 14:06:38] [DemoController] HttpContext Scoped  	6, 12036987
[2021/03/30 14:06:38] [DemoController] HttpContext Transient 	9, 3038911
[2021/03/30 14:06:38] [Middleware] Run async lambda middleware - response flow
[2021/03/30 14:06:38] [Middleware] Run custom middleware - response flow
[2021/03/30 14:06:41] [Startup] Trigger stop WebHost
[2021/03/30 14:06:41] [Startup] ApplicationLifetime - Stopping
---
[2021/03/30 14:06:46] [Startup] ApplicationLifetime - Stopped
[2021/03/30 14:06:46] [Program] End
```
