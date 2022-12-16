/*

*/
int notes[] = {262,294,330,349};
void setup() {
Serial.begin(9600);
// start serial comunication

}


void loop() {
    int keyVal = analogRead(A0);
    // Отчетената стойност на аналогов пин A0
    Serial.printIn(keyVal);
    //Изпраща стойността от A0 на Serial Monitor
    
    //изсвирва нотата, съотвеваща на порчетената от А0 стойност
    if(keyVal==1023){
      tone(8,notes[0]);
      // извирва първата нота(на цифров пин 8)
    }
    else if(keyVal>=990&& keyVal<=1010){
      tone(8,notes[1]);
      //Извира втората нота
    }
     else if(keyVal>=505&& keyVal<=515){
      tone(8,notes[2]);
      //Извира 3-тата нота
    }
     else if(keyVal>=5&& keyVal<=10){
      tone(8,notes[3]);
      //Извира 4-тата нота
    }
    else{
      noTone(8);// ne swiri nishto
      
    }
}
