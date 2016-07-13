#Open Stack#
Stack = []
MaxSize = 50
StackSize = len(Stack)
print(StackSize)
print(Stack)

def Push(NewItem,MaxStack):
    StackPointer = len(Stack)
    if StackPointer == MaxStack:
        print("Stack Full")
    else:
        StackPointer = len(Stack) + 1
        Stack.append(NewItem)
        print(StackSize)
        print(Stack)
Push(Stuff,MaxSize)
