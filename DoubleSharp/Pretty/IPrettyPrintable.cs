namespace DoubleSharp.Pretty;

/// <summary>
/// IPrettyPrintable is the base class for any object which has special handling for pretty printing.
/// </summary>
public interface IPrettyPrintable {
	/// <summary>
	/// Returns the pretty printed string representing the object.
	/// </summary>
	/// <returns>The pretty printed string representing the object.</returns>
	string ToPrettyString();
}
