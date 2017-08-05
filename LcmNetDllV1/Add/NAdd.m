function C = Add(wavfile1,wavfile2)
if mode(wavfile1) >0.1
wavfile1 = wavfile1(logical(wavfile1));
end
if mode(wavfile2) >0.1
wavfile2 = wavfile2(logical(wavfile2));
end
C = NAdd3(wavfile1,wavfile2)

C = C(logical(C));
