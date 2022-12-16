/*

*/
int svetodiod=13;
void setup() {
    pinMode(svetodiod,OUTPUT);
}

void loop() {
    digitalWrite(svetodiod,HIGH);
    delay(1000);
    digitalWrite(svetodiod,LOW);
    delay(1000);
}







