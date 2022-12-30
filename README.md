# RibbonsColor with Recursive or Non Recursive find colors algorythm

Description: \
There are five ribbons. Each ribbon's length is the same, and the color of the ribbons is unique, so no two ribbons where the color is the same. There are the same amount of hole positions on the four ribbons. Whether the hole exists or not is random. One of the ribbons has no hole at all. 
If we put to the bottom the ribbon which hasn't any holes, put the other ribbons on top of that, and view the ribbon which is on the top, we can observe different colors in the holes, depending on whether the hole exists or not.\
for example, if the top ribbon has a hole and behind that, the ribbon has no hole at the same position we can see the ribbon color of the ribbon which is located behind the top ribbon.\
If the same position all four ribbons have a hole, we can see the ribbon color located on the bottom.

The task is, to create a program in C# that models five ribbons, based on the description above, and detects the visible colors when seeing the top ribbons' hole positions.

(Not an exhaustive solution because it is not too fast solution, five ribbons with 2 billions randomly generated hole positions. We can improve the performance with some assync or concurrent operations, for example one thread find the color in one position. Now I using bitwise operation, each bit is represent a hole position, so on one byte I able to represent eight hole positions. In this case the memory consumprion is lower than when we use one byte to one hole position.)


Recursive Run:\
![image](https://user-images.githubusercontent.com/26471568/210023022-d3f6fbbf-6a8f-4822-9824-2749e0179225.png)

Non Recursive Run:\
![image](https://user-images.githubusercontent.com/26471568/210022989-77ddb992-452a-426d-8507-ee6ca9826dc4.png)


Possible improvements:
- asyncronity for example each position can be run in a separate thread.
- optimize of the find colors, to less memory consumption.

To Do List:
- Unit tests to reach 80% code coverage!!!
- optimization

SO THE OPTIMIZATION STILL NOT FINISHED!
