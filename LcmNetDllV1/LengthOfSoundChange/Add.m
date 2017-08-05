function A = Add(wavfile1,wavfile2,ofn)
[A,fs1,bit1] = wavread(wavfile1);
[B,fs2,bit2] = wavread(wavfile2);
C=[A;B];
%C = C(logical(C));
wavwrite(C,fs1,ofn);
A = 1;