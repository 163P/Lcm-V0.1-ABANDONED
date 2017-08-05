function [x1,x2] = vsd(x) 
%x1��
%x2��
x = double(x);
x = x / max(abs(x));
FrameLen = 240;%֡��Ϊ240��
FrameInc = 80;%֡��Ϊ80��
 
amp1 = 10;%��ʼ��ʱ����������
amp2 = 2;%��ʼ��ʱ����������
zcr1 = 10;%��ʼ��ʱ�����ʸ�����
zcr2 = 5;%��ʼ��ʱ�����ʵ�����
maxsilence = 8;  % 8*10ms  = 80ms
minlen  = 15;    % 15*10ms = 150ms
%�����ε���̳��ȣ��������γ���С�ڴ�ֵ������Ϊ��Ϊһ������
status  = 0;     %��ʼ״̬Ϊ����״̬
count   = 0;     %��ʼ�����γ���Ϊ0
silence = 0;     %��ʼ�����γ���Ϊ0
tmp1  = enframe(x(1:end-1), FrameLen, FrameInc);
tmp2  = enframe(x(2:end)  , FrameLen, FrameInc);
signs = (tmp1.*tmp2)<0;
diffs = (tmp1 -tmp2)>0.02;
zcr   = sum(signs.*diffs, 2);
%�����ʱ����
amp = sum(abs(enframe(x, FrameLen, FrameInc)), 2);
%������������
amp1 = min(amp1, max(amp)/4);
amp2 = min(amp2, max(amp)/8); 
%��ʼ�˵���
x1 = 0;
x2 = 0;
for n=1:length(zcr) %length��zcr���õ����������źŵ�֡��
   goto = 0;
   switch status
   case {0,1}                   % 0 = ����, 1 = ���ܿ�ʼ
      if amp(n) > amp1          % ȷ�Ž���������
         x1 = max(n-count-1,1);
         status  = 2;
         silence = 0;
         count   = count + 1;
      elseif amp(n) > amp2 | ... % ���ܴ���������
             zcr(n) > zcr2
         status = 1;
         count  = count + 1;
      else                       % ����״̬
         status  = 0;
         count   = 0;
      end
   case 2,                       % 2 = ������
      if amp(n) > amp2 | ...     % ������������
         zcr(n) > zcr2
         count = count + 1;
      else                       % ����������
         silence = silence+1;
         if silence < maxsilence % ����������������δ����
            count  = count + 1;
         elseif count < minlen   % ��������̫�̣���Ϊ������
            status  = 0;
            silence = 0;
            count   = 0;
         else                    % ��������
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
nf = fix((nx-len+inc)/inc);%�ֵõ�֡��
f=zeros(nf,len);
indf= inc*(0:(nf-1)).';
inds = (1:len);
f(:) = x(indf(:,ones(1,len))+inds(ones(nf,1),:));
if (nwin > 1)
    w = win(:)';
    f = f .* w(ones(nf,1),:);
end