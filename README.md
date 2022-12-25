# RibbonsColor with Recursive or Non Recursive find algorythm
Punched out colored ribbons problem recursive solution
5 ribbons with 1 billion holes.

Description: There are five ribbons. Each ribbon's length is the same, and the color of the ribbons is unique, so no two ribbons where the color is the same. There are the same amount of hole positions on four ribbons. Whether the hole exists or not is random. One of the ribbons has no hole at all. Put the ribbon on a table that has no hole, and put on it all the other ribbons. Where there is a hole on the top ribbon, you will see the color of the ribbon which is under in that case if there is no hole on that ribbon. 

The task is, to create a program in C# that models five ribbons, based on the description above, and detects the visible colors when seeing the top ribbons' hole positions.

(Not an exhaustive solution because it is not a fast solution 1 billion randomly generated hole positions on five ribbons, but we can improve that with some assync operations. Now I using bitwise operation each bit is represent a hole position, in this case the memory consumprion is lower than if represent a hole in one byte.)

Run:

Recursive:

![image](https://user-images.githubusercontent.com/26471568/209467765-6620cc9b-f34b-4d4e-a310-7c14d189a760.png)

Non Recursive:

![image](https://user-images.githubusercontent.com/26471568/209466890-b49d8716-396b-4eb4-808e-f3ad4a0c4948.png)


Possible improvements:

-asyncronity for example each position can be run in a separate thread.

-optimize find to less memory consumption


