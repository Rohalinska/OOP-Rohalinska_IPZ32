using System;
using System.IO;

public class FileProcessor
{
    private int failCount = 0;

    // Імітація: перші 3 рази помилка FileNotFoundException, потім успіх
    public void UpdateUserProfile(string path, string profileJson)
    {
        failCount++;

        if (failCount <= 3)
        {
            throw new FileNotFoundException("Файл профілю не знайдено (імітація).");
        }

        Console.WriteLine($"Профіль користувача успішно оновлено у файлі: {path}");
    }
}
