





int a = 13; 
int b = 12; 
int c = 7; 
int button = 8;
byte lastButtonState;

void setup () 
{
pinMode(a, OUTPUT);
pinMode(b, OUTPUT);
pinMode(c, OUTPUT);

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
 
 digitalWrite(b, HIGH);
 delay(250);
 digitalWrite(b, LOW);
 delay(250);

 digitalWrite(c, HIGH);
 delay(250);
 digitalWrite(c, LOW);
 delay(250);

 digitalWrite(b, HIGH);
 delay(250);
 digitalWrite(b, LOW);
 delay(250);
 
 digitalWrite(a, HIGH);
 delay(250);
 digitalWrite(a, LOW);
 delay(250);


}

}











