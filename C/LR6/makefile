prog.exe: TreeGarden_v2.o Tree.o
	gcc -o prog.exe TreeGarden_v2.o Tree.o

TreeGarden_v2.o: TreeGarden_v2.c Tree.h
	gcc -O0 -g3 -Wall -c TreeGarden_v2.c
	gcc -masm=intel -g3 -Wall -c TreeGarden_v2.c -S

Tree.o: Tree.c Tree.h Node.h
	gcc -O0 -g3 -Wall -c Tree.c
	gcc -masm=intel -g3 -Wall -c Tree.c -S

Node.o: Node.c Node.h
	gcc -O0 -g3 -Wall -c Node.c
	gcc -masm=intel -g3 -Wall -c Node.c -S

clean:
	rm -rf *.s *.o *.exe

run:
	prog.exe

build: prog.exe