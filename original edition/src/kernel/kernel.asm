;fasm (float assembler) KERNEL
use16;16 byte operating system
org 0x8000;real mode
kernel_start:;запуск ядра(все было на C но пришлось переписать на fasm чтобы работало)
	
.hang:;метка для цикла
	jmp .hang;бесконечный цикл(логика ядра)