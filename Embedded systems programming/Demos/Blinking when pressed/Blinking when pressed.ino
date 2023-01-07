int LED1=13;
int LED2=12;
int LED3=11;
int button=10;
byte lastButtonState;

void setup() {
 pinMode(LED1,OUTPUT);
 pinMode(LED2,OUTPUT);
 pinMode(LED3,OUTPUT);
 pinMode(button,OUTPUT);
 lastButtonState= digitalRead(button);

}

void loop() {
  byte currButtonState= digitalRead(button);
  if (currButtonState!=lastButtonState)
  {
      digitalWrite(LED1,HIGH);
      delay(200);
      digitalWrite(LED2,HIGH);
      delay(200);
      digitalWrite(LED3,HIGH);
      delay(200);
      digitalWrite(LED1,LOW);
      delay(200);
      digitalWrite(LED2,LOW);
      delay(200);
      digitalWrite(LED3,LOW);
      delay(200);
      

  }

}
