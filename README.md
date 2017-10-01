# Noobot.Examples
Some example projects of how to use Noobot

## Projects

### Console/Service Example
Based on the [Noobot.Runner](https://github.com/noobot/noobot) project built on TopShelf. This allow you to run the application as a console app (great for debugging) and also as a Windows Service (for longer running sessions).

### ASP Dot Net Core
This project demonstrates how you can embed Noobot into a Web context. Not too different from the Console/Service example. 

This implementation contains an example of how you can map to a Noobot configuration from a Dot Net Core context.

## Implementation Details

### Noobot Log
Noobot accepts an optional ```ILog``` implementation, if one isn't supplied then Noobot doesn't log. You will find in our examples we are supplying our own implementations of ILog to give us the power of outputting this log on screen in different ways.
