using System;
using System.IO;
using System.Net.Http;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Лабораторна робота №7 — Варіант 14 ===\n");

        var fileProcessor = new FileProcessor();
        var networkClient = new NetworkClient();

        string path = "user_profile.json";
        string json = "{ \"name\": \"Alex\", \"age\": 17 }";

        // Делегат для вибору винятків, на які треба повторювати спробу
        Func<Exception, bool> retryFor = ex =>
            ex is FileNotFoundException ||
            ex is HttpRequestException;

        Console.WriteLine(">>> Оновлення профілю користувача у файлі:\n");

        RetryHelper.ExecuteWithRetry(
            () => {
                fileProcessor.UpdateUserProfile(path, json);
                return true;
            },
            retryCount: 4,
            initialDelay: TimeSpan.FromSeconds(1),
            shouldRetry: retryFor
        );

        Console.WriteLine("\n>>> Відправлення профілю на сервер:\n");

        RetryHelper.ExecuteWithRetry(
            () => networkClient.PostUserProfile("https://server.com/profile", json),
            retryCount: 3,
            initialDelay: TimeSpan.FromSeconds(1),
            shouldRetry: retryFor
        );

        Console.WriteLine("\n=== Завершено успішно ===");
    }
}
