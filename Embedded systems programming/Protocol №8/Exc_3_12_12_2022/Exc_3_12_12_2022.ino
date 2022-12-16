int a = 13; 
int temp = 8;
byte lastTempState;

void setup () 
{
pinMode(a, OUTPUT);

pinMode(A0,   INPUT);
Serial.begin(9600);

byte lastTempState= digitalRead(temp);
}


void loop() 
{
Serial.println(A0);
int tempValue=analogRead(A0);
digitalWrite(a, HIGH);
delay(tempValue);
digitalWrite(a, LOW);
delay(tempValue);

}