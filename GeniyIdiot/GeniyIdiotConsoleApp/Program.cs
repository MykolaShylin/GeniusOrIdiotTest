using System;
using System.IO;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using GeniyIdiotLibrary;

class Program
{    
    static void Main()
    {
        Console.WriteLine("Здравствуйте, вас приветствует программа по определению уровня вашего \nинтелекта! Выберете пункт действий!");
        var questionsStorage = new QuestionsStorage();
        questionsStorage.SaveQuestions(questionsStorage.StandartTestQuestions, true);
        bool standartQuestionsList = false;
        int outFromMenuNumber;
        do
        {
            var choiceOfActions = GetListOfChousing();
            foreach (var action in choiceOfActions)
            {
                Console.WriteLine(action);
            }
            int userSelectedItem = ChecUserChoise(choiceOfActions.Count);
            outFromMenuNumber = GetUserChoise(userSelectedItem, questionsStorage);
            if (outFromMenuNumber == 4)
            {
                standartQuestionsList = true;
            }
        } while (outFromMenuNumber != 5 && outFromMenuNumber != 4);


        bool stopProgram = true;
        while (stopProgram)
        {
            Console.WriteLine("Начинаем тест, пожалуйста, введите ваше имя:");
            string name = Console.ReadLine();
            var user = new User(name);
            string userName = user.UserName;
            Console.WriteLine($"Удачи {userName}!");
            var questionsList = questionsStorage.GetQuestions(false);
            if (standartQuestionsList)
            {
                questionsList = questionsStorage.GetQuestions(true);
            }
            int questionsCount = questionsList.Count;
            user.CountRightAnswers = GetCountRightAnswers(user, questionsList);
            user.Diagnosis = AllTestMethods.GetUserDiagnosis(user, questionsCount);
            Console.WriteLine(AllTestMethods.ShowTestResult(user));
            var testingResultStorage = new UsersResultsStorage();
            testingResultStorage.SaveResultOfTesting(user);

            bool usersResultsTabel = GetAnswerForShowingResults();
            if (usersResultsTabel)
            {
                var userResults = testingResultStorage.GetUsersResults();
                ShowUsersResults(userResults);
            }
            DeliteOrContinueSavingResults(testingResultStorage.FilePath);
            stopProgram = GetAnswerRepeatProgramAgain(userName);
        }
    }
    static int ChecUserChoise(int countOfChoices)
    {
        int userChoiceNumber;
        do
        {
            var answerForStartingNewTest = GetUserValueAnswer();
            userChoiceNumber = answerForStartingNewTest;
            if (userChoiceNumber > countOfChoices || userChoiceNumber < 1)
            {
                Console.WriteLine("Вы выбрали несуществующий пункт. \nПожалуйста, выберите номер пункта, который видите на экране!");
            }
        }
        while (userChoiceNumber > countOfChoices || userChoiceNumber < 1);
        return userChoiceNumber;
    }
    static int GetUserChoise(int userSelectedItem, QuestionsStorage questionsStorage)
    {
        switch (userSelectedItem)
        {
            case 1:
                AddNewQuestion(questionsStorage);
                break;
            case 2:
                DeliteQuestion(questionsStorage);
                break;
            case 3:
                return 5;
            case 4:
                return 4;
            case 5:
                return 5;
        }
        return -1;
    }

    static List<string> GetListOfChousing()
    {
        return new List<string>
            {
                "1) Добавить новый вопрос в список.",
                "2) Удалить вопрос.",
                "3) Начать тест с существующими вопросами и выйти из этого меню.",
                "4) Начать тест со стандартным списком вопросов.",
                "5) Выбрат этот пункт, если хотите завершить работу в этом меню и начать тест."
            };
    }
    static void DeliteQuestion(QuestionsStorage questionsStorage)
    {
        bool delitingQuestion = false;
        var questionsList = questionsStorage.GetQuestions(false);
        do
        {
            Console.WriteLine("Выбирете номер вопроса, который хотите удалить!");
            int num = 1;
            foreach (var question in questionsList)
            {
                Console.WriteLine($"{num}) {question.Text}");
                num++;
            }
            int userAnswer = ChecUserChoise(questionsList.Count);
            questionsList.RemoveAt(userAnswer - 1);
            Console.WriteLine("Вопрос успешно удален!");
            Console.WriteLine("Хотите удалить еще вопрос? Введите \" да \" или \" нет \"");
            delitingQuestion = GetUserStringAnswer();
            if (!delitingQuestion)
            {
                questionsStorage.SaveQuestions(questionsList, false);
            }

        } while (delitingQuestion);
    }

    static void AddNewQuestion(QuestionsStorage questionsStorage)
    {
        bool newQuestionAdding = false;
        var newQuestionsList = questionsStorage.GetQuestions(false);
        do
        {
            Console.Write("Введите новый вопрос: ");
            string newQuestion = Console.ReadLine();
            Console.Write("Введите ответ: ");
            int newAnswer = GetUserValueAnswer();
            var question = new Question(newQuestion, newAnswer);
            newQuestionsList.Add(question);
            Console.WriteLine("Вопрос успешно добавлен!");
            Console.WriteLine("Хотите добавить еще вопрос? Введите \" да \" или \" нет \"");
            newQuestionAdding = GetUserStringAnswer();
            if (!newQuestionAdding)
            {
                questionsStorage.SaveQuestions(newQuestionsList, false);
            }

        } while (newQuestionAdding);
    }
    static void ShowUsersResults(List<User> usersResults)
    {
        string stringFormat = "{0, -30} {1, -30} {2, 0}";
        Console.WriteLine(stringFormat, "Ф.И.О.:", "Количество верных ответов:", "Диагноз:");

        foreach (var user in usersResults)
        {
            Console.WriteLine(stringFormat, user.UserName, user.CountRightAnswers, user.Diagnosis);
        }

    }
    static int GetCountRightAnswers(User user, List<Question> questionsList)
    {
        int questionsCount = questionsList.Count;
        Random random = new Random();

        for (int i = 0; i < questionsCount; i++)
        {
            int randomQuestionIndex = random.Next(0, questionsList.Count);
            Console.WriteLine("Вопрос №" + (i + 1));
            Console.WriteLine(questionsList[randomQuestionIndex].Text);
            int userAnswer = GetUserValueAnswer();
            int rightAnswer = questionsList[randomQuestionIndex].Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptWrightAnswer();
            }
            questionsList.RemoveAt(randomQuestionIndex);
        }
        return user.CountRightAnswers;
    }
    static int GetUserValueAnswer()
    {
        bool rightUserAnswer = false;
        int userAnswer = 0;
        while (!rightUserAnswer)
        {
            try
            {
                int userAnswerConvert = int.Parse(Console.ReadLine());
                userAnswer = userAnswerConvert;
                rightUserAnswer = true;
            }
            catch
            {
                Console.WriteLine("Неверный формат ввода, пожалуйста, убедитесь, что вы ввели число или, что \nвведенное число находится в диапозоне от -2147483647 до 2147483647 и введите ответ снова!");
            }
        }
        return userAnswer;
    }
    static bool GetUserStringAnswer()
    {
        bool rightUserAnswer = false;
        string userAnswer = "";
        while (!rightUserAnswer)
        {
            string answer = Console.ReadLine().ToLower();

            if (answer != "нет" && answer != "да")
            {
                Console.WriteLine("Неверный формат ввода, пожалуйста, введите \" да \" или \" нет \".");
            }
            else
            {
                userAnswer = answer;
                rightUserAnswer = true;
            }

        }
        return userAnswer == "да" ? true : false;
    }
    static bool GetAnswerRepeatProgramAgain(string userName)
    {
        Console.WriteLine($"{userName}, желаете пройти тест снова? Введите \" да \" или \" нет \".");
        return GetUserStringAnswer();
    }

    static void DeliteOrContinueSavingResults(string FilePath)
    {
        Console.WriteLine("Удалить результаты всех тестов или продолжить запись? \nВведите \" да \", если хотите удалить, \" нет \" - продолжить запись.");
        bool userAnswer = GetUserStringAnswer();
        if (userAnswer)
        {
            File.Delete(FilePath);
        }
    }
    static bool GetAnswerForShowingResults()
    {
        Console.WriteLine("Желаете просмотреть результаты всех испытуемых? Введите \" да \" или \" нет \"");
        return GetUserStringAnswer();
    }
}

