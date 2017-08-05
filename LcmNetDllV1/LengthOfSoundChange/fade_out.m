function wave_change= fade_out(wave,fen)
len=length(wave);
wave_change=wave;
for i=1 : (len/fen)        %淡出过程
 wave_change(len-i)=wave(len-i)*i/(len/fen); 
%     wavwrite(wave_change,44100,1411,'K.WAV');
end                      %从一半处开始线性衰减
