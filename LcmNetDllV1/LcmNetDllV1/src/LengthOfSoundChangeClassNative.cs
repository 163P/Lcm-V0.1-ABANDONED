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

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace LcmNetDllV1Native
{

  /// <summary>
  /// The LengthOfSoundChangeClass class provides a CLS compliant, Object (native)
  /// interface to the M-functions contained in the files:
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\LengthOfSoundChange\fade_in.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\LengthOfSoundChange\fade_out.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\LengthOfSoundChange\LengthChange.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\LengthOfSoundChange\LengthOfSoundChange.m
  /// <newpara></newpara>
  /// E:\LcmNetDllV1\LengthOfSoundChange\VBOUT.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class LengthOfSoundChangeClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static LengthOfSoundChangeClass()
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
    /// Constructs a new instance of the LengthOfSoundChangeClass class.
    /// </summary>
    public LengthOfSoundChangeClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~LengthOfSoundChangeClass()
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
    /// Provides a single output, 0-input Objectinterface to the fade_in M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fade_in()
    {
      return mcr.EvaluateFunction("fade_in", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the fade_in M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="wave">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fade_in(Object wave)
    {
      return mcr.EvaluateFunction("fade_in", wave);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the fade_in M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="wave">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fade_in(Object wave, Object fen)
    {
      return mcr.EvaluateFunction("fade_in", wave, fen);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the fade_in M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fade_in(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fade_in", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the fade_in M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wave">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fade_in(int numArgsOut, Object wave)
    {
      return mcr.EvaluateFunction(numArgsOut, "fade_in", wave);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the fade_in M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wave">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fade_in(int numArgsOut, Object wave, Object fen)
    {
      return mcr.EvaluateFunction(numArgsOut, "fade_in", wave, fen);
    }


    /// <summary>
    /// Provides an interface for the fade_in function in which the input and output
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
    [MATLABSignature("fade_in", 2, 1, 0)]
    protected void fade_in(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("fade_in", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the fade_out M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fade_out()
    {
      return mcr.EvaluateFunction("fade_out", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the fade_out M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <param name="wave">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fade_out(Object wave)
    {
      return mcr.EvaluateFunction("fade_out", wave);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the fade_out M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <param name="wave">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fade_out(Object wave, Object fen)
    {
      return mcr.EvaluateFunction("fade_out", wave, fen);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the fade_out M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fade_out(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fade_out", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the fade_out M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wave">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fade_out(int numArgsOut, Object wave)
    {
      return mcr.EvaluateFunction(numArgsOut, "fade_out", wave);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the fade_out M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wave">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fade_out(int numArgsOut, Object wave, Object fen)
    {
      return mcr.EvaluateFunction(numArgsOut, "fade_out", wave, fen);
    }


    /// <summary>
    /// Provides an interface for the fade_out function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// wavwrite(wave_change,44100,1411,'K.WAV');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("fade_out", 2, 1, 0)]
    protected void fade_out(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("fade_out", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange()
    {
      return mcr.EvaluateFunction("LengthChange", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename)
    {
      return mcr.EvaluateFunction("LengthChange", filename);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth, Object outfilename)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth, outfilename);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth, Object outfilename, Object 
                         fen)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth, outfilename, fen);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth, Object outfilename, Object 
                         fen, Object slenth)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth, outfilename, fen, slenth);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <param name="elenth">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth, Object outfilename, Object 
                         fen, Object slenth, Object elenth)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth, outfilename, fen, slenth, elenth);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <param name="elenth">Input argument #6</param>
    /// <param name="consonant">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth, Object outfilename, Object 
                         fen, Object slenth, Object elenth, Object consonant)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth, outfilename, fen, slenth, elenth, consonant);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <param name="elenth">Input argument #6</param>
    /// <param name="consonant">Input argument #7</param>
    /// <param name="ofdir">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthChange(Object filename, Object lenth, Object outfilename, Object 
                         fen, Object slenth, Object elenth, Object consonant, Object 
                         ofdir)
    {
      return mcr.EvaluateFunction("LengthChange", filename, lenth, outfilename, fen, slenth, elenth, consonant, ofdir);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth, Object 
                           outfilename)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth, outfilename);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth, Object 
                           outfilename, Object fen)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth, outfilename, fen);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth, Object 
                           outfilename, Object fen, Object slenth)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth, outfilename, fen, slenth);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <param name="elenth">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth, Object 
                           outfilename, Object fen, Object slenth, Object elenth)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth, outfilename, fen, slenth, elenth);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <param name="elenth">Input argument #6</param>
    /// <param name="consonant">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth, Object 
                           outfilename, Object fen, Object slenth, Object elenth, Object 
                           consonant)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth, outfilename, fen, slenth, elenth, consonant);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the LengthChange M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <param name="lenth">Input argument #2</param>
    /// <param name="outfilename">Input argument #3</param>
    /// <param name="fen">Input argument #4</param>
    /// <param name="slenth">Input argument #5</param>
    /// <param name="elenth">Input argument #6</param>
    /// <param name="consonant">Input argument #7</param>
    /// <param name="ofdir">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthChange(int numArgsOut, Object filename, Object lenth, Object 
                           outfilename, Object fen, Object slenth, Object elenth, Object 
                           consonant, Object ofdir)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthChange", filename, lenth, outfilename, fen, slenth, elenth, consonant, ofdir);
    }


    /// <summary>
    /// Provides an interface for the LengthChange function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 减去辅音长度
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("LengthChange", 8, 1, 0)]
    protected void LengthChange(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("LengthChange", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange()
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F, Object W)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F, W);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F, Object W, Object Wov)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F, W, Wov);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F, Object W, Object Wov, Object 
                                Kmax)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F, W, Wov, Kmax);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <param name="Wsim">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F, Object W, Object Wov, Object 
                                Kmax, Object Wsim)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F, W, Wov, Kmax, Wsim);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <param name="Wsim">Input argument #6</param>
    /// <param name="xdecim">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F, Object W, Object Wov, Object 
                                Kmax, Object Wsim, Object xdecim)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F, W, Wov, Kmax, Wsim, xdecim);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <param name="Wsim">Input argument #6</param>
    /// <param name="xdecim">Input argument #7</param>
    /// <param name="kdecim">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object LengthOfSoundChange(Object X, Object F, Object W, Object Wov, Object 
                                Kmax, Object Wsim, Object xdecim, Object kdecim)
    {
      return mcr.EvaluateFunction("LengthOfSoundChange", X, F, W, Wov, Kmax, Wsim, xdecim, kdecim);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F, Object W)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F, W);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F, Object W, 
                                  Object Wov)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F, W, Wov);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F, Object W, 
                                  Object Wov, Object Kmax)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F, W, Wov, Kmax);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <param name="Wsim">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F, Object W, 
                                  Object Wov, Object Kmax, Object Wsim)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F, W, Wov, Kmax, Wsim);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <param name="Wsim">Input argument #6</param>
    /// <param name="xdecim">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F, Object W, 
                                  Object Wov, Object Kmax, Object Wsim, Object xdecim)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F, W, Wov, Kmax, Wsim, xdecim);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the LengthOfSoundChange
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="X">Input argument #1</param>
    /// <param name="F">Input argument #2</param>
    /// <param name="W">Input argument #3</param>
    /// <param name="Wov">Input argument #4</param>
    /// <param name="Kmax">Input argument #5</param>
    /// <param name="Wsim">Input argument #6</param>
    /// <param name="xdecim">Input argument #7</param>
    /// <param name="kdecim">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] LengthOfSoundChange(int numArgsOut, Object X, Object F, Object W, 
                                  Object Wov, Object Kmax, Object Wsim, Object xdecim, 
                                  Object kdecim)
    {
      return mcr.EvaluateFunction(numArgsOut, "LengthOfSoundChange", X, F, W, Wov, Kmax, Wsim, xdecim, kdecim);
    }


    /// <summary>
    /// Provides an interface for the LengthOfSoundChange function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Y = solafs(X, F, W, Wov, Kmax, Wsim, xdec, kdec)   Do SOLAFS timescale mod'n
    /// Y is X scaled to run F x faster.  X is added-in in windows
    /// W pts long, overlapping by Wov points with the previous output.  
    /// The similarity is calculated over the last Wsim points of output.
    /// Maximum similarity skew is Kmax pts.
    /// Each xcorr calculation is decimated by xdecim (8)
    /// The skew axis sampling is decimated by kdecim (2)
    /// Defaults (for 22k) W = 200, Wov = W/2, Kmax = 2*W, Wsim=Wov.
    /// Based on "The SOLAFS time-scale modification algorithm", 
    /// Don Hejna &amp; Bruce Musicus, BBN, July 1991.
    /// 1997may16 dpwe@icsi.berkeley.edu $Header:
    /// /homes/dpwe/matlab/dpwebox/RCS/solafs.m,v 1.3 2006/04/09 20:10:20 dpwe Exp $
    /// 2006-04-08: fix to predicted step size, thanks to Andreas Tsiartas
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("LengthOfSoundChange", 8, 1, 0)]
    protected void LengthOfSoundChange(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("LengthOfSoundChange", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VBOUT()
    {
      return mcr.EvaluateFunction("VBOUT", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="wavename">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VBOUT(Object wavename)
    {
      return mcr.EvaluateFunction("VBOUT", wavename);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="wavename">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VBOUT(Object wavename, Object fen)
    {
      return mcr.EvaluateFunction("VBOUT", wavename, fen);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="wavename">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <param name="outname">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object VBOUT(Object wavename, Object fen, Object outname)
    {
      return mcr.EvaluateFunction("VBOUT", wavename, fen, outname);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VBOUT(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "VBOUT", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wavename">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VBOUT(int numArgsOut, Object wavename)
    {
      return mcr.EvaluateFunction(numArgsOut, "VBOUT", wavename);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wavename">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VBOUT(int numArgsOut, Object wavename, Object fen)
    {
      return mcr.EvaluateFunction(numArgsOut, "VBOUT", wavename, fen);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the VBOUT M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="wavename">Input argument #1</param>
    /// <param name="fen">Input argument #2</param>
    /// <param name="outname">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] VBOUT(int numArgsOut, Object wavename, Object fen, Object outname)
    {
      return mcr.EvaluateFunction(numArgsOut, "VBOUT", wavename, fen, outname);
    }


    /// <summary>
    /// Provides an interface for the VBOUT function in which the input and output
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
    [MATLABSignature("VBOUT", 3, 1, 0)]
    protected void VBOUT(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("VBOUT", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
