
public class User
{
    public string UserName { get; }
    public int CountRightAnswers { get; set; }
    public string Diagnosis { get; set; }

    public User(string userName)
    {
        UserName = userName;
    }

    public void AcceptWrightAnswer()
    {
        CountRightAnswers++;
    }
}

