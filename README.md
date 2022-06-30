# ChannelEngine test application

## What was done

* Custom high level Rest client. (Partial rip-off of your official client for .net but on top of HttpClient)
* Implemented required business logic. See MerchantWorkflow class.
* Required unit test. Used my typical set of packages for testing: xUnit, Autofixture, Moq, FluentAssetions. See CeTestApp.Infrastructure.UnitTests project.
* Two application endpoints: CeTestApp.Web and CeTestApp.Console.

## Pros of implementation

* DI even in console app.
* Ssync all way through
* Individual convetional commits
* Clean architecture, Solid, CQRS.
* Sensitive information not stored in VCS
* Third party libraries were not used. You only have to deal with bugs in your own abstractions :)

## What can be improved

* High level rest wrapper only tested on existed calls. No retry functionality.
* Exception handling on endpoints.
* Cancellation tokens.
* Help command in command line endpoint.

## How to run

Replace all occurrences of 'HERE_WAS_AN_API_KEY' with working api key, or supply it via API_KEY environment variable.
Use profiles defined in launchSettings to run endpoints:

* "CeTestApp.Web" for web endpoint.
* "CeTestApp.Console" for console endpoint.

Command line endpoint supports such commands: GetProducts, GetOrders, SetStock.
