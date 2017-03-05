//------The include section-------------------------
#include <stdio.h>
#include <stdlib.h>
#include "bshell_core.h"
#include "bshell_inputHandle.h"
//--------------------------------------------------

//------Definition for all the constants------------
#define LINE_CHAR '$'
//--------------------------------------------------


int main()
{
  while(1)
  {
    printf("%c",LINE_CHAR);
    char *userCmd = bshell_readLine();
    char **args =  bshell_splitArgs(userCmd);
    createChildProcess(args);

    free(userCmd);
    free(args);
  }

}
