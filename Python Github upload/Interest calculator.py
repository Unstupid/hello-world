def Money(Start,YearPay,Time,Interest):
     for n in range(0,Time):
          Interesting = Start + YearPay
          YearInterest = Interesting*Interest
          Start = Interesting + YearInterest
          StartDec = int(100*Start)
          Start = StartDec/100
          print("At the end of year "+str(n+1) + " you have £" + str(Start) + " in your account")
     return Start
def MoneyRec(Start,YearPay,Time,Interest,OrigTime):
     if Time > 0:
          Interesting = Start + YearPay
          YearInterest = Interesting*Interest
          Start = Interesting + YearInterest
          StartDec = int(100*Start)
          Start = StartDec/100
          print("At the end of year "+ str(OrigTime - Time +1) + " you have £" + str(Start) + " in your account")
          MoneyRec(Start,YearPay,Time - 1,Interest,OrigTime)
Money(0,100,5,0.1)
MoneyRec(0,100,5,0.1,5)
