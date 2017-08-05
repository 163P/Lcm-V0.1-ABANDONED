function A= fade_out(wavefile,outfilename)
[wave,fs,bit]wavread(wavefile);
           %从一半处开始线性衰减
len=length(wave);
wave_change=wave;
for i=1 : (len/10)        %淡出过程
 wave_change(len-i)=wave(len-i)*i/(len/10); 
end                      %从一半处开始线性衰减
wavwrite(wave_change,fs,outfilename);
A = 1;