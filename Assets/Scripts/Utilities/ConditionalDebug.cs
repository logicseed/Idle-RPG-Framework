using System;
using System.Diagnostics;

/// <summary>
/// Class containing methods to ease debugging while developing a game.
/// </summary>
/// <remarks>
/// This is a custom wrapper that allows for the conditional execution of Debug commands.
/// </remarks>
/// <example>
/// You must include this class in order to override the standard Unity Debug class.
/// <code>
/// using Debug = ConditionalDebug;
/// </code>
/// Then you can use it exactly as if it was the standard Unity Debug class.
/// https://docs.unity3d.com/ScriptReference/Debug.html
/// </example>
public class ConditionalDebug
{
    private const String DEBUG_CONDITIONAL = "UNITY_EDITOR";

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <remarks>
    /// Message of a type of LogType.Assert is logged.
    /// </remarks>
    /// <param name="condition">
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Assert(Boolean condition)
    {
        UnityEngine.Debug.Assert(condition);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <remarks>
    /// Message of a type of LogType.Assert is logged.
    /// </remarks>
    /// <param name="condition">
    /// Condition you expect to be true.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Assert(Boolean condition, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, context);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <remarks>
    /// Message of a type of LogType.Assert is logged.
    /// </remarks>
    /// <param name="condition">
    /// Condition you expect to be true.
    /// </param>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Assert(Boolean condition, object message)
    {
        UnityEngine.Debug.Assert(condition, message);
    }

    /// <summary>
    /// Assert a condition and logs an error message to the Unity console on failure.
    /// </summary>
    /// <remarks>
    /// Message of a type of LogType.Assert is logged.
    /// </remarks>
    /// <param name="condition">
    /// Condition you expect to be true.
    /// </param>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Assert(Boolean condition, object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Assert(condition, message, context);
    }

    /// <summary>
    /// Assert a condition and logs a formatted error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">
    /// Condition you expect to be true.
    /// </param>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, format, args);
    }

    /// <summary>
    /// Assert a condition and logs a formatted error message to the Unity console on failure.
    /// </summary>
    /// <param name="condition">
    /// Condition you expect to be true.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void AssertFormat(bool condition, UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.AssertFormat(condition, context, format, args);
    }

    /// <summary>
    /// Pauses the editor.
    /// </summary>
    /// <remarks>
    /// This is useful when you want to check certain values on the inspector and you are not
    /// able to pause it manually.
    /// </remarks>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Break()
    {
        UnityEngine.Debug.Break();
    }

    /// <summary>
    /// Clears errors from the developer console.
    /// </summary>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void ClearDeveloperConsole()
    {
        UnityEngine.Debug.ClearDeveloperConsole();
    }

    /// <summary>
    /// Draws a line between specified start and end points.
    /// </summary>
    /// <remarks>
    /// The line will be drawn in the scene view of the editor. If gizmo drawing is enabled in
    /// the game view, the line will also be drawn there. The duration is the time (in seconds)
    /// for which the line will be visible after it is first displayed. A duration of zero shows
    /// the line for just one frame.
    ///
    /// Note: This is for debugging playmode only. Editor gizmos should be drawn with
    ///       Gizmos.Drawline or Handles.DrawLine instead.
    /// </remarks>
    /// <param name="start">
    /// Point in world space where the line should start.
    /// </param>
    /// <param name="end">
    /// Point in world space where the line should end.
    /// </param>
    /// <param name="color">
    /// Color of the line.
    /// </param>
    /// <param name="duration">
    /// How long the line should be visible for.
    /// </param>
    /// <param name="depthTest">
    /// Should the line be obscured by objects closer to the camera?
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration = 0.0f, bool depthTest = true)
    {
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
    }

    /// <summary>
    /// Draws a line from start to start + dir in world coordinates.
    /// </summary>
    /// <remarks>
    /// The duration parameter determines how long the line will be visible after the frame it is
    /// drawn. If duration is 0 (the default) then the line is rendered 1 frame.
    ///
    /// If depthTest is set to true then the line will be obscured by other objects in the scene
    /// that are nearer to the camera.
    ///
    /// The line will be drawn in the scene view of the editor. If gizmo drawing is enabled in
    /// the game view, the line will also be drawn there.
    /// </remarks>
    /// <param name="start">
    /// Point in world space where the ray should start.
    /// </param>
    /// <param name="dir">
    /// Direction and length of the ray.
    /// </param>
    /// <param name="color">
    /// Color of the drawn line.
    /// </param>
    /// <param name="duration">
    /// How long the line will be visible for (in seconds).
    /// </param>
    /// <param name="depthTest">
    /// Should the line be obscured by other objects closer to the camera?
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration = 0.0f, bool depthTest = true)
    {
        UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
    }

    /// <summary>
    /// Logs message to the Unity Console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This can be useful for locating the object on which an error occurs.
    ///
    /// When the message is a string, rich text markup can be used to add emphasis. See the
    /// manual page about rich text for details of the different markup tags available.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Log(object message)
    {
        UnityEngine.Debug.Log(message);
    }

    /// <summary>
    /// Logs message to the Unity Console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This can be useful for locating the object on which an error occurs.
    ///
    /// When the message is a string, rich text markup can be used to add emphasis. See the
    /// manual page about rich text for details of the different markup tags available.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void Log(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.Log(message, context);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an assertion message to the console.
    /// </summary>
    /// <remarks>
    /// Message of a type of LogType.Assert is logged.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogAssertion(object message)
    {
        UnityEngine.Debug.LogAssertion(message);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an assertion message to the console.
    /// </summary>
    /// <remarks>
    /// Message of a type of LogType.Assert is logged.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogAssertion(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogAssertion(message, context);
    }

    /// <summary>
    /// Logs a formatted assertion message to the Unity console.
    /// </summary>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogAssertionFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogAssertionFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted assertion message to the Unity console.
    /// </summary>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogAssertionFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogAssertionFormat(context, format, args);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This is very useful if you want know on which object an error occurs.
    ///
    /// When the message is a string, rich text markup can be used to add emphasis. See the
    /// manual page about rich text for details of the different markup tags available.
    ///
    /// Note that this pauses the editor when 'ErrorPause' is enabled.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogError(object message)
    {
        UnityEngine.Debug.LogError(message);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This is very useful if you want know on which object an error occurs.
    ///
    /// When the message is a string, rich text markup can be used to add emphasis. See the
    /// manual page about rich text for details of the different markup tags available.
    ///
    /// Note that this pauses the editor when 'ErrorPause' is enabled.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogError(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogError(message, context);
    }

    /// <summary>
    /// Logs a formatted error message to the Unity console.
    /// </summary>
    /// <remarks>
    /// For formatting details, see the MSDN documentation on Composite Formatting. Rich text
    /// markup can be used to add emphasis. See the manual page about rich text for details of
    /// the different markup tags available.
    /// </remarks>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogErrorFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted error message to the Unity console.
    /// </summary>
    /// <remarks>
    /// For formatting details, see the MSDN documentation on Composite Formatting. Rich text
    /// markup can be used to add emphasis. See the manual page about rich text for details of
    /// the different markup tags available.
    /// </remarks>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogErrorFormat(context, format, args);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This is very useful if you want know on which object an error occurs.
    ///
    /// Note that this pauses the editor when 'ErrorPause' is enabled.
    /// </remarks>
    /// <param name="exception">
    /// Runtime Exception.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogException(Exception exception)
    {
        UnityEngine.Debug.LogException(exception);
    }

    /// <summary>
    /// A variant of Debug.Log that logs an error message to the console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This is very useful if you want know on which object an error occurs.
    ///
    /// Note that this pauses the editor when 'ErrorPause' is enabled.
    /// </remarks>
    /// <param name="exception">
    /// Runtime Exception.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogException(Exception exception, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogException(exception, context);
    }

    /// <summary>
    /// Logs a formatted message to the Unity Console.
    /// </summary>
    /// <remarks>
    /// For formatting details, see the MSDN documentation on Composite Formatting. Rich text
    /// markup can be used to add emphasis. See the manual page about rich text for details of
    /// the different markup tags available.
    /// </remarks>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted message to the Unity Console.
    /// </summary>
    /// <remarks>
    /// For formatting details, see the MSDN documentation on Composite Formatting. Rich text
    /// markup can be used to add emphasis. See the manual page about rich text for details of
    /// the different markup tags available.
    /// </remarks>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogFormat(context, format, args);
    }

    /// <summary>
    /// A variant of Debug.Log that logs a warning message to the console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This is very useful if you want know on which object a warning occurs.
    ///
    /// When the message is a string, rich text markup can be used to add emphasis. See the
    /// manual page about rich text for details of the different markup tags available.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogWarning(object message)
    {
        UnityEngine.Debug.LogWarning(message);
    }

    /// <summary>
    /// A variant of Debug.Log that logs a warning message to the console.
    /// </summary>
    /// <remarks>
    /// When you select the message in the console a connection to the context object will be
    /// drawn. This is very useful if you want know on which object a warning occurs.
    ///
    /// When the message is a string, rich text markup can be used to add emphasis. See the
    /// manual page about rich text for details of the different markup tags available.
    /// </remarks>
    /// <param name="message">
    /// String or object to be converted to string representation for display.
    /// </param>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogWarning(object message, UnityEngine.Object context)
    {
        UnityEngine.Debug.LogWarning(message, context);
    }

    /// <summary>
    /// Logs a formatted warning message to the Unity Console.
    /// </summary>
    /// <remarks>
    /// For formatting details, see the MSDN documentation on Composite Formatting. Rich text
    /// markup can be used to add emphasis. See the manual page about rich text for details of
    /// the different markup tags available.
    /// </remarks>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogWarningFormat(string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(format, args);
    }

    /// <summary>
    /// Logs a formatted warning message to the Unity Console.
    /// </summary>
    /// <remarks>
    /// For formatting details, see the MSDN documentation on Composite Formatting. Rich text
    /// markup can be used to add emphasis. See the manual page about rich text for details of
    /// the different markup tags available.
    /// </remarks>
    /// <param name="context">
    /// Object to which the message applies.
    /// </param>
    /// <param name="format">
    /// A composite format string.
    /// </param>
    /// <param name="args">
    /// Format arguments.
    /// </param>
    [Conditional(DEBUG_CONDITIONAL)]
    public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
    {
        UnityEngine.Debug.LogWarningFormat(context, format, args);
    }
}