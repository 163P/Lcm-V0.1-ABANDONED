function A =LengthChange(filename,lenth,outfilename,fen,slenth,elenth,consonant,ofdir)
%��ȥ��������
CON=consonant/1000;
lenth=lenth-consonant/1000;
%��solafs��ȡWAV�ļ���
[Y,F,B]=wavread(filename);

%���㳤�ȱ�����
S=slenth/1000;
E=elenth/1000;
%�ָ����Ҫ�ĵط�;
Y2=Y(((F*S+1):F*E),:);
%wavwrite(Y2,F,'f:\LCM\444.wav');
%�ָ��(Y3��Ҫ�ӳ���)
ft = Y2(:,1);
sigLength = length(ft); %��ȡ��������
len=sigLength/F;

Y3=Y2(((F*CON+1):F*len),:);%����Ҫ�ӳ���
Y4=Y2(((F*0+1):F*CON),:);%���ǲ��ӳ���
%wavwrite(Y4,F,'f:\LCM\Y4.wav');
%wavwrite(Y3,F,'f:\LCM\Y3.wav');
%���������ļ�������������ֻ������һ�����������Ҫ�����ڶ����������Ը�Ϊ��ft=y(:,2);
ft = Y3(:,1);
sigLength = length(ft); %��ȡ��������
len=0.9*sigLength/F;
l=len/lenth;

%wavwrite(Y3,F,outfilename);
%solafs���֣�����ĩβ�𻯣�����û�����������԰ѱ����ӳ�һ��Ȼ����õ���
y=LengthOfSoundChange(Y3',l,400,200); 
wavwrite(y,F,[ofdir,'\aa.wav']);
pp=9*length(y)/10;
yy=y(1:pp);

%sound(y,sr)
%дWAV����

Y4=fade_in(Y4,fen);
y=fade_out(yy,fen);
wavwrite(Y4,F,[ofdir,'\a.wav']);
wavwrite(y,F,[ofdir,'\b.wav']);
Add([ofdir,'\a.wav'],[ofdir,'\b.wav'],outfilename);

%wavwrite(k,F,outfilename);

%����ֵ������Ϊ�����ʧ�ܹ�һ��
A = 1;