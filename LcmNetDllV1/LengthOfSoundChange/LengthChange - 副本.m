function A =LengthChange(filename,lenth,outfilename,fen)

%��solafs��ȡWAV�ļ���
[Y,F,B]=wavread(filename);


%���������ļ�������������ֻ������һ�����������Ҫ�����ڶ����������Ը�Ϊ��ft=y(:,2);
ft = Y3(:,1);
sigLength = length(ft); %��ȡ��������
len=sigLength/F;
l=len/lenth;

%wavwrite(Y3,F,outfilename);
%solafs���֣�����ĩβ�𻯣�����û�����������԰ѱ����ӳ�һ��Ȼ����õ���
y=LengthOfSoundChange(Y3',l,400,200); 

%sound(y,sr)
%дWAV����
Y4=fade_in(Y4,fen);
y=fade_out(y,fen);
wavwrite(Y4,F,[ofdir,'\a.wav']);
wavwrite(y,F,[ofdir,'\b.wav']);
Add([ofdir,'\a.wav'],[ofdir,'\b.wav'],outfilename);

%wavwrite(k,F,outfilename);

%����ֵ������Ϊ�����ʧ�ܹ�һ��
A = 1;