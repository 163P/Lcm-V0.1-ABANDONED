/*
* MATLAB Compiler: 4.17 (R2012a)
* Date: Fri May 27 22:31:07 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:LcmNetDllV1,AddClass,0.0,private" "-T"
* "link:lib" "-d" "E:\LcmNetDllV1\LcmNetDllV1\src" "-w" "enable:specified_file_mismatch"
* "-w" "enable:repeated_file" "-w" "enable:switch_ignored" "-w"
* "enable:missing_lib_sentinel" "-w" "enable:demo_license" "-v"
* "class{AddClass:E:\LcmNetDllV1\Add\Add.m,E:\LcmNetDllV1\Add\Add2.m,E:\LcmNetDllV1\Add\ma
* t_add.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace LcmNetDllV1Native
{

  /// <summary>
  /// The AddClass class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Add\Add.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Add\Add2.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Add\mat_add.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class AddClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static AddClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "LcmNetDllV1.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the AddClass class.
    /// </summary>
    public AddClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~AddClass()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add()
    {
      return mcr.EvaluateFunction("Add", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="wavfile1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add(Object wavfile1)
    {
      return mcr.EvaluateFunction("Add", wavfile1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="wavfile1">Input argument #1</param>
    /// <param name="wavfile2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add(Object wavfile1, Object wavfile2)
    {
      return mcr.EvaluateFunction("Add", wavfile1, wavfile2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="wavfile1">Input argument #1</param>
    /// <param name="wavfile2">Input argument #2</param>
    /// <param name="ofn">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add(Object wavfile1, Object wavfile2, Object ofn)
    {
      return mcr.EvaluateFunction("Add", wavfile1, wavfile2, ofn);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wavfile1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add(int numArgsOut, Object wavfile1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add", wavfile1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wavfile1">Input argument #1</param>
    /// <param name="wavfile2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add(int numArgsOut, Object wavfile1, Object wavfile2)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add", wavfile1, wavfile2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the Add M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wavfile1">Input argument #1</param>
    /// <param name="wavfile2">Input argument #2</param>
    /// <param name="ofn">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add(int numArgsOut, Object wavfile1, Object wavfile2, Object ofn)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add", wavfile1, wavfile2, ofn);
    }


    /// <summary>
    /// Provides an interface for the Add function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// C = C(logical(C));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Add", 3, 1, 0)]
    protected void Add(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Add", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add2()
    {
      return mcr.EvaluateFunction("Add2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="f1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add2(Object f1)
    {
      return mcr.EvaluateFunction("Add2", f1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="f1">Input argument #1</param>
    /// <param name="f2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add2(Object f1, Object f2)
    {
      return mcr.EvaluateFunction("Add2", f1, f2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="f1">Input argument #1</param>
    /// <param name="f2">Input argument #2</param>
    /// <param name="ofn">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add2(Object f1, Object f2, Object ofn)
    {
      return mcr.EvaluateFunction("Add2", f1, f2, ofn);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="f1">Input argument #1</param>
    /// <param name="f2">Input argument #2</param>
    /// <param name="ofn">Input argument #3</param>
    /// <param name="fenshu">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Add2(Object f1, Object f2, Object ofn, Object fenshu)
    {
      return mcr.EvaluateFunction("Add2", f1, f2, ofn, fenshu);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add2(int numArgsOut, Object f1)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add2", f1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f1">Input argument #1</param>
    /// <param name="f2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add2(int numArgsOut, Object f1, Object f2)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add2", f1, f2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f1">Input argument #1</param>
    /// <param name="f2">Input argument #2</param>
    /// <param name="ofn">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add2(int numArgsOut, Object f1, Object f2, Object ofn)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add2", f1, f2, ofn);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the Add2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="f1">Input argument #1</param>
    /// <param name="f2">Input argument #2</param>
    /// <param name="ofn">Input argument #3</param>
    /// <param name="fenshu">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Add2(int numArgsOut, Object f1, Object f2, Object ofn, Object fenshu)
    {
      return mcr.EvaluateFunction(numArgsOut, "Add2", f1, f2, ofn, fenshu);
    }


    /// <summary>
    /// Provides an interface for the Add2 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// a=a(:);
    /// a=real(a);
    /// a=a/max(a);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Add2", 4, 1, 0)]
    protected void Add2(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Add2", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mat_add()
    {
      return mcr.EvaluateFunction("mat_add", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mat_add(Object x1)
    {
      return mcr.EvaluateFunction("mat_add", x1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <param name="n1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mat_add(Object x1, Object n1)
    {
      return mcr.EvaluateFunction("mat_add", x1, n1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <param name="n1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mat_add(Object x1, Object n1, Object x2)
    {
      return mcr.EvaluateFunction("mat_add", x1, n1, x2);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x1">Input argument #1</param>
    /// <param name="n1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <param name="n2">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mat_add(Object x1, Object n1, Object x2, Object n2)
    {
      return mcr.EvaluateFunction("mat_add", x1, n1, x2, n2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mat_add(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mat_add", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mat_add(int numArgsOut, Object x1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mat_add", x1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <param name="n1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mat_add(int numArgsOut, Object x1, Object n1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mat_add", x1, n1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <param name="n1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mat_add(int numArgsOut, Object x1, Object n1, Object x2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mat_add", x1, n1, x2);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the mat_add M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x1">Input argument #1</param>
    /// <param name="n1">Input argument #2</param>
    /// <param name="x2">Input argument #3</param>
    /// <param name="n2">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mat_add(int numArgsOut, Object x1, Object n1, Object x2, Object n2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mat_add", x1, n1, x2, n2);
    }


    /// <summary>
    /// Provides an interface for the mat_add function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("mat_add", 4, 2, 0)]
    protected void mat_add(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("mat_add", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
