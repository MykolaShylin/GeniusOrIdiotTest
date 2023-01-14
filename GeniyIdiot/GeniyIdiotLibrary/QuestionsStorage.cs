using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class QuestionsStorage
{
    public List<Question> StandartTestQuestions { get; }
    public string ExistingQuestionsFilePath { get; }
    public string StandartQuestionsFilePath { get; }

    public QuestionsStorage()
    {
        StandartTestQuestions = new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };

        ExistingQuestionsFilePath = "Вопросы для теста.json";
        StandartQuestionsFilePath = "Стандартные вопросы для теста.json";
    }

    public void SaveQuestions(List<Question> questionsList, bool standartQuestionsList)
    {
        if (!standartQuestionsList)
        {
            var JsonData = JsonConvert.SerializeObject(questionsList);
            JsonData.SaveInformation(ExistingQuestionsFilePath);
        }
        else
        {
            var JsonData = JsonConvert.SerializeObject(questionsList);
            JsonData.SaveInformation(StandartQuestionsFilePath);
        }        
    }

    public List<Question> GetQuestions(bool standartQuestionsList)
    {
        var questionsList = new List<Question>();
        if (File.Exists(ExistingQuestionsFilePath) && !standartQuestionsList)
        {            
            var fileData = ExistingQuestionsFilePath.GetInformation();
            questionsList = JsonConvert.DeserializeObject<List<Question>>(fileData);
        }
        else
        {
            var fileData = StandartQuestionsFilePath.GetInformation();
            questionsList = JsonConvert.DeserializeObject<List<Question>>(fileData);
        }
        return questionsList;
    }
}

