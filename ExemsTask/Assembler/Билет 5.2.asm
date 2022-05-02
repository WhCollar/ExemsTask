org 100h
jmp start
msg db "Hi Yor!$"
start:
           
mov AH, 2           
mov DL, 0Dh
int 21h

mov AH, 2           
mov DL, 0Ah
int 21h
  
mov dx, offset msg
mov ah, 09h 
int 21h   
ret