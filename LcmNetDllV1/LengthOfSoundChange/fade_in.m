function  wave_change=fade_in(wave,fen)
len=length(wave);
wave_change=wave;
for i=1 : (len/fen)                           %�������
 wave_change(i)=wave(i)*i/(len/fen);          %���Խ�ǿ����һ�봦�ﵽԭʼ����
end





