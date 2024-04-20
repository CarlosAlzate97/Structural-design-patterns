using Creational_patterns.Abstractions;
using Creational_patterns.Implementators;

public class Start
{
    public static void Main()
    {
        IStepsToDeploy steam = new Steam();
        IStepsToDeploy epic = new Epic();
        IStepsToDeploy gog = new GoG();
        IStepsToDeploy gamepass = new GamePass();

        Deployment actionGameSteam = new GenericActionGame(steam);
        Deployment actionGameEpic = new GenericActionGame(epic);
        Deployment actionGameGog = new GenericActionGame(gog);
        Deployment actionGameGamePass = new GenericActionGame(gamepass);

        Deployment mmorpgGameSteam = new GenericMMMORPGgame(steam);
        Deployment mmorpgGameEpic = new GenericMMMORPGgame(epic);
        Deployment mmorpgGameGog = new GenericMMMORPGgame(gog);
        Deployment mmorpgGameGamePass = new GenericMMMORPGgame(gamepass);

        Deployment mobaGameSteam = new GenericMOBAGame(steam);
        Deployment mobaGameEpic = new GenericMOBAGame(epic);
        Deployment mobaGameGog = new GenericMOBAGame(gog);
        Deployment mobaGameGamePass = new GenericMOBAGame(gamepass);

        actionGameSteam.StartDeploy();
        actionGameSteam.FinishDeploy();
        Console.WriteLine("-----------------------------------------------------------");
        mobaGameEpic.StartDeploy();
        mobaGameGog.FinishDeploy();

    }
}
