/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Wed Oct 01 23:45:32 2014
* Arguments: "-B" "macro_default" "-W"
* "dotnet:LcmNetDllV1,LengthOfSoundChangeClass,0.0,private" "-T" "link:lib" "-d"
* "D:\..matlab\LcmNetDllV1\LcmNetDllV1\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v"
* "class{LengthOfSoundChangeClass:D:\..matlab\LcmNetDllV1\LengthOfSoundChange\LengthChange
* .m,D:\..matlab\LcmNetDllV1\LengthOfSoundChange\LengthOfSoundChange.m}"
* "class{AddClass:D:\..matlab\LcmNetDllV1\Add\Add.m,D:\..matlab\LcmNetDllV1\Add\Add2.m,E:\
* Program
* Files\MATLAB\R2010b\bin\mat_add.m,D:\..matlab\LcmNetDllV1\Add\NAdd.m,D:\..matlab\LcmNetD
* llV1\Add\NAdd2.m,D:\..matlab\LcmNetDllV1\Add\NAdd3.m}"
* "class{PitchClass:D:\..matlab\LcmNetDllV1\Pitch\CenterClipping.m,D:\..matlab\LcmNetDllV1
* \Pitch\FindPeakCandidates.m,D:\..matlab\LcmNetDllV1\Pitch\IncreaseMarking.m,D:\..matlab\
* LcmNetDllV1\Pitch\LowPassFilter.m,D:\..matlab\LcmNetDllV1\Pitch\Pitch.m,D:\..matlab\LcmN
* etDllV1\Pitch\PitchDetection.m,D:\..matlab\LcmNetDllV1\Pitch\PitchEstimation.m,D:\..matl
* ab\LcmNetDllV1\Pitch\PitchMarking1.m,D:\..matlab\LcmNetDllV1\Pitch\PlotPitchMarks.m,D:\.
* .matlab\LcmNetDllV1\Pitch\psola1.m,D:\..matlab\LcmNetDllV1\Pitch\UnvoicedMod.m,D:\..matl
* ab\LcmNetDllV1\Pitch\UVSplit.m,D:\..matlab\LcmNetDllV1\Pitch\VoicedSegmentMarking.m}"
* "class{Wave:D:\..matlab\LcmNetDllV1\Wave\ReadWav.m,D:\..matlab\LcmNetDllV1\Wave\WriteWav
* .m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

namespace LcmNetDllV1Native
{
  /// <summary>
  /// The Wave class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\..matlab\LcmNetDllV1\Wave\ReadWav.m
  /// <newpara></newpara>
  /// D:\..matlab\LcmNetDllV1\Wave\WriteWav.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Wave : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Wave()
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
    /// Constructs a new instance of the Wave class.
    /// </summary>
    public Wave()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Wave()
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
    /// Provides a single output, 0-input Objectinterface to the ReadWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ReadWav()
    {
      return mcr.EvaluateFunction("ReadWav", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the ReadWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ReadWav(Object filename)
    {
      return mcr.EvaluateFunction("ReadWav", filename);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the ReadWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ReadWav(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ReadWav", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the ReadWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ReadWav(int numArgsOut, Object filename)
    {
      return mcr.EvaluateFunction(numArgsOut, "ReadWav", filename);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object WriteWav()
    {
      return mcr.EvaluateFunction("WriteWav", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A_in1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object WriteWav(Object A_in1)
    {
      return mcr.EvaluateFunction("WriteWav", A_in1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A_in1">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object WriteWav(Object A_in1, Object Fs)
    {
      return mcr.EvaluateFunction("WriteWav", A_in1, Fs);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A_in1">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <param name="filename">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object WriteWav(Object A_in1, Object Fs, Object filename)
    {
      return mcr.EvaluateFunction("WriteWav", A_in1, Fs, filename);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] WriteWav(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "WriteWav", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A_in1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] WriteWav(int numArgsOut, Object A_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "WriteWav", A_in1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A_in1">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] WriteWav(int numArgsOut, Object A_in1, Object Fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "WriteWav", A_in1, Fs);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the WriteWav M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A_in1">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <param name="filename">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] WriteWav(int numArgsOut, Object A_in1, Object Fs, Object filename)
    {
      return mcr.EvaluateFunction(numArgsOut, "WriteWav", A_in1, Fs, filename);
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
