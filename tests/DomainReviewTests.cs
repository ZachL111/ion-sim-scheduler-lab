using IonSimSchedulerLab;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(58, 26, 17, 63);
        if (DomainReviewLens.Score(item) != 154) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
