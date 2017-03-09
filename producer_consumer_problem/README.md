#A suggested solution for the producer consumer bounded buffer problem

Added an extra variable [count] such that a producer putting an item will increment this variable, a consumer taking an item will decrement this variable
and whenever the number of the added items equals to the number of the items that the buffer can hold, producer should wait until the consumer takes an item
an extra variable is used to solve this problem, as the item size that the buffer can hold increases or the buffer length increases this extra variable is not a problem
