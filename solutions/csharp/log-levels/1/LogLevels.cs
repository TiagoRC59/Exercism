static class LogLine
{
    public static string Message(string logLine)
    {
        // 1. Pega o texto após o ": " e limpa os espaços nas pontas
        return logLine.Split(": ")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        // 2. Corta o texto que está dentro de "[" e "]" e converte para minúsculas
        int start = logLine.IndexOf('[') + 1;
        int lenght = logLine.IndexOf(']') - start;

        return logLine.Substring(start, lenght).ToLower();
    }

    public static string Reformat(string logLine)
    {
        // 3. Reorganiza a frase no formato: "Mensagem (nivel)"
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
