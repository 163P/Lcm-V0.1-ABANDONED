function A= fade_out(wavename,fen,outname)
[wave,F,B]=wavread(wavename);
len=length(wave);
wave_change=wave;
for i=1 : (len/fen)        %淡出过程
 wave_change(len-i)=wave(len-i)*i/(len/fen); 
     wavwrite(wave_change,44100,B,outname);
A=1;
end                      %从一半处开始线性衰减
