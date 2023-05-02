namespace Project;

/// <summary>
/// This is a summary from the XML comment in the source code.
/// </summary>
public class Class1
{
    /// <summary>
    /// A constant.
    /// </summary>
    public const string Const1 = "test";
    /// <summary>
    /// Does pretty much nothing.
    /// <code language="csharp">
    /// var x = new Class1();
    /// var y = x.Method1("test");
    /// Console.WriteLine(y);
    /// </code>
    /// </summary>
    /// <param name="param">Parameter 1</param>
    /// <exception cref="ArgumentNullException">Thrown when param is null.</exception>
    /// <returns>An object.</returns>
    public object Method1(string param)
    {
        if (param == null)
            throw new ArgumentNullException(nameof(param));
        return new();
    }

    /// <summary>
    /// Also does nothing.
    /// </summary>
    public static int? Method2(string? param)
    {
        return null;
    }
}