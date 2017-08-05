/*
* MATLAB Compiler: 4.17 (R2012a)
* Date: Fri May 27 22:08:18 2016
* Arguments: "-B" "macro_default" "-W"
* "dotnet:LcmNetDllV1,LengthOfSoundChangeClass,0.0,private" "-T" "link:lib" "-d"
* "E:\LcmNetDllV1\LcmNetDllV1\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v"
* "class{LengthOfSoundChangeClass:E:\LcmNetDllV1\LengthOfSoundChange\fade_in.m,E:\LcmNetDl
* lV1\LengthOfSoundChange\fade_out.m,E:\LcmNetDllV1\LengthOfSoundChange\LengthChange.m,E:\
* LcmNetDllV1\LengthOfSoundChange\LengthOfSoundChange.m,E:\LcmNetDllV1\LengthOfSoundChange
* \VBOUT.m}"
* "class{AddClass:E:\LcmNetDllV1\Add\Add.m,E:\LcmNetDllV1\Add\Add2.m,E:\LcmNetDllV1\Add\ma
* t_add.m}"
* "class{PitchClass:E:\LcmNetDllV1\Pitch\CenterClipping.m,E:\LcmNetDllV1\Pitch\FindPeakCan
* didates.m,E:\LcmNetDllV1\Pitch\IncreaseMarking.m,E:\LcmNetDllV1\Pitch\LowPassFilter.m,E:
* \LcmNetDllV1\Pitch\Pitch.m,E:\LcmNetDllV1\Pitch\PitchDetection.m,E:\LcmNetDllV1\Pitch\Pi
* tchEstimation.m,E:\LcmNetDllV1\Pitch\PitchMarking1.m,E:\LcmNetDllV1\Pitch\PlotPitchMarks
* .m,E:\LcmNetDllV1\Pitch\psola1.m,E:\LcmNetDllV1\Pitch\UnvoicedMod.m,E:\LcmNetDllV1\Pitch
* \UVSplit.m,E:\LcmNetDllV1\Pitch\VoicedSegmentMarking.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

namespace LcmNetDllV1Native
{

  /// <summary>
  /// The PitchClass class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\CenterClipping.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\FindPeakCandidates.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\IncreaseMarking.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\LowPassFilter.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\Pitch.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\PitchDetection.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\PitchEstimation.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\PitchMarking1.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\PlotPitchMarks.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\psola1.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\UnvoicedMod.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\UVSplit.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\Pitch\VoicedSegmentMarking.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PitchClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static PitchClass()
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
    /// Constructs a new instance of the PitchClass class.
    /// </summary>
    public PitchClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PitchClass()
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
    /// Provides a single output, 0-input Objectinterface to the CenterClipping
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CenterClipping()
    {
      return mcr.EvaluateFunction("CenterClipping", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the CenterClipping
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CenterClipping(Object x)
    {
      return mcr.EvaluateFunction("CenterClipping", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the CenterClipping
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Percentage">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CenterClipping(Object x, Object Percentage)
    {
      return mcr.EvaluateFunction("CenterClipping", x, Percentage);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the CenterClipping M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CenterClipping(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CenterClipping", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the CenterClipping M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CenterClipping(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CenterClipping", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the CenterClipping M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Percentage">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CenterClipping(int numArgsOut, Object x, Object Percentage)
    {
      return mcr.EvaluateFunction(numArgsOut, "CenterClipping", x, Percentage);
    }


    /// <summary>
    /// Provides an interface for the CenterClipping function in which the input and
    /// output
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
    [MATLABSignature("CenterClipping", 2, 2, 0)]
    protected void CenterClipping(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("CenterClipping", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object FindPeakCandidates()
    {
      return mcr.EvaluateFunction("FindPeakCandidates", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object FindPeakCandidates(Object x)
    {
      return mcr.EvaluateFunction("FindPeakCandidates", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="MaxCandidateNumber">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object FindPeakCandidates(Object x, Object MaxCandidateNumber)
    {
      return mcr.EvaluateFunction("FindPeakCandidates", x, MaxCandidateNumber);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="MaxCandidateNumber">Input argument #2</param>
    /// <param name="Offset">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object FindPeakCandidates(Object x, Object MaxCandidateNumber, Object Offset)
    {
      return mcr.EvaluateFunction("FindPeakCandidates", x, MaxCandidateNumber, Offset);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] FindPeakCandidates(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] FindPeakCandidates(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="MaxCandidateNumber">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] FindPeakCandidates(int numArgsOut, Object x, Object 
                                 MaxCandidateNumber)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", x, MaxCandidateNumber);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="MaxCandidateNumber">Input argument #2</param>
    /// <param name="Offset">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] FindPeakCandidates(int numArgsOut, Object x, Object 
                                 MaxCandidateNumber, Object Offset)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", x, MaxCandidateNumber, Offset);
    }


    /// <summary>
    /// Provides an interface for the FindPeakCandidates function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("FindPeakCandidates", 3, 1, 0)]
    protected void FindPeakCandidates(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("FindPeakCandidates", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object IncreaseMarking()
    {
      return mcr.EvaluateFunction("IncreaseMarking", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object IncreaseMarking(Object x)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object IncreaseMarking(Object x, Object p)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x, p);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object IncreaseMarking(Object x, Object p, Object fs)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x, p, fs);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <param name="m">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object IncreaseMarking(Object x, Object p, Object fs, Object m)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x, p, fs, m);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the IncreaseMarking M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] IncreaseMarking(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the IncreaseMarking M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] IncreaseMarking(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the IncreaseMarking M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] IncreaseMarking(int numArgsOut, Object x, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x, p);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the IncreaseMarking M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] IncreaseMarking(int numArgsOut, Object x, Object p, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x, p, fs);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the IncreaseMarking M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <param name="m">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] IncreaseMarking(int numArgsOut, Object x, Object p, Object fs, Object 
                              m)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x, p, fs, m);
    }


    /// <summary>
    /// Provides an interface for the IncreaseMarking function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("IncreaseMarking", 4, 1, 0)]
    protected void IncreaseMarking(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("IncreaseMarking", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LowPassFilter()
    {
      return mcr.EvaluateFunction("LowPassFilter", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LowPassFilter(Object x)
    {
      return mcr.EvaluateFunction("LowPassFilter", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LowPassFilter(Object x, Object Fs)
    {
      return mcr.EvaluateFunction("LowPassFilter", x, Fs);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <param name="Fc">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LowPassFilter(Object x, Object Fs, Object Fc)
    {
      return mcr.EvaluateFunction("LowPassFilter", x, Fs, Fc);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LowPassFilter(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LowPassFilter(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LowPassFilter(int numArgsOut, Object x, Object Fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", x, Fs);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <param name="Fc">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LowPassFilter(int numArgsOut, Object x, Object Fs, Object Fc)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", x, Fs, Fc);
    }


    /// <summary>
    /// Provides an interface for the LowPassFilter function in which the input and
    /// output
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
    [MATLABSignature("LowPassFilter", 3, 2, 0)]
    protected void LowPassFilter(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("LowPassFilter", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Pitch()
    {
      return mcr.EvaluateFunction("Pitch", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="Fdir">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Pitch(Object Fdir)
    {
      return mcr.EvaluateFunction("Pitch", Fdir);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Pitch(Object Fdir, Object Fname)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <param name="oFname">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Pitch(Object Fdir, Object Fname, Object oFname)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname, oFname);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <param name="oFname">Input argument #3</param>
    /// <param name="pitchs">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Pitch(Object Fdir, Object Fname, Object oFname, Object pitchs)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname, oFname, pitchs);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <param name="oFname">Input argument #3</param>
    /// <param name="pitchs">Input argument #4</param>
    /// <param name="times">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Pitch(Object Fdir, Object Fname, Object oFname, Object pitchs, Object 
                  times)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname, oFname, pitchs, times);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Pitch(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Fdir">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Pitch(int numArgsOut, Object Fdir)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Pitch(int numArgsOut, Object Fdir, Object Fname)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <param name="oFname">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Pitch(int numArgsOut, Object Fdir, Object Fname, Object oFname)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname, oFname);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <param name="oFname">Input argument #3</param>
    /// <param name="pitchs">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Pitch(int numArgsOut, Object Fdir, Object Fname, Object oFname, 
                    Object pitchs)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname, oFname, pitchs);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Fdir">Input argument #1</param>
    /// <param name="Fname">Input argument #2</param>
    /// <param name="oFname">Input argument #3</param>
    /// <param name="pitchs">Input argument #4</param>
    /// <param name="times">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Pitch(int numArgsOut, Object Fdir, Object Fname, Object oFname, 
                    Object pitchs, Object times)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname, oFname, pitchs, times);
    }


    /// <summary>
    /// Provides an interface for the Pitch function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Pitch", 5, 1, 0)]
    protected void Pitch(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Pitch", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PitchDetection
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchDetection()
    {
      return mcr.EvaluateFunction("PitchDetection", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PitchDetection
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchDetection(Object x)
    {
      return mcr.EvaluateFunction("PitchDetection", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PitchDetection
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchDetection(Object x, Object fs)
    {
      return mcr.EvaluateFunction("PitchDetection", x, fs);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PitchDetection M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchDetection(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchDetection", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PitchDetection M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchDetection(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchDetection", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PitchDetection M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchDetection(int numArgsOut, Object x, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchDetection", x, fs);
    }


    /// <summary>
    /// Provides an interface for the PitchDetection function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PitchDetection", 2, 1, 0)]
    protected void PitchDetection(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PitchDetection", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchEstimation()
    {
      return mcr.EvaluateFunction("PitchEstimation", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchEstimation(Object x)
    {
      return mcr.EvaluateFunction("PitchEstimation", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchEstimation(Object x, Object fs)
    {
      return mcr.EvaluateFunction("PitchEstimation", x, fs);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PitchEstimation M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchEstimation(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchEstimation", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PitchEstimation M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchEstimation(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchEstimation", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PitchEstimation M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchEstimation(int numArgsOut, Object x, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchEstimation", x, fs);
    }


    /// <summary>
    /// Provides an interface for the PitchEstimation function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PitchEstimation", 2, 1, 0)]
    protected void PitchEstimation(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PitchEstimation", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchMarking1()
    {
      return mcr.EvaluateFunction("PitchMarking1", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchMarking1(Object x)
    {
      return mcr.EvaluateFunction("PitchMarking1", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchMarking1(Object x, Object p)
    {
      return mcr.EvaluateFunction("PitchMarking1", x, p);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PitchMarking1(Object x, Object p, Object fs)
    {
      return mcr.EvaluateFunction("PitchMarking1", x, p, fs);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PitchMarking1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchMarking1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PitchMarking1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchMarking1(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PitchMarking1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchMarking1(int numArgsOut, Object x, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", x, p);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PitchMarking1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PitchMarking1(int numArgsOut, Object x, Object p, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", x, p, fs);
    }


    /// <summary>
    /// Provides an interface for the PitchMarking1 function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PitchMarking1", 3, 1, 0)]
    protected void PitchMarking1(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PitchMarking1", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    ///
    public void PlotPitchMarks()
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    ///
    public void PlotPitchMarks(Object s)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    ///
    public void PlotPitchMarks(Object s, Object ca)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s, ca);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    /// <param name="pm">Input argument #3</param>
    ///
    public void PlotPitchMarks(Object s, Object ca, Object pm)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s, ca, pm);
    }


    /// <summary>
    /// Provides a void output, 4-input Objectinterface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    /// <param name="pm">Input argument #3</param>
    /// <param name="p">Input argument #4</param>
    ///
    public void PlotPitchMarks(Object s, Object ca, Object pm, Object p)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s, ca, pm, p);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotPitchMarks(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotPitchMarks(int numArgsOut, Object s)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotPitchMarks(int numArgsOut, Object s, Object ca)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s, ca);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    /// <param name="pm">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotPitchMarks(int numArgsOut, Object s, Object ca, Object pm)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s, ca, pm);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    /// <param name="pm">Input argument #3</param>
    /// <param name="p">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PlotPitchMarks(int numArgsOut, Object s, Object ca, Object pm, Object 
                             p)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s, ca, pm, p);
    }


    /// <summary>
    /// Provides an interface for the PlotPitchMarks function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PlotPitchMarks", 4, 0, 0)]
    protected void PlotPitchMarks(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PlotPitchMarks", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psola1()
    {
      return mcr.EvaluateFunction("psola1", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psola1(Object input)
    {
      return mcr.EvaluateFunction("psola1", input);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psola1(Object input, Object fs)
    {
      return mcr.EvaluateFunction("psola1", input, fs);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psola1(Object input, Object fs, Object anaPm)
    {
      return mcr.EvaluateFunction("psola1", input, fs, anaPm);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <param name="timeScale">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psola1(Object input, Object fs, Object anaPm, Object timeScale)
    {
      return mcr.EvaluateFunction("psola1", input, fs, anaPm, timeScale);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <param name="timeScale">Input argument #4</param>
    /// <param name="pitchScale">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psola1(Object input, Object fs, Object anaPm, Object timeScale, Object 
                   pitchScale)
    {
      return mcr.EvaluateFunction("psola1", input, fs, anaPm, timeScale, pitchScale);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psola1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psola1(int numArgsOut, Object input)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psola1(int numArgsOut, Object input, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psola1(int numArgsOut, Object input, Object fs, Object anaPm)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs, anaPm);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <param name="timeScale">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psola1(int numArgsOut, Object input, Object fs, Object anaPm, Object 
                     timeScale)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs, anaPm, timeScale);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <param name="timeScale">Input argument #4</param>
    /// <param name="pitchScale">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psola1(int numArgsOut, Object input, Object fs, Object anaPm, Object 
                     timeScale, Object pitchScale)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs, anaPm, timeScale, pitchScale);
    }


    /// <summary>
    /// Provides an interface for the psola1 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("psola1", 5, 1, 0)]
    protected void psola1(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("psola1", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object UnvoicedMod()
    {
      return mcr.EvaluateFunction("UnvoicedMod", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object UnvoicedMod(Object input)
    {
      return mcr.EvaluateFunction("UnvoicedMod", input);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object UnvoicedMod(Object input, Object fs)
    {
      return mcr.EvaluateFunction("UnvoicedMod", input, fs);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object UnvoicedMod(Object input, Object fs, Object alpha)
    {
      return mcr.EvaluateFunction("UnvoicedMod", input, fs, alpha);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] UnvoicedMod(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] UnvoicedMod(int numArgsOut, Object input)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", input);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] UnvoicedMod(int numArgsOut, Object input, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", input, fs);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] UnvoicedMod(int numArgsOut, Object input, Object fs, Object alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", input, fs, alpha);
    }


    /// <summary>
    /// Provides an interface for the UnvoicedMod function in which the input and output
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
    [MATLABSignature("UnvoicedMod", 3, 1, 0)]
    protected void UnvoicedMod(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("UnvoicedMod", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object UVSplit()
    {
      return mcr.EvaluateFunction("UVSplit", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object UVSplit(Object p)
    {
      return mcr.EvaluateFunction("UVSplit", p);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] UVSplit(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "UVSplit", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] UVSplit(int numArgsOut, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "UVSplit", p);
    }


    /// <summary>
    /// Provides an interface for the UVSplit function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("UVSplit", 1, 2, 0)]
    protected void UVSplit(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("UVSplit", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VoicedSegmentMarking()
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VoicedSegmentMarking(Object x)
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VoicedSegmentMarking(Object x, Object p)
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", x, p);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VoicedSegmentMarking(Object x, Object p, Object fs)
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", x, p, fs);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VoicedSegmentMarking(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VoicedSegmentMarking(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VoicedSegmentMarking(int numArgsOut, Object x, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", x, p);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VoicedSegmentMarking(int numArgsOut, Object x, Object p, Object fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", x, p, fs);
    }


    /// <summary>
    /// Provides an interface for the VoicedSegmentMarking function in which the input
    /// and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("VoicedSegmentMarking", 3, 2, 0)]
    protected void VoicedSegmentMarking(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("VoicedSegmentMarking", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
