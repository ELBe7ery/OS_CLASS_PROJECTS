//------The include section-------------------------
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>
//--------------------------------------------------



void createChildProcess(char *args[])
{
  pid_t pid=fork();
  if(pid==0)        //Child here
  {
    if(execvp(args[0], args)==-1)
    {
      printf("\nFailed to execute this process\nPlease check the file name\n");
      exit(EXIT_FAILURE);
    }
  }
  else if(pid>0) //Parent here
  {
    wait(NULL);
    printf("\nExecuted the child process: %s with PID: %d\n",args[0],pid);
  }
}


/*---------------Notes Section----------------------
- We are using execvp "Typing man execvp" will tell us that that the function prototype looks sth like this
  {int execvp(const char *file, char *const argv[]);}, the first argument is thhe file name to be executed
  the second argument is the list of arguments to be given to this program

- Make sure the argument array has a NULL at its end, since this is the way the function knows this is the
  end of the arg list for a program to run, as mentioned on the man page
  "an  array  of pointers  to  null-terminated  strings that represent the argument list available
  to the new  program". Also from the man page
  "The first argument, by convention, should point to the
       filename associated with the file being executed.  The  list  of  argu‐
       ments  must be terminated by a null pointer"
  So make sure the process we are creating expects arg1, arg..n to be the real arg list while ignoring arg0

- From the man page
       "if the specified file‐ name does not contain a slash (/) character.  The file is sought in the
       colon-separated list of directory pathnames specified in the PATH envi‐
       ronment  variable.   If  this  variable  isn't  defined,  the path list
       defaults to the current directory followed by the list  of  directories
       returned by confstr(_CS_PATH).  (This confstr(3) call typically returns
       the value "/bin:/usr/bin".)
       If the specified filename includes a  slash  character,  then  PATH  is
       ignored, and the file at the specified pathname is executed.
       In addition, certain errors are treated specially."

- Stackexchange tip about resources
  "When a sub-process is spawned using fork, it inheritates the parent's process opened handles, files,
  console input/output, and anonymous pipes. These are the resources your document is talking about."
  -v.oddou

- This if condition {if(execvp(args[0], args)==-1)} wont exist if the exec function successfully called
  this is because exec will destroy the memory content of the child process [Data section] and refill it with
  the new given program [Which we gave its name as the 1st arg]

- wait(NULL) will suspend the parent untill the child is terminated
---------------------------------------------------*/

/*-------------Thing i don't know-------------------
- What is the status parameter given to wait? i have set this pointer parameter as a null
- What is a process state? what exactly this parameter has to do with the child ?
/--------------------------------------------------*/
