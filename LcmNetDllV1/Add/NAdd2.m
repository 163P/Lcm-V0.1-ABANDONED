function G = Add2(f1,f2,ofn,fenshu)

    
[A,fs1,bit1] = wavread(f1);
[F,fs2,bit2] = wavread(f2);

c=round((fenshu-1)*length(A)/fenshu);
B=A(1:c);
C=A(c+1:end);

n1=length(C);
n2=length(F);
n1=[0:n1-1];
n2=[0:n2-1];
[a,n]=mat_add(C,n1,F,n2);

G = NAdd(B,a);



