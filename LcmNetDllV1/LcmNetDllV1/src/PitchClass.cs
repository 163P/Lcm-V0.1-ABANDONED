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

namespace LcmNetDllV1
{

  /// <summary>
  /// The PitchClass class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
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
    /// Provides a single output, 0-input MWArrayinterface to the CenterClipping
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray CenterClipping()
    {
      return mcr.EvaluateFunction("CenterClipping", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the CenterClipping
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray CenterClipping(MWArray x)
    {
      return mcr.EvaluateFunction("CenterClipping", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the CenterClipping
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Percentage">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray CenterClipping(MWArray x, MWArray Percentage)
    {
      return mcr.EvaluateFunction("CenterClipping", x, Percentage);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the CenterClipping M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CenterClipping(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CenterClipping", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the CenterClipping M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CenterClipping(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "CenterClipping", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the CenterClipping M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Percentage">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] CenterClipping(int numArgsOut, MWArray x, MWArray Percentage)
    {
      return mcr.EvaluateFunction(numArgsOut, "CenterClipping", x, Percentage);
    }


    /// <summary>
    /// Provides an interface for the CenterClipping function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void CenterClipping(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("CenterClipping", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindPeakCandidates()
    {
      return mcr.EvaluateFunction("FindPeakCandidates", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindPeakCandidates(MWArray x)
    {
      return mcr.EvaluateFunction("FindPeakCandidates", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="MaxCandidateNumber">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindPeakCandidates(MWArray x, MWArray MaxCandidateNumber)
    {
      return mcr.EvaluateFunction("FindPeakCandidates", x, MaxCandidateNumber);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the FindPeakCandidates
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="MaxCandidateNumber">Input argument #2</param>
    /// <param name="Offset">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FindPeakCandidates(MWArray x, MWArray MaxCandidateNumber, MWArray 
                                Offset)
    {
      return mcr.EvaluateFunction("FindPeakCandidates", x, MaxCandidateNumber, Offset);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the FindPeakCandidates
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
    public MWArray[] FindPeakCandidates(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the FindPeakCandidates
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
    public MWArray[] FindPeakCandidates(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the FindPeakCandidates
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
    public MWArray[] FindPeakCandidates(int numArgsOut, MWArray x, MWArray 
                                  MaxCandidateNumber)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", x, MaxCandidateNumber);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the FindPeakCandidates
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
    public MWArray[] FindPeakCandidates(int numArgsOut, MWArray x, MWArray 
                                  MaxCandidateNumber, MWArray Offset)
    {
      return mcr.EvaluateFunction(numArgsOut, "FindPeakCandidates", x, MaxCandidateNumber, Offset);
    }


    /// <summary>
    /// Provides an interface for the FindPeakCandidates function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// init
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void FindPeakCandidates(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("FindPeakCandidates", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray IncreaseMarking()
    {
      return mcr.EvaluateFunction("IncreaseMarking", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray IncreaseMarking(MWArray x)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the IncreaseMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray IncreaseMarking(MWArray x, MWArray p)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x, p);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the IncreaseMarking
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray IncreaseMarking(MWArray x, MWArray p, MWArray fs)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x, p, fs);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the IncreaseMarking
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray IncreaseMarking(MWArray x, MWArray p, MWArray fs, MWArray m)
    {
      return mcr.EvaluateFunction("IncreaseMarking", x, p, fs, m);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the IncreaseMarking
    /// M-function.
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
    public MWArray[] IncreaseMarking(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the IncreaseMarking
    /// M-function.
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
    public MWArray[] IncreaseMarking(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the IncreaseMarking
    /// M-function.
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
    public MWArray[] IncreaseMarking(int numArgsOut, MWArray x, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x, p);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the IncreaseMarking
    /// M-function.
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
    public MWArray[] IncreaseMarking(int numArgsOut, MWArray x, MWArray p, MWArray fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x, p, fs);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the IncreaseMarking
    /// M-function.
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
    public MWArray[] IncreaseMarking(int numArgsOut, MWArray x, MWArray p, MWArray fs, 
                               MWArray m)
    {
      return mcr.EvaluateFunction(numArgsOut, "IncreaseMarking", x, p, fs, m);
    }


    /// <summary>
    /// Provides an interface for the IncreaseMarking function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// for each search regions
    /// find m pitch mark candidates
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void IncreaseMarking(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("IncreaseMarking", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LowPassFilter()
    {
      return mcr.EvaluateFunction("LowPassFilter", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LowPassFilter(MWArray x)
    {
      return mcr.EvaluateFunction("LowPassFilter", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LowPassFilter(MWArray x, MWArray Fs)
    {
      return mcr.EvaluateFunction("LowPassFilter", x, Fs);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the LowPassFilter
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <param name="Fc">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LowPassFilter(MWArray x, MWArray Fs, MWArray Fc)
    {
      return mcr.EvaluateFunction("LowPassFilter", x, Fs, Fc);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LowPassFilter(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LowPassFilter(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the LowPassFilter M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LowPassFilter(int numArgsOut, MWArray x, MWArray Fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", x, Fs);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the LowPassFilter M-function.
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
    public MWArray[] LowPassFilter(int numArgsOut, MWArray x, MWArray Fs, MWArray Fc)
    {
      return mcr.EvaluateFunction(numArgsOut, "LowPassFilter", x, Fs, Fc);
    }


    /// <summary>
    /// Provides an interface for the LowPassFilter function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void LowPassFilter(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("LowPassFilter", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Pitch()
    {
      return mcr.EvaluateFunction("Pitch", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the Pitch M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// if isempty(xx(logical(xx)))=1;               判断是否为R（静音文件）
    /// wavwrite(xx,fs,oFname);
    /// return
    /// end; 
    /// </remarks>
    /// <param name="Fdir">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Pitch(MWArray Fdir)
    {
      return mcr.EvaluateFunction("Pitch", Fdir);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the Pitch M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Pitch(MWArray Fdir, MWArray Fname)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the Pitch M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Pitch(MWArray Fdir, MWArray Fname, MWArray oFname)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname, oFname);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the Pitch M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Pitch(MWArray Fdir, MWArray Fname, MWArray oFname, MWArray pitchs)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname, oFname, pitchs);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the Pitch M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray Pitch(MWArray Fdir, MWArray Fname, MWArray oFname, MWArray pitchs, 
                   MWArray times)
    {
      return mcr.EvaluateFunction("Pitch", Fdir, Fname, oFname, pitchs, times);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the Pitch M-function.
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
    public MWArray[] Pitch(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the Pitch M-function.
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
    public MWArray[] Pitch(int numArgsOut, MWArray Fdir)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the Pitch M-function.
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
    public MWArray[] Pitch(int numArgsOut, MWArray Fdir, MWArray Fname)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the Pitch M-function.
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
    public MWArray[] Pitch(int numArgsOut, MWArray Fdir, MWArray Fname, MWArray oFname)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname, oFname);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the Pitch M-function.
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
    public MWArray[] Pitch(int numArgsOut, MWArray Fdir, MWArray Fname, MWArray oFname, 
                     MWArray pitchs)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname, oFname, pitchs);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the Pitch M-function.
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
    public MWArray[] Pitch(int numArgsOut, MWArray Fdir, MWArray Fname, MWArray oFname, 
                     MWArray pitchs, MWArray times)
    {
      return mcr.EvaluateFunction(numArgsOut, "Pitch", Fdir, Fname, oFname, pitchs, times);
    }


    /// <summary>
    /// Provides an interface for the Pitch function in which the input and output
    /// arguments are specified as an array of MWArrays.
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
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void Pitch(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("Pitch", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PitchDetection
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchDetection()
    {
      return mcr.EvaluateFunction("PitchDetection", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PitchDetection
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchDetection(MWArray x)
    {
      return mcr.EvaluateFunction("PitchDetection", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PitchDetection
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchDetection(MWArray x, MWArray fs)
    {
      return mcr.EvaluateFunction("PitchDetection", x, fs);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PitchDetection M-function.
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
    public MWArray[] PitchDetection(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchDetection", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PitchDetection M-function.
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
    public MWArray[] PitchDetection(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchDetection", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PitchDetection M-function.
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
    public MWArray[] PitchDetection(int numArgsOut, MWArray x, MWArray fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchDetection", x, fs);
    }


    /// <summary>
    /// Provides an interface for the PitchDetection function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Detect pitch in a speech segment
    /// pitch = 0 for unvoiced segment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PitchDetection(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PitchDetection", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchEstimation()
    {
      return mcr.EvaluateFunction("PitchEstimation", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchEstimation(MWArray x)
    {
      return mcr.EvaluateFunction("PitchEstimation", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchEstimation(MWArray x, MWArray fs)
    {
      return mcr.EvaluateFunction("PitchEstimation", x, fs);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PitchEstimation
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PitchEstimation(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchEstimation", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PitchEstimation
    /// M-function.
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
    public MWArray[] PitchEstimation(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchEstimation", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PitchEstimation
    /// M-function.
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
    public MWArray[] PitchEstimation(int numArgsOut, MWArray x, MWArray fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchEstimation", x, fs);
    }


    /// <summary>
    /// Provides an interface for the PitchEstimation function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Init parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PitchEstimation(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PitchEstimation", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchMarking1()
    {
      return mcr.EvaluateFunction("PitchMarking1", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchMarking1(MWArray x)
    {
      return mcr.EvaluateFunction("PitchMarking1", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchMarking1(MWArray x, MWArray p)
    {
      return mcr.EvaluateFunction("PitchMarking1", x, p);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the PitchMarking1
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="p">Input argument #2</param>
    /// <param name="fs">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PitchMarking1(MWArray x, MWArray p, MWArray fs)
    {
      return mcr.EvaluateFunction("PitchMarking1", x, p, fs);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PitchMarking1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PitchMarking1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PitchMarking1 M-function.
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
    public MWArray[] PitchMarking1(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PitchMarking1 M-function.
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
    public MWArray[] PitchMarking1(int numArgsOut, MWArray x, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", x, p);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PitchMarking1 M-function.
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
    public MWArray[] PitchMarking1(int numArgsOut, MWArray x, MWArray p, MWArray fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "PitchMarking1", x, p, fs);
    }


    /// <summary>
    /// Provides an interface for the PitchMarking1 function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// split voiced / unvoiced segments
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PitchMarking1(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PitchMarking1", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the PlotPitchMarks
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    ///
    public void PlotPitchMarks()
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the PlotPitchMarks
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    ///
    public void PlotPitchMarks(MWArray s)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the PlotPitchMarks
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    ///
    public void PlotPitchMarks(MWArray s, MWArray ca)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s, ca);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the PlotPitchMarks
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="s">Input argument #1</param>
    /// <param name="ca">Input argument #2</param>
    /// <param name="pm">Input argument #3</param>
    ///
    public void PlotPitchMarks(MWArray s, MWArray ca, MWArray pm)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s, ca, pm);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the PlotPitchMarks
    /// M-function.
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
    public void PlotPitchMarks(MWArray s, MWArray ca, MWArray pm, MWArray p)
    {
      mcr.EvaluateFunction(0, "PlotPitchMarks", s, ca, pm, p);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PlotPitchMarks M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// normalization s and d
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PlotPitchMarks(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PlotPitchMarks M-function.
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
    public MWArray[] PlotPitchMarks(int numArgsOut, MWArray s)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PlotPitchMarks M-function.
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
    public MWArray[] PlotPitchMarks(int numArgsOut, MWArray s, MWArray ca)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s, ca);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PlotPitchMarks M-function.
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
    public MWArray[] PlotPitchMarks(int numArgsOut, MWArray s, MWArray ca, MWArray pm)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s, ca, pm);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the PlotPitchMarks M-function.
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
    public MWArray[] PlotPitchMarks(int numArgsOut, MWArray s, MWArray ca, MWArray pm, 
                              MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "PlotPitchMarks", s, ca, pm, p);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray psola1()
    {
      return mcr.EvaluateFunction("psola1", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray psola1(MWArray input)
    {
      return mcr.EvaluateFunction("psola1", input);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray psola1(MWArray input, MWArray fs)
    {
      return mcr.EvaluateFunction("psola1", input, fs);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray psola1(MWArray input, MWArray fs, MWArray anaPm)
    {
      return mcr.EvaluateFunction("psola1", input, fs, anaPm);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="anaPm">Input argument #3</param>
    /// <param name="timeScale">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray psola1(MWArray input, MWArray fs, MWArray anaPm, MWArray timeScale)
    {
      return mcr.EvaluateFunction("psola1", input, fs, anaPm, timeScale);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the psola1 M-function.
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray psola1(MWArray input, MWArray fs, MWArray anaPm, MWArray timeScale, 
                    MWArray pitchScale)
    {
      return mcr.EvaluateFunction("psola1", input, fs, anaPm, timeScale, pitchScale);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the psola1 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] psola1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the psola1 M-function.
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
    public MWArray[] psola1(int numArgsOut, MWArray input)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the psola1 M-function.
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
    public MWArray[] psola1(int numArgsOut, MWArray input, MWArray fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the psola1 M-function.
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
    public MWArray[] psola1(int numArgsOut, MWArray input, MWArray fs, MWArray anaPm)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs, anaPm);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the psola1 M-function.
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
    public MWArray[] psola1(int numArgsOut, MWArray input, MWArray fs, MWArray anaPm, 
                      MWArray timeScale)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs, anaPm, timeScale);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the psola1 M-function.
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
    public MWArray[] psola1(int numArgsOut, MWArray input, MWArray fs, MWArray anaPm, 
                      MWArray timeScale, MWArray pitchScale)
    {
      return mcr.EvaluateFunction(numArgsOut, "psola1", input, fs, anaPm, timeScale, pitchScale);
    }


    /// <summary>
    /// Provides an interface for the psola1 function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// input parameter adjustment
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void psola1(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("psola1", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray UnvoicedMod()
    {
      return mcr.EvaluateFunction("UnvoicedMod", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray UnvoicedMod(MWArray input)
    {
      return mcr.EvaluateFunction("UnvoicedMod", input);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray UnvoicedMod(MWArray input, MWArray fs)
    {
      return mcr.EvaluateFunction("UnvoicedMod", input, fs);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <param name="alpha">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray UnvoicedMod(MWArray input, MWArray fs, MWArray alpha)
    {
      return mcr.EvaluateFunction("UnvoicedMod", input, fs, alpha);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] UnvoicedMod(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] UnvoicedMod(int numArgsOut, MWArray input)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", input);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the UnvoicedMod M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <param name="fs">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] UnvoicedMod(int numArgsOut, MWArray input, MWArray fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", input, fs);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the UnvoicedMod M-function.
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
    public MWArray[] UnvoicedMod(int numArgsOut, MWArray input, MWArray fs, MWArray alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "UnvoicedMod", input, fs, alpha);
    }


    /// <summary>
    /// Provides an interface for the UnvoicedMod function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void UnvoicedMod(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("UnvoicedMod", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray UVSplit()
    {
      return mcr.EvaluateFunction("UVSplit", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray UVSplit(MWArray p)
    {
      return mcr.EvaluateFunction("UVSplit", p);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] UVSplit(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "UVSplit", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the UVSplit M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] UVSplit(int numArgsOut, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "UVSplit", p);
    }


    /// <summary>
    /// Provides an interface for the UVSplit function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// disp(sprintf('first=  d last=  d',first,last));</remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void UVSplit(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("UVSplit", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray VoicedSegmentMarking()
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the VoicedSegmentMarking
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// =========================================================================
    /// Find pitch mark candidates in voice segment
    /// =========================================================================
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray VoicedSegmentMarking(MWArray x)
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", x);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the VoicedSegmentMarking
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray VoicedSegmentMarking(MWArray x, MWArray p)
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", x, p);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the VoicedSegmentMarking
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
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray VoicedSegmentMarking(MWArray x, MWArray p, MWArray fs)
    {
      return mcr.EvaluateFunction("VoicedSegmentMarking", x, p, fs);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the VoicedSegmentMarking
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
    public MWArray[] VoicedSegmentMarking(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the VoicedSegmentMarking
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
    public MWArray[] VoicedSegmentMarking(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the VoicedSegmentMarking
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
    public MWArray[] VoicedSegmentMarking(int numArgsOut, MWArray x, MWArray p)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", x, p);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the VoicedSegmentMarking
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
    public MWArray[] VoicedSegmentMarking(int numArgsOut, MWArray x, MWArray p, MWArray 
                                    fs)
    {
      return mcr.EvaluateFunction(numArgsOut, "VoicedSegmentMarking", x, p, fs);
    }


    /// <summary>
    /// Provides an interface for the VoicedSegmentMarking function in which the input
    /// and output
    /// arguments are specified as an array of MWArrays.
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
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void VoicedSegmentMarking(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                           argsIn)
    {
      mcr.EvaluateFunction("VoicedSegmentMarking", numArgsOut, ref argsOut, argsIn);
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
