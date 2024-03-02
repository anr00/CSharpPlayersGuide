State current = State.Open;

while (true)
{
    Console.WriteLine($"The chest is {current}. What do you want to do?");
    string answer = Console.ReadLine();
               
    if (current == State.Open && answer == "close") current = State.Close;      
    if (current == State.Close && answer == "open") current = State.Open;
    if (current == State.Close && answer == "lock") current = State.Lock;
    if (current == State.Lock && answer == "unlock") current = State.Close;     
}

enum State { Close, Open, Lock }