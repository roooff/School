int a = 13; 
int button = 8;
byte lastButtonState;

void setup () 
{
pinMode(a, OUTPUT);
byte lastButtonState= digitalRead(button);
}


void loop() 
{
byte currbuttonstate= digitalRead(button);
if(currbuttonstate != lastButtonState)
{
   digitalWrite(a, HIGH);
 delay(250);
 digitalWrite(a, LOW);
 delay(250);
 
}

}