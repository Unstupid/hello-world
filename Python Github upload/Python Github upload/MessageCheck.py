Work = "Banana"
Arr = ["Apple","Banana","Table","Mouse","Stupid","Arrythmia","Rhythm","Eejit","Idiosynchrasy","Cat","Mat","Doctor","Seuss","Thing","One","Two","Chitty","Bang"]
def Call(Num):
    print(Num)
def ReceiveMessage(Dictionary,Message,PhoneNumber,RightAns):
    Right = False
    for n in range(0,len(Dictionary)):
        if Dictionary[n].upper == Message.upper:
            Right = True
    if len(Message) != 6:
        Right = False
    if Right == True and RightAns == Message:
        Call(PhoneNumber)
    else:
        print("Wrong word")
ReceiveMessage(Arr,"Bnaena","01204 755564",Work)
