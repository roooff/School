int a = 13; 
int potention = 8;
byte lastPonState;

void setup () 
{
pinMode(a, OUTPUT);

pinMode(A0,   INPUT);
Serial.begin(9600);

byte lastPonState= digitalRead(potention);
}


void loop() 
{
Serial.println(A0);
int potValue=analogRead(A0);
digitalWrite(a, HIGH);
delay(potValue);
digitalWrite(a, LOW);
delay(potValue);

}
