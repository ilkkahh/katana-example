# katana-example #

Demonstrates katana's different hosting possibilities.

## Projects ##
### WebApi ###
Class library that contains Example ASP.NET Web Api and simple DependencyResolver.

### WebApiOwinHost ###
Demonstrates how owinhost.exe can be used to host Web API by using katana. 
Starts Web api to [http://localhost:55000](http://localhost:55000).

### WebApiSelfHost ###
Demonstrates how Web API by using katana can be selfhosted. 
Starts Web api to [http://localhost:56000](http://localhost:56000).

### WebApiSystemWebHost ###
Demonstrates how Web API by using katana can be hosted via IIS. 
Starts Web api to [http://localhost:57000](http://localhost:57000).

## Testing ##
Just start for example [Fiddler](http://www.telerik.com/download/fiddler) and send 
GET requests to _baseurl_/api/example. 