function A= fade_out(wavename,fen,outname)
[wave,F,B]=wavread(wavename);
len=length(wave);
wave_change=wave;
for i=1 : (len/fen)        %��������
 wave_change(len-i)=wave(len-i)*i/(len/fen); 
     wavwrite(wave_change,44100,B,outname);
A=1;
end                      %��һ�봦��ʼ����˥��
