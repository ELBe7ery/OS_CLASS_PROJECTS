import random

class boundedBuff():
    
    def __init__(self,n):
        self.inPtr=0
        self.outPtr=0
        self.n=n
        self.buff=['x']*n
        self.count=0                    #Added to solve the problem
    def takeFromBuff(self):
        if(self.outPtr!=self.inPtr):    #Don't take if buffer is empty
            self.buff[self.outPtr]='t'
            self.outPtr=(self.outPtr+1)%self.n
            print self.buff
            self.count-=1
    def putInBuff(self):
        if(self.buff[self.inPtr]!='p'): #Don't put if data is not consumed yet
            self.buff[self.inPtr]='p'
            self.inPtr=(self.inPtr+1)%self.n
            print self.buff
            self.count+=1
        
    def simBuff_old(self):              #The old way for the rounded buffer [Always one free spot]
        while(((self.inPtr+1)%self.n)!=self.outPtr):
            random.choice([self.putInBuff,self.takeFromBuff])()
            print 'IN: ',self.inPtr,'OUT: ',self.outPtr    
        print 'Buffer is full with these contents:\n',self.buff
        print 'and\nIN: ',self.inPtr,'OUT: ',self.outPtr 
        
    def simBuff_new(self):              #With the extra variable we got all of them
        while(self.count!=self.n):
            random.choice([self.putInBuff,self.takeFromBuff])()
            print 'IN: ',self.inPtr,'OUT: ',self.outPtr
            print self.buff  
        print 'Buffer is full with these contents:\n',self.buff
        print 'and\nIN: ',self.inPtr,'OUT: ',self.outPtr,'COUNT: ',self.count 
        
test=boundedBuff(7)

#test.simBuff_old() #only single T is found while the whole buffer was written to by the consumer [size-1]
test.simBuff_new()  #no T left, and the buffer is full 
