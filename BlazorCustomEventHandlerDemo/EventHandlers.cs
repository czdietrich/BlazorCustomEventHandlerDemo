namespace BlazorCustomEventHandlerDemo;

using Microsoft.AspNetCore.Components;

[EventHandler( "onmy-event", typeof( MyEventArgs ))]
public static class EventHandlers
{
}

public class MyEventArgs : EventArgs
{
    public string? Value { get; set; }
}
