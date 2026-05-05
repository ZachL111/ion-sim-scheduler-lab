using IonSimSchedulerLab;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(55, 85, 14, 19, 13);
        if (Policy.Score(signalcase_1) != 130) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(78, 99, 12, 9, 5);
        if (Policy.Score(signalcase_2) != 210) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(86, 83, 23, 5, 11);
        if (Policy.Score(signalcase_3) != 222) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
