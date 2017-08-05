function A =LengthChange(filename,lenth,outfilename,fen,slenth,elenth,consonant,ofdir)
%减去辅音长度
CON=consonant/1000;
lenth=lenth-consonant/1000;
%给solafs读取WAV文件用
[Y,F,B]=wavread(filename);

%计算长度倍数用
S=slenth/1000;
E=elenth/1000;
%分割出需要的地方;
Y2=Y(((F*S+1):F*E),:);
%wavwrite(Y2,F,'f:\LCM\444.wav');
%分割辅音(Y3是要延长的)
ft = Y2(:,1);
sigLength = length(ft); %获取声音长度
len=sigLength/F;

Y3=Y2(((F*CON+1):F*len),:);%这是要延长的
Y4=Y2(((F*0+1):F*CON),:);%这是不延长的
%wavwrite(Y4,F,'f:\LCM\Y4.wav');
%wavwrite(Y3,F,'f:\LCM\Y3.wav');
%假设声音文件有两个声道，只分析第一个声道，如果要分析第二个声道可以改为：ft=y(:,2);
ft = Y3(:,1);
sigLength = length(ft); %获取声音长度
len=0.9*sigLength/F;
l=len/lenth;

%wavwrite(Y3,F,outfilename);
%solafs部分（可能末尾羽化，不过没有做处理，可以把倍数延长一点然后剪裁掉）
y=LengthOfSoundChange(Y3',l,400,200); 
wavwrite(y,F,[ofdir,'\aa.wav']);
pp=9*length(y)/10;
yy=y(1:pp);

%sound(y,sr)
%写WAV部分

Y4=fade_in(Y4,fen);
y=fade_out(yy,fen);
wavwrite(Y4,F,[ofdir,'\a.wav']);
wavwrite(y,F,[ofdir,'\b.wav']);
Add([ofdir,'\a.wav'],[ofdir,'\b.wav'],outfilename);

%wavwrite(k,F,outfilename);

%返回值。。。为了这个失败过一次
A = 1;