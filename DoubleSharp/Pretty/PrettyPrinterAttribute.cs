namespace DoubleSharp.Pretty;

/// <summary>
/// An attribute applied to static methods which take a value of a given type
/// and return a pretty-printed string.
///
/// All methods with this attribute are automatically registered for pretty
/// printing.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class PrettyPrinterAttribute : Attribute {
}
