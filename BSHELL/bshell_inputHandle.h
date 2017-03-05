//#pragma once  //I will be using the include guards

#ifndef BSHELL_INPUTHANDLE_H
#define BSHELL_INPUTHANDLE_H

char *bshell_readLine(void);
char **bshell_splitArgs(char *);

#endif
