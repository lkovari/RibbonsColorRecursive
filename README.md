# RibbonsColor with Recursive or Non Recursive find algorythm
Punched out colored ribbons problem recursive solution
5 ribbons with 1 billion holes.

(Not an exhaustive solution because it is not a fast solution 1 billion randomly generated hole positions on five ribbons, but we can improve that with some assync operations. Now I using bitwise operation each bit is represent a hole position, in this case the memory consumprion is lower than if represent a hole in one byte.)

Run:

Recursive:

![image](https://user-images.githubusercontent.com/26471568/209438364-d7d313d7-1ef1-45c2-850b-375581c72514.png)

Non Recursive:

![image](https://user-images.githubusercontent.com/26471568/209442083-5447db57-0948-4b6f-96f8-524ef8564f7a.png)


Possible improvements:

-asyncronity for example each position can be run in a separate thread.

-optimize find to less memory consumption


