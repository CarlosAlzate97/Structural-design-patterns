using Creational_patterns.Abstractions;
using Creational_patterns.Implementators;

public class Start
{
    public static void Main()
    {
        IStepsToDeploy steam = new Steam();
        IStepsToDeploy epic = new Epic();

        Deployment actionGameSteam = new GenericActionGame(steam);
        Deployment mobaGameEpic = new GenericMOBAGame(epic);

        actionGameSteam.StartDeploy();
        actionGameSteam.FinishDeploy();
        Console.WriteLine("-----------------------------------------------------------");
        mobaGameEpic.StartDeploy();
        mobaGameEpic.FinishDeploy();

    }
}
