using System;

public interface IProgrammer
{
    void WorkOnTask();
}
public interface ILead
{
    void AssignTask();
    void CreateSubTask();
}

public class TeamLead : IProgrammer, ILead
{
  public void AssignTask() { /* Code to assign a Task*/ }
  public void CreateSubTask() { /* Code to create a sub task from a task. */ }
  public void WorkOnTask() { /* Code to implement to work on the Task. */ }
}

public class Programmer : IProgrammer
{
  public void WorkOnTask() { /* code to implement to work on the Task. */}
}

public class Manager : ILead
{
  public void AssignTask() { /* Code to assign a Task*/ }
  public void CreateSubTask() { /* Code to create a sub task from a task. */ }
}
