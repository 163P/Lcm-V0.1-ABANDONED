function  wave_change=fade_in(wave,fen)
len=length(wave);
wave_change=wave;
for i=1 : (len/fen)                           %淡入过程
 wave_change(i)=wave(i)*i/(len/fen);          %线性渐强，到一半处达到原始音量
end





