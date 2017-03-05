//------The include section-------------------------
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
//--------------------------------------------------

//------Definition for all the constants------------
#define INITIAL_INPUT_BUF_SIZE 256
#define INITIAL_INPUT_ARGLIST_SIZE 32
//--------------------------------------------------
/*
Bshell readLine function that returns a pointer to a character array in memory
It reads the user input with an initial size of a buffer of length 256 bytes
once the size is no longer enough, it reallocates a space in memory with size +=INITIAL_INPUT_BUF_SIZE
*/
char *bshell_readLine()
{
  char *userCmd=malloc(sizeof(char)*INITIAL_INPUT_BUF_SIZE);
  //let userCmd pointer points to a memory location that have INITIAL_INPUT_BUF_SIZE elements

  //Check if the memory space allocated successfully, if not terminate the process
  if(userCmd==NULL)
  {
    printf("ERROR ALLOCATING MEM\n");
    exit(EXIT_FAILURE);
  }

  char readChar=getchar();
  int bufferSize=INITIAL_INPUT_BUF_SIZE;
  int index=0;
  while(1)
  {
    if(readChar=='\n')
    {
      userCmd[index]='\0';
      return userCmd;
    }
    userCmd[index++]=readChar;
    if(index==bufferSize)
    {
      bufferSize+=INITIAL_INPUT_BUF_SIZE;
      userCmd=realloc(userCmd,sizeof(char)*bufferSize);
    }
    readChar=getchar();
  }
}
//--------------------------------------------------
/*
Bshell splitargs function that returns a pointer to a pinter array in memory
It expects the user input string with an initial size of a buffer list of length 32 pointer
once the size is no longer enough, it reallocates a space in memory with size +=INITIAL_INPUT_ARGLIST_SIZE
*/
char **bshell_splitArgs(char *userCmd)
{
  char **argList = malloc(sizeof(char*)*INITIAL_INPUT_ARGLIST_SIZE);
  //let argList pointer points to a memory location that have INITIAL_INPUT_ARGLIST_SIZE pointer elements

  //Check if the memory space allocated successfully, if not terminate the process
  if(argList==NULL)
  {
    printf("ERROR ALLOCATING MEM\n");
    exit(EXIT_FAILURE);
  }
  int argListSize=INITIAL_INPUT_ARGLIST_SIZE;
  int index=0;
  char *currentArg=strtok(userCmd," ");
  while(1)
  {
    if(currentArg==NULL)
    {
      argList[index]=NULL;
      return argList;
    }
    argList[index++]=currentArg;
    currentArg=strtok(NULL," ");
    if(index==argListSize)
    {
      argListSize+=INITIAL_INPUT_ARGLIST_SIZE;
      argList=realloc(argList,sizeof(char*)*argListSize);
    }
  }
}
// int main()
// {
//   char *c=bshell_readLine();
//   char **cc=bshell_splitArgs(c);
//   int i=0;
//   while(cc[i]!=NULL)
//     printf("%s\n", cc[i++]);
//   free(c);
//   free(cc);
//   // while (c[i]!='\0') {
//   //   printf("%c\n", c[i]);
//   // }
//   printf("HE1L");
// }
//--------------------------------------------------

/*---------------Notes Section----------------------
- Malloc returns a void pointer, which is a general C pointer that doesn't represent a pointer to
  a specific data type. So we don't need to cast the return of malloc {void* malloc (size_t size);}
  since it is assigned to a char pointer

- Sealloc returns a void pointer, that is a new pointer to the extended old memory block given as the 1st arg.
  {void* realloc (void* ptr, size_t size);} will go to ptr, copy it into some place, creates a new location,
  copy ptr contents to it, return the new ponter

- \0 is the NULL character, used to terminate strings in C. The advantage is we don't need to give the length
  of the character array, instead we need to loop through all the characters and stop once we find the null char.

- We need to use free() whenever we assign a pointer to the bshell_readLine() return
  whenever we are using it

- Why {malloc(sizeof(char)*INITIAL_INPUT_BUF_SIZE);} in this case it doesn't matter, since the char size is 1b
  recall, sizeof takes the size in byte. In other cases where out pointer points to int for example. We need
  to use sizeof(int); example: if int -> 2bytes. and we allocated in memory sizeof(int)*18 and assigned the
  returned void pointer which now points to the first byte in our 36 byte memory block, once its assigned to an
  int pointer. it now treats each element as if it was 2 bytes from the next/above element.
  in other words now we have(36/2) element integer array

- Same thing for {malloc(sizeof(char*)*INITIAL_INPUT_ARGLIST_SIZE)} we need to allocate some numer of bytes
  which is sizeof char pointer [8 bytes] * 32 which is equivalent to 256 byte in the memory. Since the returned
  pointer will be stored into a **char. now this new pointer treats these 256 bytes in the memory as each element
  is 8bytes away from the next/above element. in other words we have now 256/8 elemenets in this new array
  which is just an array of elements, each element is a pointer to other array that stores sequence of chars
  terminated with '\0'

- strok() always returns a pointer to the token found, once its done it returns NULL
---------------------------------------------------*/

/*-------------Thing i don't know-------------------
- Who does malloc()? is it a system call?.. same thing about free() ?
- Difference between exit() and _exit() system call
/--------------------------------------------------*/
