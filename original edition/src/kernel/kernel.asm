;fasm (float assembler) KERNEL
use16;16 byte operating system
org 0x8000;real mode
kernel_start:;������ ����(��� ���� �� C �� �������� ���������� �� fasm ����� ��������)
	
.hang:;����� ��� �����
	jmp .hang;����������� ����(������ ����)