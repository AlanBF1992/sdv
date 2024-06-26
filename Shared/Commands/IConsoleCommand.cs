﻿namespace DaLion.Shared.Commands;

/// <summary>Interface for a console command for a mod.</summary>
public interface IConsoleCommand
{
    /// <summary>Gets the statement that triggers this command.</summary>
    string[] Triggers { get; }

    /// <summary>Gets the human-readable documentation shown when the player runs the 'help' command.</summary>
    string Documentation { get; }

    /// <summary>The action that will be executed.</summary>
    /// <param name="trigger">The trigger word.</param>
    /// <param name="args">The command arguments.</param>
    void Callback(string trigger, string[] args);
}
