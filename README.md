# RibbonsColor with Recursive or Non Recursive find colors algorythm

Description: \
There are five ribbons. Each ribbon's length is the same, and the color of the ribbons is unique, so no two ribbons where the color is the same. There are the same amount of hole positions on four ribbons. Whether the hole exists or not is random. One of the ribbons has no hole at all. Put the ribbon on a table that has no hole, and put on it all the other ribbons.(the order is doesn't matter) Where there is a hole on the top ribbon, you will see the color of the ribbon which is under in that case if there is no hole on that ribbon. 

The task is, to create a program in C# that models five ribbons, based on the description above, and detects the visible colors when seeing the top ribbons' hole positions.

(Not an exhaustive solution because it is not too fast solution, five ribbons with 1 billion randomly generated hole positions. We can improve the performance with some assync or concurrent operations, for example one thread find the color in one position. Now I using bitwise operation, each bit is represent a hole position, so on one byte I able to represent eight hole positions. In this case the memory consumprion is lower than when we use one byte to one hole position.)


Recursive Run:\
![image](https://user-images.githubusercontent.com/26471568/209814025-b28d449b-6cce-4af2-9892-ef63d317e19c.png)

Non Recursive Run:\
![image](https://user-images.githubusercontent.com/26471568/209815318-7f4d3b79-fe9b-4334-af00-670e29d23640.png)


Possible improvements:
- asyncronity for example each position can be run in a separate thread.\
- optimize find to less memory consumption.

To Do List:
- UNIT TESTS

SO THE OPTIMIZATION STILL NOT FINISHED!
