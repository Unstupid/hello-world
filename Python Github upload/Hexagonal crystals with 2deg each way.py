from turtle import *
X = int(input("Please input the first length"))
Y = int(input("Please input the second length"))
A = int(input("Please input the value of the angle"))
a = round(A,1)
x = round(X,1)
y = round(Y,1)
def TurtleShow():
    if a or round(180 - A,1) == 60:
        RepeatTime = 3
    else:
        RepeatTime = 2
    for n in range(0,RepeatTime%2):
        forward(x)
        left(a)
        forward(y)
        left(180 - a)
if 87 < A < 93:
    if X - X/10 < Y < X + X/10:
        print("Square")
    else:
        print("Rectangular")
    for n in range(0,2):
        forward(X)
        left(90)
        forward(Y)
        left(90)
elif 57 < A < 63 or 117 < A < 123:
    print("Hexagonal")
else:
    if X - X/10 < Y < X + X/10:
        print("Rhombic")
    else:
        print("Parallelogramic")
for n in range(0,12):
    TurtleShow()
    left(180 + a)
    TurtleShow()
