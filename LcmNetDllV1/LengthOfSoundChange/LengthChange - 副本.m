function A =LengthChange(filename,lenth,outfilename,fen)

%给solafs读取WAV文件用
[Y,F,B]=wavread(filename);


%假设声音文件有两个声道，只分析第一个声道，如果要分析第二个声道可以改为：ft=y(:,2);
ft = Y3(:,1);
sigLength = length(ft); %获取声音长度
len=sigLength/F;
l=len/lenth;

%wavwrite(Y3,F,outfilename);
%solafs部分（可能末尾羽化，不过没有做处理，可以把倍数延长一点然后剪裁掉）
y=LengthOfSoundChange(Y3',l,400,200); 

%sound(y,sr)
%写WAV部分
Y4=fade_in(Y4,fen);
y=fade_out(y,fen);
wavwrite(Y4,F,[ofdir,'\a.wav']);
wavwrite(y,F,[ofdir,'\b.wav']);
Add([ofdir,'\a.wav'],[ofdir,'\b.wav'],outfilename);

%wavwrite(k,F,outfilename);

%返回值。。。为了这个失败过一次
A = 1;