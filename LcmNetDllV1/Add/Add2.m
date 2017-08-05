function A = Add2(f1,f2,ofn,fenshu)

[A,fs1,bit1] = wavread(f1);
[F,fs2,bit2] = wavread(f2);
c=round((fenshu-1)*length(A)/fenshu);
B=A(1:c);
C=A(c+1:end);%先直接给C赋值分数，不用判断了，后面还会改

n1=length(C);
n2=length(F);
n1=[0:n1-1];
n2=[0:n2-1];
[a,n]=mat_add(C,n1,F,n2);
wavwrite(B,fs1,[ofn,'_b.wav']);
%a=a(:);
%a=real(a);
%a=a/max(a);

wavwrite(a,fs1,[ofn,'_a.wav']);
Add([ofn,'_b.wav'],[ofn,'_a.wav'],ofn);
delete([ofn,'_b.wav']);
delete([ofn,'_a.wav']);

C=0;
A=1;
