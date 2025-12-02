using System;
using System.Net.Http;

public class NetworkClient
{
    private int failCount = 0;

    // Імітація: перші 2 рази помилка HttpRequestException, потім успіх
    public bool PostUserProfile(string url, string profileJson)
    {
        failCount++;

        if (failCount <= 2)
        {
            throw new HttpRequestException("Помилка підключення до сервера (імітація).");
        }

        Console.WriteLine($"Профіль успішно відправлено на сервер: {url}");
        return true;
    }
}
