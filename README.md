# Noobot.Examples
Some example projects of how to use Noobot

## Projects

### Console/Service Example
Based on the [Noobot.Runner](https://github.com/noobot/noobot) project built on TopShelf. This allow you to run the application as a console app (great for debugging) and also as a Windows Service (for longer running sessions).

### Asp.NET MVC
This has been built after some users asking if it would work in a Web context. Not too different from the Console/Service example. 

## Implementation Details

### Noobot Configurations
Noobot requires you to supply an implemention of IConfiguration - this defines all the middleware and plugins you wish to be used in the Noobot session. Each of the example projects come with an ```ExampleConfiguration.cs``` class to show how you can use ```ConfigurationBase``` if you want to use the syntactic sugar Noobot supplies out of the box.

### Noobot Config Readers
Noobot, along with some middleware/plugins will rely on Config entries to be supplied. We have included an ```ExampleJsonConfigReader``` to show how you could read config out of a file. We have purposely not included a Reader implementation as we don't want users to think they have to store account details in Json (etc).

### Noobot Log
Noobot accepts an optional ```ILog``` implementation, if one isn't supplied then Noobot doesn't log. You will find in our examples we are supplying our own implementations of ILog to give us the power of outputting this log on screen in different ways.
