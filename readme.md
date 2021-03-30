# dotnet-lifetime-demo-webapi-project

此專案為 .NET Core 生命週期範例專案。

本專案基於 [docker-dotnet-webapi](https://github.com/eastmoon/docker-dotnet-webapi) 設立：

+ [執行專案說明](https://github.com/eastmoon/docker-dotnet-webapi#%E5%9F%B7%E8%A1%8C%E5%B0%88%E6%A1%88)
+ [範例文獻參考](https://github.com/eastmoon/docker-dotnet-webapi/blob/master/doc/dotnet-mvc-application-lifecycle.md)

```
[2021/03/30 18:51:15] [Program] Start
[2021/03/30 18:51:15] [Program] Create HostBuilder
[2021/03/30 18:51:16] [Program] Build Host
[2021/03/30 18:51:16] [Program] hostBuilder.ConfigureServices - Called
[2021/03/30 18:51:16] [Program] webBuilder.ConfigureServices - Called
[2021/03/30 18:51:16] [Startup] Constructor - Called
[2021/03/30 18:51:16] [Startup] ConfigureServices - Called
[2021/03/30 18:51:16] [Program] Run Host
[2021/03/30 18:51:16] [CustomAppModels] Constructor - Called
[2021/03/30 18:51:16] [CustomAppModels] OnProvidersExecuting - Called
[2021/03/30 18:51:16] [CustomAppModels] OnProvidersExecuted - Called
[2021/03/30 18:51:16] [Startup] Configure - Called
[2021/03/30 18:51:16] [Middleware] Run custom middleware constructor - Called
[2021/03/30 18:51:16] [Startup] ApplicationLifetime - Started
---
[2021/03/30 18:51:16] [Middleware] Run custom middleware - request flow
[2021/03/30 18:51:16] [Middleware] Run async lambda middleware - request flow
[2021/03/30 18:51:16] [Filters] CustomAuthorizationFilter in
[2021/03/30 18:51:16] [Filters] CustomResourceFilter in
[2021/03/30 18:51:17] [Filters] CustomActionFilter in
[2021/03/30 18:51:17] [ApplicationModels] Appliction : Custom Application Description
[2021/03/30 18:51:17] [ApplicationModels] Controller : Custom Controller Description
[2021/03/30 18:51:17] [ApplicationModels] Action : Custom Action Description
[2021/03/30 18:51:17] [DemoController] Http Request : 3707448
[2021/03/30 18:51:17] [DemoController] Controller Singleton 	1, 60495737
[2021/03/30 18:51:17] [DemoController] Controller Scoped 	2, 6326333
[2021/03/30 18:51:17] [DemoController] Controller Transient 	3, 2957860
[2021/03/30 18:51:17] [DemoController] Action Singleton 	1, 60495737
[2021/03/30 18:51:17] [DemoController] Action Scoped  		2, 6326333
[2021/03/30 18:51:17] [DemoController] Action Transient 	4, 32747756
[2021/03/30 18:51:17] [DemoController] HttpContext Singleton 	1, 60495737
[2021/03/30 18:51:17] [DemoController] HttpContext Scoped  	2, 6326333
[2021/03/30 18:51:17] [DemoController] HttpContext Transient 	5, 42331983
[2021/03/30 18:51:17] [Filters] CustomActionFilter out
[2021/03/30 18:51:17] [Filters] CustomResultFilter in
[2021/03/30 18:51:17] [Filters] CustomResultFilter out
[2021/03/30 18:51:17] [Filters] CustomResourceFilter out
[2021/03/30 18:51:17] [Middleware] Run async lambda middleware - response flow
[2021/03/30 18:51:17] [Middleware] Run custom middleware - response flow
[2021/03/30 18:51:18] [Middleware] Run custom middleware - request flow
[2021/03/30 18:51:18] [Middleware] Run async lambda middleware - request flow
[2021/03/30 18:51:18] [Filters] CustomAuthorizationFilter in
[2021/03/30 18:51:18] [Filters] CustomResourceFilter in
[2021/03/30 18:51:18] [Filters] CustomActionFilter in
[2021/03/30 18:51:18] [ApplicationModels] Appliction : Custom Application Description
[2021/03/30 18:51:18] [ApplicationModels] Controller : Custom Controller Description
[2021/03/30 18:51:18] [ApplicationModels] Action : Custom Action Description
[2021/03/30 18:51:18] [DemoController] Http Request : 39785641
[2021/03/30 18:51:18] [DemoController] Controller Singleton 	1, 60495737
[2021/03/30 18:51:18] [DemoController] Controller Scoped 	6, 45653674
[2021/03/30 18:51:18] [DemoController] Controller Transient 	7, 45523402
[2021/03/30 18:51:18] [DemoController] Action Singleton 	1, 60495737
[2021/03/30 18:51:18] [DemoController] Action Scoped  		6, 45653674
[2021/03/30 18:51:18] [DemoController] Action Transient 	8, 41149443
[2021/03/30 18:51:18] [DemoController] HttpContext Singleton 	1, 60495737
[2021/03/30 18:51:18] [DemoController] HttpContext Scoped  	6, 45653674
[2021/03/30 18:51:18] [DemoController] HttpContext Transient 	9, 35287174
[2021/03/30 18:51:18] [Filters] CustomActionFilter out
[2021/03/30 18:51:18] [Filters] CustomResultFilter in
[2021/03/30 18:51:18] [Filters] CustomResultFilter out
[2021/03/30 18:51:18] [Filters] CustomResourceFilter out
[2021/03/30 18:51:18] [Middleware] Run async lambda middleware - response flow
[2021/03/30 18:51:18] [Middleware] Run custom middleware - response flow
[2021/03/30 18:51:21] [Startup] Trigger stop WebHost
[2021/03/30 18:51:21] [Startup] ApplicationLifetime - Stopping
---
[2021/03/30 18:51:26] [Startup] ApplicationLifetime - Stopped
[2021/03/30 18:51:26] [Program] End
```
