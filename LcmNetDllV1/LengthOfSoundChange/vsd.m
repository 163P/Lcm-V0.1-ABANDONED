function [x1,x2] = vsd(x) 
%x1有
%x2无
x = double(x);
x = x / max(abs(x));
FrameLen = 240;%帧长为240点
FrameInc = 80;%帧移为80点
 
amp1 = 10;%初始短时能量高门限
amp2 = 2;%初始短时能量低门限
zcr1 = 10;%初始短时过零率高门限
zcr2 = 5;%初始短时过零率低门限
maxsilence = 8;  % 8*10ms  = 80ms
minlen  = 15;    % 15*10ms = 150ms
%语音段的最短长度，若语音段长度小于此值，则认为其为一段噪音
status  = 0;     %初始状态为静音状态
count   = 0;     %初始语音段长度为0
silence = 0;     %初始静音段长度为0
tmp1  = enframe(x(1:end-1), FrameLen, FrameInc);
tmp2  = enframe(x(2:end)  , FrameLen, FrameInc);
signs = (tmp1.*tmp2)<0;
diffs = (tmp1 -tmp2)>0.02;
zcr   = sum(signs.*diffs, 2);
%计算短时能量
amp = sum(abs(enframe(x, FrameLen, FrameInc)), 2);
%调整能量门限
amp1 = min(amp1, max(amp)/4);
amp2 = min(amp2, max(amp)/8); 
%开始端点检测
x1 = 0;
x2 = 0;
for n=1:length(zcr) %length（zcr）得到的是整个信号的帧数
   goto = 0;
   switch status
   case {0,1}                   % 0 = 静音, 1 = 可能开始
      if amp(n) > amp1          % 确信进入语音段
         x1 = max(n-count-1,1);
         status  = 2;
         silence = 0;
         count   = count + 1;
      elseif amp(n) > amp2 | ... % 可能处于语音段
             zcr(n) > zcr2
         status = 1;
         count  = count + 1;
      else                       % 静音状态
         status  = 0;
         count   = 0;
      end
   case 2,                       % 2 = 语音段
      if amp(n) > amp2 | ...     % 保持在语音段
         zcr(n) > zcr2
         count = count + 1;
      else                       % 语音将结束
         silence = silence+1;
         if silence < maxsilence % 静音还不够长，尚未结束
            count  = count + 1;
         elseif count < minlen   % 语音长度太短，认为是噪声
            status  = 0;
            silence = 0;
            count   = 0;
         else                    % 语音结束
            status  = 3;
         end
      end
   case 3,
      break;
   end
end  
count = count-silence/2;
x2 = x1 + count -1;
y=x(x1*FrameInc:x2*FrameInc);
plot (y)

%wavwrite(y,fs,bits,'delsil.wav');
function f=enframe(x,win,inc)
nx=length(x);
nwin=length(win);
if (nwin == 1)
   len = win;
else
   len = nwin;
end
if (nargin < 3)
   inc = len;
end
nf = fix((nx-len+inc)/inc);%分得的帧数
f=zeros(nf,len);
indf= inc*(0:(nf-1)).';
inds = (1:len);
f(:) = x(indf(:,ones(1,len))+inds(ones(nf,1),:));
if (nwin > 1)
    w = win(:)';
    f = f .* w(ones(nf,1),:);
end