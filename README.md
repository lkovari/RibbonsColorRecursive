# RibbonsColor with Recursive or Non Recursive find algorythm
Punched out colored ribbons problem recursive solution
5 ribbons with 1 billion holes.

(Not an exhaustive solution because it is not a fast solution 1 billion randomly generated hole positions on five ribbons, but we can improve that with some assync operations. Now I using bitwise operation each bit is represent a hole position, in this case the memory consumprion is lower than if represent a hole in one byte.)

Run:

Recursive:

![image](https://user-images.githubusercontent.com/26471568/209438364-d7d313d7-1ef1-45c2-850b-375581c72514.png)

Non Recursive:

![image](https://user-images.githubusercontent.com/26471568/209452477-25be462d-767b-4290-95e9-4e808b794672.png)


Possible improvements:

-asyncronity for example each position can be run in a separate thread.

-optimize find to less memory consumption


