%
% pr10_7_2 
%clear all; clc; close all;
function A = Pitch(Fdir,Fname,oFname,pitchs,times)
   
global config;                          % ȫ�ֱ���config
config.pitchScale           = pitchs;	    % ���û�Ƶ�޸�����
config.timeScale            = times;	    % ����ʱ���޸�����
config.resamplingScale      = 1;		% �ز���
config.reconstruct          = 0;		% ���Ϊ����е�ͨ���ع�
config.cutOffFreq           = 500;	    % ��ͨ�˲����Ľ�ֹƵ��

global data;            % ȫ�ֱ���data,�ȳ�ʼ��
data.waveOut = [];		% ����Ƶ�޸����Ӻ�ʱ���޸����ӵ�����ĺϳ��������
data.pitchMarks = [];	% ���������źŵĻ��������ע
data.Candidates = [];	% ���������źŻ��������ע�ĺ�ѡ����

filedir=Fdir;                               % ���������ļ���·��
filename=Fname;                % ���������ļ�������
fle=[filedir filename];                    % ����·�����ļ������ַ���
[xx,fs]=wavread(fle);                     % ��ȡ�ļ�

%if isempty(xx(logical(xx)))=1;             %�ж��Ƿ�ΪR�������ļ���
%wavwrite(xx,fs,oFname);
%return
%end; 

xx=xx-mean(xx);                           % ȥ��ֱ������
WaveIn=xx/max(abs(xx));                   % ��һ��
N=length(WaveIn);                         % ���ݳ���
time=(0:N-1)/fs;                          % �����Ӧ��ʱ������

[LowPass] = LowPassFilter(WaveIn, fs, config.cutOffFreq); % ���źŽ��е�ͨ�˲�
PitchContour = PitchEstimation(LowPass, fs);% ��������źŵĻ����켣
PitchMarking1(WaveIn, PitchContour, fs);	% ���л��������ע��PSOLA�ϳ�
output=data.waveOut;
N1=length(output);                        % ������ݳ���
time1=(0:N1-1)/fs;                        % ���������е�ʱ������

%wavplay(xx,fs);
%pause(1)
%wavplay(output,fs)
output=output/4;
wavwrite(output,fs,oFname);

A = 1;

% ��ͼ
%subplot 211; plot(time,xx,'k'); 
%xlabel('ʱ��/s'); ylabel('��ֵ');
%axis([0 max(time) -1 1.2 ]); title('ԭʼ����')
%subplot 212; plot(time1,output,'k'); 
%xlabel('ʱ��/s'); ylabel('��ֵ');
%axis([0 max(time1) -1 1.5 ]); title('PSOLA�ϳ�����')

