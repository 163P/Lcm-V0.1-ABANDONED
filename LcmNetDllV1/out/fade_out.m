function A= fade_out(wavefile,outfilename)
[wave,fs,bit]wavread(wavefile);
           %��һ�봦��ʼ����˥��
len=length(wave);
wave_change=wave;
for i=1 : (len/10)        %��������
 wave_change(len-i)=wave(len-i)*i/(len/10); 
end                      %��һ�봦��ʼ����˥��
wavwrite(wave_change,fs,outfilename);
A = 1;