using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager
{
    private static CommandManager instance;

    public static CommandManager Instance()
    {
        if (CommandManager.instance == null)
        {
            instance = new CommandManager();
        }
        return instance;
    }

    private Stack<Command> commandstack = new Stack<Command>();
    private Stack<Command> redostack = new Stack<Command>();

    private CommandManager()
    {
    }


    //adding to the list
    public void addcommand(Command command)
    {
        Debug.Log("added command");
        redostack.Clear();
        commandstack.Push(command);
    }

    public void undocommand()
    {
        if (commandstack.Count == 0)
        {
            return;
        }
        redostack.Push(commandstack.Peek());
        commandstack.Peek().Undo();
        commandstack.Pop();
        Debug.Log("undo");
    }

    public void redocommand()
    {
        Debug.Log("redo");
        if (redostack.Count == 0)
        {
            return;
        }
        redostack.Peek().Execute();
        commandstack.Push(redostack.Peek());
        redostack.Pop();

    }
}

