using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

public class UsersResultsStorage
{
    public string FilePath { get; }

    public UsersResultsStorage()
    {
        FilePath = "Результаты испытуемых.json";
    }

    public void SaveResultOfTesting(User user)
    {
        var userResults = GetUsersResults();
        userResults.Add(user);
        Save(userResults);
    }
    public List<User> GetUsersResults()
    {
        if(!File.Exists(FilePath))
        {
            return new List<User>();
        }
        var fileData = FilePath.GetInformation();
        var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
        return userResults;
    }

    public void Save(List<User> usersResults)
    {
        var JsonData = JsonConvert.SerializeObject(usersResults);
        JsonData.SaveInformation(FilePath);
    }
}

