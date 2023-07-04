int x = 10;
int y = Method();

int Method()
{
    y = 20;
    return y;
}
// O valor de y continuará existindo como 20


if (x > 0)
{
    y = 30;
}
//O valor do y só vai existir no escopo de if


Console.WriteLine( x + y);


