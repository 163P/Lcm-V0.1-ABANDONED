function wave_change= fade_out(wave,fen)
len=length(wave);
wave_change=wave;
for i=1 : (len/fen)        %��������
 wave_change(len-i)=wave(len-i)*i/(len/fen); 
%     wavwrite(wave_change,44100,1411,'K.WAV');
end                      %��һ�봦��ʼ����˥��
